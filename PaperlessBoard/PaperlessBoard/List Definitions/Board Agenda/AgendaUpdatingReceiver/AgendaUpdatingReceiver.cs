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
           string originalMeetingID = properties.ListItem["CommitteeMeeting"].ToString();
           if (properties.AfterProperties["CommitteeMeeting"] != null)
           {
               string newMeetingID = properties.AfterProperties["CommitteeMeeting"].ToString();
               string originalTitle = properties.ListItem["Title"].ToString();
               string newTitle = properties.AfterProperties["Title"].ToString();

               if (originalTitle != newTitle)
               {
                   //Update the Emis Look Ahead List
                   InitializeWebAppProperties(properties);

                   // Update Look Ahead list in Emis
                   using (PBEntitiesDataContext ctx = new PBEntitiesDataContext(emisSiteURL))
                   {
                       EntityList<FutureAgendaItemsLookAheadForEmis> agendas = ctx.GetList<FutureAgendaItemsLookAheadForEmis>("Future Agenda Items");
                       //TODO: FILTER this list based on agenda ID
                       var agendaInLookAheadEmis = agendas.Where(a => a.Id == properties.ListItemId).Single();

                       agendaInLookAheadEmis.BoardMeeting = newTitle;
                       ctx.SubmitChanges();
                   }


                   using (SPSite boardSite = new SPSite(boardSiteURL))
                   using (SPWeb boardWeb = boardSite.OpenWeb())
                   {
                       SPList meetingsList = boardWeb.Lists[boardMeetingListName];


                       //While we have the boardWeb object open, Update the look ahead list in Board

                       SPList lookAheadListInBoard = boardWeb.Lists[lookAheadListNameInBoard];
                       SPQuery queryForLookAheadList = new SPQuery()
                       {
                           Query = string.Format(@"<Where>
                                <Eq>
                                    <FieldRef Name='AgendaID'/>
                                    <Value Type='Text'>{0}</Value>
                                </Eq>
                            </Where>", properties.ListItemId)
                       };

                       foreach (SPListItem agendaInBoardLookAhead in lookAheadListInBoard.GetItems(queryForLookAheadList))
                       {
                           agendaInBoardLookAhead["Board Agenda"] = newTitle;
                           agendaInBoardLookAhead.Update();
                       }

                       //Get oldMeetingWorkspace first
                       string meetingURL = null;
                       SPQuery queryForMeeting = new SPQuery()
                       {
                           Query = string.Format(@"<Where>
                                        <Eq>
                                            <FieldRef Name='ID'/>
                                            <Value Type='Number'>{0}</Value>
                                        </Eq>
                                    </Where>", originalMeetingID)
                       };
                       foreach (SPListItem meeting in meetingsList.GetItems(queryForMeeting))
                       {
                           meetingURL = meeting["Workspace"].ToString();
                       }
                       SPFieldUrlValue meetingLink = new SPFieldUrlValue(meetingURL);
                       
                      
                       SPMeeting meetingSites = SPMeeting.GetMeetingInformation(boardWeb);
                       SPWebCollection meetingWorkspaces = meetingSites.GetWorkspacesToLinkTo(false);


                       foreach (SPWeb meetingWorkspace in meetingWorkspaces)
                       {
                           if ((meetingLink.Url.Contains(meetingWorkspace.Url)) )
                           {
                               
                               //Now loop through the Agenda Items
                               SPList sourceAgendaList = meetingWorkspace.Lists["Agenda"];
                               foreach (SPListItem agenda in sourceAgendaList.Items)
                               {
                                   if (agenda["AgendaID"].ToString() == properties.ListItemId.ToString())
                                   {
                                       agenda["Subject"] = newTitle;
                                       agenda.Update();
                                   }
                               }
                               break;
                           }
                       }
                   }
                   //Update the Board look ahead list

                   //Update the agenda item in the board meeting workspace

               }

               if (originalMeetingID != newMeetingID)
               {
                   InitializeWebAppProperties(properties);
                   // Get the meeting details (Meeting Title, Meeting Date)
                   string newMeetingTitle = null;
                   string newMeetingDate = null;
                   string newMeetingURL = null;

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
                           newMeetingURL = meeting["Workspace"].ToString();
                           newMeetingTitle = meeting["Title"].ToString();
                           newMeetingDate = meeting["EventDate"].ToString();
                       }
                   }

                   
                   //Before we move the meeting, ensure that this does not confict with the Bid Date if this is Procurement Resolution.
                   if (properties.ListItem["AgendaType"].ToString() == "Procurement Resolution")
                   {
                       //Get the document workspace of this Agenda
                       SPFieldUrlValue docWorkspaceURL = new SPFieldUrlValue(properties.ListItem["DocumentWorkspace"].ToString());
                       SPWeb documentWorkspace = null;

                        foreach (SPWeb workspace in properties.Web.Webs)
                        {
                            if (workspace.Url == docWorkspaceURL.Url)
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

                       using (SPSite boardSite = new SPSite(boardSiteURL))
                       using (SPWeb boardWeb = boardSite.OpenWeb())
                       {
                           SPList meetingsList = boardWeb.Lists[boardMeetingListName];
                     

                           //While we have the boardWeb object open, Update the look ahead list in Board

                           SPList lookAheadListInBoard = boardWeb.Lists[lookAheadListNameInBoard];
                           SPQuery queryForLookAheadList = new SPQuery()
                           {
                               Query = string.Format(@"<Where>
                                <Eq>
                                    <FieldRef Name='AgendaID'/>
                                    <Value Type='Text'>{0}</Value>
                                </Eq>
                            </Where>", properties.ListItemId)
                           };
                           foreach (SPListItem agendaInEmisLookAhead in lookAheadListInBoard.GetItems(queryForLookAheadList))
                           {
                               agendaInEmisLookAhead["Meeting Date"] = newMeetingDate;
                               agendaInEmisLookAhead["Meeting Workspace"] = newMeetingURL;

                               agendaInEmisLookAhead.Update();
                               //Also Check the Agenda Status. If 'Published To Board', then move document set to new Meeting Workspace
                               if (agendaInEmisLookAhead["Agenda Status"].ToString() == "Published to Board")
                               {
                                   //Get oldMeetingWorkspace first
                                   string oldMeetingURL = null;
                                   SPQuery queryForOldMeeting = new SPQuery()
                                   {
                                       Query = string.Format(@"<Where>
                                        <Eq>
                                            <FieldRef Name='ID'/>
                                            <Value Type='Number'>{0}</Value>
                                        </Eq>
                                    </Where>", originalMeetingID)
                                   };
                                   foreach (SPListItem meeting in meetingsList.GetItems(queryForOldMeeting))
                                   {
                                       oldMeetingURL = meeting["Workspace"].ToString();
                                   }
                                   SPFieldUrlValue oldMeetingLink = new SPFieldUrlValue(oldMeetingURL);
                                   SPFieldUrlValue newMeetingLink = new SPFieldUrlValue(newMeetingURL);
                                   SPWeb oldMeetingWorkspace = null;
                                   SPWeb newMeetingWorkspace = null;

                                   SPMeeting meetingSites = SPMeeting.GetMeetingInformation(boardWeb);
                                   SPWebCollection meetingWorkspaces = meetingSites.GetWorkspacesToLinkTo(false);

                                   bool oldMeetingWorkspaceFound = false;
                                   bool newMeetingWorkspaceFound = false;

                                   foreach (SPWeb meetingWorkspace in meetingWorkspaces)
                                   {
                                       if ((oldMeetingLink.Url.Contains(meetingWorkspace.Url)) && (!oldMeetingWorkspaceFound))
                                       {
                                           oldMeetingWorkspace = meetingWorkspace;
                                           oldMeetingWorkspaceFound = true;
                                           if ((oldMeetingWorkspaceFound) && (newMeetingWorkspaceFound))
                                               break;
                                       }

                                       if ((newMeetingLink.Url.Contains(meetingWorkspace.Url)) && (!newMeetingWorkspaceFound))
                                       {
                                           newMeetingWorkspace = meetingWorkspace;
                                           newMeetingWorkspaceFound = true;
                                           if ((oldMeetingWorkspaceFound) && (newMeetingWorkspaceFound))
                                               break;
                                       }
                                   }

                                   //Get the document Set
                                   Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet sourceDocumentSet;
                                   //= Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.GetDocumentSet(sharedDocuments.Items[0].Folder);
                                   SPList sourceDocumentLibrary = oldMeetingWorkspace.Lists["Document Library"];
                                   string destinationDocumentSetURL = null;
                                   foreach (SPListItem sourceDoc in sourceDocumentLibrary.Items)
                                   {
                                       
                                       //If the title of the item being moved matches the name of the Document Set, its our Document Set List Item.
                                       if (sourceDoc["Name"].ToString() == properties.ListItem.Title)
                                       {
                                           SPList destinationDocumentLibrary = newMeetingWorkspace.Lists["Document Library"];

                                           //Get the source Document Set.
                                           sourceDocumentSet = Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.GetDocumentSet(sourceDocumentLibrary.Items[sourceDoc.UniqueId].Folder);

                                           newMeetingWorkspace.AllowUnsafeUpdates = true;
                                           oldMeetingWorkspace.AllowUnsafeUpdates = true;
                                           //Create new Document Set in new meeting workspace
                                           Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet destinationDocumentSet = CreateDocumentSet(destinationDocumentLibrary, properties.ListItem.Title);

                                           ContentIterator docSetIterator = new ContentIterator();
                                           docSetIterator.ProcessFilesInFolder(sourceDocumentSet.Folder,
                                               true,
                                               new ContentIterator.FileProcessor((SPFile file) =>
                                               {
                                                   CopyFile(file, destinationDocumentSet);
                                                   newMeetingWorkspace.Update();
                                               }),
                                               new ContentIterator.FileProcessorErrorCallout((SPFile file, Exception ex) =>
                                               {
                                                   //TODO: Handle the error during iteration of files
                                                   return false;
                                               })
                                                   );

                                           destinationDocumentSetURL = destinationDocumentSet.ParentList.ParentWeb.Site.Url + destinationDocumentSet.ParentList.ParentWebUrl + "/" + destinationDocumentSet.Item.Url;
                                           //Delete the document set from the source document library.
                                           sourceDocumentLibrary.Items.DeleteItemById(sourceDoc.ID);
                                       }
                                   }

                                   //Now loop through the Agenda Items
                                   SPList sourceAgendaList = oldMeetingWorkspace.Lists["Agenda"];
                                   foreach (SPListItem agenda in sourceAgendaList.Items)
                                   {
                                       if (agenda["AgendaID"].ToString() == properties.ListItemId.ToString())
                                       {
                                           SPList destinationAgendaList = newMeetingWorkspace.Lists["Agenda"];
                                           SPListItem movedAgenda = destinationAgendaList.Items.Add();
                                           movedAgenda["Subject"] = agenda["Subject"].ToString();
                                           if (agenda["Owner"] != null)
                                           {
                                               movedAgenda["Owner"] = agenda["Owner"].ToString();
                                           }
                                           if (agenda["Time"] != null)
                                           {
                                               movedAgenda["Time"] = agenda["Time"].ToString();
                                           }

                                           string sponsorValue = agenda["Sponsor"].ToString();
                                           SPFieldUser userField = sourceAgendaList.Fields.GetFieldByInternalName("Sponsor") as SPFieldUser;
                                           SPFieldUserValue itemValue = (SPFieldUserValue)userField.GetFieldValue(sponsorValue);
                                           SPUser sponsor = itemValue.User;

                                           movedAgenda["Sponsor"] = sponsor;

                                           if (agenda["Office"] != null)
                                           {
                                               movedAgenda["Office"] = agenda["Office"].ToString();
                                           }
                                           if (agenda["Documents"] != null)
                                           {
                                               SPFieldUrlValue docsURLValue = new SPFieldUrlValue();
                                               destinationDocumentSetURL = destinationDocumentSetURL.Replace(" ", "%20");
                                               docsURLValue.Url = destinationDocumentSetURL;
                                               docsURLValue.Description = "Documents";
                                               movedAgenda["Documents"] = docsURLValue;
                                           }

                                           movedAgenda.Update();

                                           sourceAgendaList.Items.DeleteItemById(agenda.ID);
                                       }
                                   }

                                   newMeetingWorkspace.AllowUnsafeUpdates = false;
                                   oldMeetingWorkspace.AllowUnsafeUpdates = false;
                               }
                           }
                       }
                       // Update Look Ahead list in Emis
                       using (PBEntitiesDataContext ctx = new PBEntitiesDataContext(emisSiteURL))
                       {
                           EntityList<FutureAgendaItemsLookAheadForEmis> agendas = ctx.GetList<FutureAgendaItemsLookAheadForEmis>("Future Agenda Items");
                           //TODO: FILTER this list based on agenda ID
                           var agendaInLookAheadEmis = agendas.Where(a => a.Id == properties.ListItemId).Single();

                           agendaInLookAheadEmis.BoardMeeting = newMeetingTitle;
                           agendaInLookAheadEmis.CommitteeMeetingID = newMeetingID;
                           agendaInLookAheadEmis.MeetingDate = DateTime.Parse(newMeetingDate);

                           ctx.SubmitChanges();
                       }

                      
                   }
                   
               }
           }
           //base.ItemUpdating(properties);
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
