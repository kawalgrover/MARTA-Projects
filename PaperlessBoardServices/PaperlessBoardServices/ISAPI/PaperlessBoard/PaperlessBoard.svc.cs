using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Client.Services;
using System.ServiceModel.Activation;
using Microsoft.SharePoint;
using System.Collections;
using Microsoft.SharePoint.Meetings;
using Microsoft.Office.Server.Utilities;
using Microsoft.SharePoint.Administration;
using System.ServiceModel;

namespace PaperlessBoardServices
{
    [ServiceBehavior]
    [BasicHttpBindingServiceMetadataExchangeEndpoint]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class PaperlessBoard : IPaperlessBoard
    {
        private string emisSiteURL = null;
        private string libraryNameInDocumentWorkspace = null;
        private string boardSiteURL = null;
        private string boardMeetingListName = null;
        private string emisSiteRelativeURl = null;

        public void PublishAgendaToBoard(int agendaID)
        {
            SPSecurity.RunWithElevatedPrivileges(delegate()
            {
                using (SPSite site = new SPSite(emisSiteURL))
                {
                    using (SPWeb emisWeb = site.OpenWeb(emisSiteRelativeURl))
                    {
                        SPList agendaList = emisWeb.Lists["Board Agenda"];
                        SPQuery query = new SPQuery()
                        {
                            Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='ID' />
                                                  <Value Type='Counter'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", agendaID.ToString())
                        };

                        foreach (SPListItem agenda in agendaList.GetItems(query))
                        {
                            if ((agenda["ID"].ToString() == agendaID.ToString()) && (agenda["Agenda Status"].ToString() == "Ready to Publish"))
                            {
                                int meetingID = int.Parse(agenda["CommitteeMeeting"].ToString());
                                string AgendaTitle = agenda["Title"].ToString();


                                SPFieldUrlValue docSetHomePage = new SPFieldUrlValue(agenda["DocumentWorkspace"].ToString());

                                string documentWorkspaceURL = docSetHomePage.Url.Substring(0, docSetHomePage.Url.IndexOf("Shared%20Documents"));

                                using (SPWeb documentWorkspace = site.OpenWeb(documentWorkspaceURL))
                                {
                                    //Now get the list holding the document set.
                                    SPList sharedDocuments = documentWorkspace.Lists[libraryNameInDocumentWorkspace];

                                    Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet sourceDocumentSet = Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.GetDocumentSet(sharedDocuments.Items[0].Folder);

                                    //Once you have your meetingID, find the meetingWorkspace
                                    using (SPSite boardSite = new SPSite(boardSiteURL))
                                    using (SPWeb boardWeb = boardSite.OpenWeb())
                                    {
                                        SPList meetingsList = boardWeb.Lists["Board Meeting"]; //TODO: Get from configuration

                                        SPListItem meeting = meetingsList.GetItemById(meetingID);

                                        //Now Get the Meeting Workspace
                                        SPFieldUrlValue meetingWorkspaceURL = new SPFieldUrlValue(meeting["Workspace"].ToString());
                                        using (SPWeb boardRootWeb = boardSite.OpenWeb())
                                        {
                                            SPMeeting meetingSites = SPMeeting.GetMeetingInformation(boardWeb);
                                            SPWebCollection meetingWorkspaces = meetingSites.GetWorkspacesToLinkTo(false);

                                            SPWeb meetingWeb = null;
                                            foreach (SPWeb meetingWorkspace in meetingWorkspaces)
                                            {
                                                if (meetingWorkspaceURL.Url.Contains(meetingWorkspace.Url))
                                                {
                                                    meetingWeb = meetingWorkspace;
                                                    break;
                                                }
                                            }

                                            SPList documentLibrary = meetingWeb.Lists["Document Library"];

                                            meetingWeb.AllowUnsafeUpdates = true;
                                            string instanceID = "1";

                                            Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet AgendaDocSetInMeetingWorkspace = CreateDocumentSet(documentLibrary, AgendaTitle);

                                            //AgendaDocSetInMeetingWorkspace.Item.Update();
                                            documentLibrary.Update();
                                            //Iterate through the source Document Set and copy the files over.


                                            ContentIterator docSetIterator = new ContentIterator();
                                            docSetIterator.ProcessFilesInFolder(sourceDocumentSet.Folder,
                                                true,
                                                new ContentIterator.FileProcessor((SPFile file) =>
                                                {
                                                    //documentLibrary.RootFolder.SubFolders[instanceID].Files.Add(AgendaDocSetInMeetingWorkspace.Item.Folder.Url, file.OpenBinary(), true);
                                                    if (bool.Parse(file.Properties["PublishDocumentToBoard"].ToString()) == true)
                                                    {
                                                        CopyFile(file, AgendaDocSetInMeetingWorkspace, AgendaTitle);
                                                        meetingWeb.Update();
                                                    }
                                                }),
                                                new ContentIterator.FileProcessorErrorCallout((SPFile file, Exception ex) =>
                                                {
                                                    //TODO: Handle the error during iteration of files
                                                    return false;
                                                })
                                                    );

                                            //Also update that particular agenda with all the pertinetn information
                                            SPList agendaListInWorkspace = meetingWeb.Lists["Agenda"];

                                            SPQuery agendaQuery = new SPQuery()
                                            {
                                                Query = string.Format(@"<Where>
                                                                    <Eq>
                                                                        <FieldRef Name='AgendaID'/>
                                                                        <Value Type='Number'>{0}</Value>
                                                                    </Eq>
                                                                </Where>", agendaID)
                                            };
                                            foreach (SPListItem agendaInWorkspace in agendaListInWorkspace.GetItems(agendaQuery))
                                            {
                                                SPFieldUrlValue docsURLValue = new SPFieldUrlValue();
                                                string URLValue = AgendaDocSetInMeetingWorkspace.ParentList.ParentWeb.Site.Url + AgendaDocSetInMeetingWorkspace.ParentList.ParentWebUrl + "/" + AgendaDocSetInMeetingWorkspace.Item.Url;
                                                URLValue = URLValue.Replace(" ", "%20");
                                                docsURLValue.Url = URLValue;
                                                docsURLValue.Description = "Documents";
                                                agendaInWorkspace["Documents"] = docsURLValue;

                                                //agendaInWorkspace["Documents"] = string.Format("{0}, Documents", AgendaDocSetInMeetingWorkspace.WelcomePageUrl);
                                                agendaInWorkspace.Update();
                                            }

                                            agenda["Agenda Status"] = "Published to Board";
                                            agenda.Update();

                                            meetingWeb.AllowUnsafeUpdates = false;


                                        }
                                    }
                                }
                            }
                        }
                    }
                }

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

        private void CopyFile(SPFile file, Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet docSet, string agendaTitle)
        {
            docSet.Folder.Files.Add(file.Name, file.OpenBinary(), true);
        }

        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                libraryNameInDocumentWorkspace = webApplication.Properties["LibraryNameInDocumentWorkspace"].ToString();
                boardSiteURL = webApplication.Properties["BoardSiteURL"].ToString();
                boardMeetingListName = webApplication.Properties["BoardMeetingListName"].ToString();
                emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
                emisSiteRelativeURl = webApplication.Properties["EmisSiteRelativeURL"].ToString();
            }



        }

        public string HelloWorld()
        {
            throw new NotImplementedException();
        }
    }
}
