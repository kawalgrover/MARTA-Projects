using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Linq;
using System.Linq;
using Microsoft.SharePoint.Meetings;
using System.Collections;
using Microsoft.Office.Server.Utilities;

namespace MARTA.PaperlessBoard.List_Definitions.Board_Agenda.AgendaUpdatingReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class AgendaUpdatingReceiver : SPItemEventReceiver
    {
        private string boardSiteURL = null;
        private string lookAheadListInEmis = null;
        private string lookAheadListNameInBoard = null;
        private string boardMeetingListName = null;
        private string emisSiteURL = null;
        private string libraryNameInDocumentWorkspace = null;

        private void InitializeWebAppProperties(SPItemEventProperties properties)
        {
            //SPWeb currentWeb = SPContext.Current.Web;
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = properties.Web.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                if (webApplication.Properties.ContainsKey("DefaultDocumentsLibrary"))
                {
                    lookAheadListInEmis = webApplication.Properties["LookAheadListNameinEmis"].ToString();
                    boardSiteURL = webApplication.Properties["BoardSiteURL"].ToString();
                    boardMeetingListName = webApplication.Properties["BoardMeetingListName"].ToString();
                    lookAheadListNameInBoard = webApplication.Properties["LookAheadListName"].ToString();
                    emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
                    libraryNameInDocumentWorkspace = webApplication.Properties["LibraryNameInDocumentWorkspace"].ToString();
                }
            }

        }
       /// <summary>
       /// An item is being updated.
       /// </summary>
       public override void ItemUpdating(SPItemEventProperties properties)
       {
           SPSecurity.RunWithElevatedPrivileges(delegate()
                  {
                      string originalMeetingID = properties.ListItem["CommitteeMeeting"].ToString();
                      if (properties.AfterProperties["CommitteeMeeting"] != null)
                      {
                          string newMeetingID = properties.AfterProperties["CommitteeMeeting"].ToString();
                          string originalTitle = properties.ListItem["Title"].ToString();
                          string newTitle = properties.AfterProperties["Title"].ToString();



                          if (originalMeetingID != newMeetingID)
                          {
                              InitializeWebAppProperties(properties);
                              // Get the meeting details (Meeting Title, Meeting Date)
                              string newMeetingTitle = null;
                              string newMeetingDate = null;


                              //Get the meeting date of the new Meeting ID
                              using (SPSite boardSite = new SPSite(boardSiteURL))
                              using (SPWeb boardWeb = boardSite.OpenWeb())
                              {
                                  SPList meetingsList = boardWeb.Lists[boardMeetingListName];
                                  SPQuery query = new SPQuery()
                                  {
                                      Query = string.Format(@"<Where>
                                                            <Eq>
                                                                <FieldRef Name='ID'/>
                                                                <Value Type='Number'>{0}</Value>
                                                            </Eq>
                                                        </Where>", newMeetingID)
                                  };
                                  foreach (SPListItem meeting in meetingsList.GetItems(query))
                                  {
                                      newMeetingTitle = meeting["Title"].ToString();
                                      newMeetingDate = meeting["EventDate"].ToString();
                                  }
                              }


                              //Before we move the meeting, ensure that this does not confict with the Bid Date if this is Procurement Resolution.
                              if (properties.ListItem["AgendaType"].ToString() == "Procurement Resolution")
                              {
                                  //Get the document workspace of this Agenda
                                  string documentWorkspaceLink = properties.ListItem["DocumentWorkspace"].ToString();
                                  documentWorkspaceLink = documentWorkspaceLink.Substring(0, documentWorkspaceLink.IndexOf("Shared Documents"));
                                  SPFieldUrlValue docWorkspaceURL = new SPFieldUrlValue(documentWorkspaceLink);
                                  SPWeb documentWorkspace = null;

                                  foreach (SPWeb workspace in properties.Web.Webs)
                                  {
                                      if (docWorkspaceURL.Url.Contains(workspace.Url))
                                      {
                                          documentWorkspace = workspace;
                                          break;
                                      }
                                  }

                                  using (documentWorkspace)
                                  {
                                      //Now get the list holding the document set.
                                      SPList sharedDocuments = documentWorkspace.Lists[libraryNameInDocumentWorkspace];


                                      Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet sourceDocumentSet = Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.GetDocumentSet(sharedDocuments.Items[0].Folder);

                                      ContentIterator docSetIterator = new ContentIterator();
                                      docSetIterator.ProcessFilesInFolder(sourceDocumentSet.Folder,
                                          true,
                                          new ContentIterator.FileProcessor((SPFile file) =>
                                          {
                                              //Check if this is a Procurement Resolution
                                              if (file.Item.ContentType.Name == "Procurement Resolution")
                                              {
                                                  if (!string.IsNullOrEmpty(file.Properties["ContractBidDate"].ToString()))
                                                  {
                                                      DateTime contractBidDate = DateTime.Parse(file.Properties["ContractBidDate"].ToString());

                                                      DateTime meetingDate = DateTime.Parse(newMeetingDate);

                                                      if (meetingDate > contractBidDate)
                                                      {
                                                          properties.ErrorMessage = "Agenda cannot be moved to this meeting because the bid date specified for this Procurment Resolution is earlier than the new board meeting date";
                                                          properties.Status = SPEventReceiverStatus.CancelWithError;
                                                          properties.Cancel = true;
                                                      }
                                                  }
                                              }
                                          }),
                                          new ContentIterator.FileProcessorErrorCallout((SPFile file, Exception ex) =>
                                          {
                                              //TODO: Handle the error during iteration of files
                                              return false;
                                          })
                                              );

                                  }
                              }

                              if (properties.Cancel != true)
                              {
                                  SPListItem agendaItem = properties.ListItem;
                                  this.EventFiringEnabled = false;
                                  agendaItem["MeetingTitle"] = newMeetingTitle;
                                  agendaItem["MeetingDate"] = newMeetingDate;
                                  agendaItem.SystemUpdate(false);
                                  //agendaItem.Update();
                                  this.EventFiringEnabled = true;


                              }

                          }
                      }
                      //base.ItemUpdating(properties);
                  });
       }

       private Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet CreateDocumentSet(SPList list, string documentSetName)
       {
           SPContentType docsetCT = list.ContentTypes["Document Set"];
           Hashtable properties = new Hashtable();
           properties.Add("DocumentSetDescription", string.Format("Document Set for Agenda: {0}", documentSetName));
           string instanceID = "1";

           SPFolder parentFolder = list.RootFolder.SubFolders[instanceID];

           Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet docSet = Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.Create(parentFolder,
               documentSetName,
               list.ContentTypes.BestMatch(docsetCT.Id),
               properties,
               true);

           return docSet;

       }

       private void CopyFile(SPFile file, Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet docSet)
       {
           docSet.Folder.Files.Add(file.Name, file.OpenBinary(), true);
       }
    }
}
