using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.Office.DocumentManagement.DocumentSets;
using System.IO;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Meetings;
using Microsoft.SharePoint.WebPartPages;

namespace MARTA.PaperlessBoard.List_Definitions.Board_Agenda.BoardAgendaReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BoardAgendaReceiver : SPItemEventReceiver
    {
        
       /// <summary>
       /// An item was added.
       /// </summary>
       public override void ItemAdded(SPItemEventProperties properties)
       {
           CreateDocumentWorkspace(properties);
           base.ItemAdded(properties);
       }

       private void CreateDocumentWorkspace(SPItemEventProperties properties)
       {
           using (SPWeb web = properties.OpenWeb())
           using (SPSite site = web.Site)
           {
               const Int32 LOCALE_ID_ENGLISH = 1033;
               SPWebTemplateCollection templates = site.GetWebTemplates(Convert.ToUInt32(LOCALE_ID_ENGLISH));

               try
               {
                   SPWebTemplate template = templates["STS#2"];
                   SPSecurity.RunWithElevatedPrivileges(delegate()
                   {
                       using (SPSite elevatedSite = new SPSite(site.ID))
                       using (SPWeb elevatedWeb = elevatedSite.OpenWeb())
                       {
                           SPWeb documentWorkspace = elevatedWeb.Webs.Add(
                               string.Format("{0}-{1}", properties.List.Title, Guid.NewGuid().ToString()),
                               properties.ListItem["Title"].ToString(),
                               string.Format("Document Workspace for {0}", properties.ListItem["Title"].ToString()),
                               Convert.ToUInt32(LOCALE_ID_ENGLISH),
                               template,
                               false, //TODO: This will change to true. We will need custom permissions for each meeting workspace.
                               false);

                           properties.ListItem["DocumentWorkspace"] = string.Format("{0}, {1}", documentWorkspace.Url, "Document Workspace");
                           
                           properties.ListItem.Update();

                           SetUpDocumentWorkspace(properties, elevatedSite, documentWorkspace);
                       }
                       
                   });
                   
               }
               catch (Exception ex)
               {
                   Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception – {0} – {1} – {2}", "Error in Agenda Reciever", ex.Message, ex.StackTrace);
                   properties.Cancel = true;
                   properties.ErrorMessage = ex.Message;
               }
           }
       }

       private void SetUpDocumentWorkspace(SPItemEventProperties eventProperties, SPSite rootWeb, SPWeb documentWorkspace)
       {
            //Make sure it inherits the theme from the rootWeb
            string currentTheme = rootWeb.RootWeb.Theme;
            documentWorkspace.ApplyTheme(currentTheme);

            string docSetName = "Agenda Workspace DS-6";
            string defaultDocumentsLibraryName = null;
            string libraryNameInDocumentWorkspace = null;
            string boardSiteURL = null;
            string boardMeetingListName = null;
            string lookAheadListName = null;
            string lookAheadListNameInEmis = null;
            SPContentType newDocumentSetContentType = null;

           //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
           SPWebApplication webApplication = eventProperties.Web.Site.WebApplication;
           if (webApplication.Properties != null && webApplication.Properties.Count > 0)
           {
               if (webApplication.Properties.ContainsKey("DefaultDocumentsLibrary"))
               {
                   defaultDocumentsLibraryName = webApplication.Properties["DefaultDocumentsLibrary"].ToString();
                   libraryNameInDocumentWorkspace = webApplication.Properties["LibraryNameInDocumentWorkspace"].ToString();
                   boardSiteURL = webApplication.Properties["BoardSiteURL"].ToString();
                   boardMeetingListName = webApplication.Properties["BoardMeetingListName"].ToString();
                   lookAheadListName = webApplication.Properties["LookAheadListName"].ToString();
                   lookAheadListNameInEmis = webApplication.Properties["LookAheadListNameInEmis"].ToString();
               }
           }

           DocumentSetTemplate newDocumentSetTemplate = null;
           SPField fld = rootWeb.RootWeb.Fields[new Guid()];
           

           if (eventProperties.ListItem["AgendaType"].ToString() == "Procurement Resolution")
           {
               docSetName = DocSetNames.ProcurementResolution;

               if (rootWeb.RootWeb.ContentTypes[docSetName] == null)
               {
                   // create the new document set content Type
                   newDocumentSetContentType = rootWeb.RootWeb.ContentTypes.Add(new SPContentType(rootWeb.RootWeb.ContentTypes["Document Set"], rootWeb.RootWeb.ContentTypes, docSetName));

                   // get a document set template for the new document set
                   newDocumentSetTemplate = DocumentSetTemplate.GetDocumentSetTemplate(newDocumentSetContentType);
                   
                   //add allowable content types
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["AgendaDocument"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["Procurement Resolution"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Remove(rootWeb.RootWeb.ContentTypes["Document"].Id);
                   newDocumentSetTemplate.Update(true);

//                   SPQuery queryForDefaultDocs = new SPQuery()
//                   {
//                       Query = string.Format(@"<Where>
//                                    <Eq>
//                                        <FieldRef Name='Agenda Type'/>
//                                        <Value Type='Choice'>{0}</Value>
//                                    </Eq>
//                                </Where>", eventProperties.ListItem["AgendaType"].ToString())
//                   };

//                   SPDocumentLibrary defaultDocsLibrary = (SPDocumentLibrary)eventProperties.Web.Lists[defaultDocumentsLibraryName];
//                   //SPListItemCollection lic = defaultDocsLibrary.GetItems(queryForDefaultDocs);
//                   SPListItemCollection lic = defaultDocsLibrary.Items;
//                   foreach (SPListItem defaultDocItem in lic)
//                   {
//                       if (defaultDocItem["Agenda Type"].ToString() == eventProperties.ListItem["AgendaType"].ToString())
//                       {
//                           SPFile file = defaultDocItem.File;
//                           byte[] defaultDocumentBytes = file.OpenBinary();
//                           //Add the default document
//                           SPListItem itemForFile = file.Item;
//                           DefaultDocument defaultDocument = newDocumentSetTemplate.DefaultDocuments.Add(file.Name, 
//                               rootWeb.RootWeb.ContentTypes[itemForFile.ContentType.Name].Id,
//                               defaultDocumentBytes);
                           
//                       }
//                   }

                   //add a shareable property
                   //TODO: Worry about Shareable fields later on.
                   //newDocumentSetTemplate.SharedFields.Add(rootWeb.RootWeb.Fields["AgendaID"]);//The agenda of the board
                   //newDocumentSetTemplate.SharedFields.Add(rootWeb.RootWeb.Fields["Sponsor"]);
                   //newDocumentSetTemplate.SharedFields.Add(rootWeb.RootWeb.Fields[new Guid("20CD7D82-64D8-4D37-A977-BF81894A1BFF")]); //Voting Requirements.
                   //newDocumentSetTemplate.SharedFields.Add(rootWeb.RootWeb.Fields[new Guid("5C3D49E7-CDF4-4745-AD29-DDC99D6508D4")]); //Contract Bid Date.
                   
                   //make sure to add the document set name to the default documents.
                   newDocumentSetTemplate.DefaultDocuments.AddSetName = false;

                   newDocumentSetTemplate.Update(true);
                   newDocumentSetContentType.Update();

                   rootWeb.RootWeb.Update();
               }

           }
           else if (eventProperties.ListItem["AgendaType"].ToString() == "Non-Procurement Resolution")
           {
               docSetName = DocSetNames.NonProcurementResolution;

               if (rootWeb.RootWeb.ContentTypes[docSetName] == null)
               {
                   // create the new document set content Type
                   newDocumentSetContentType = rootWeb.RootWeb.ContentTypes.Add(new SPContentType(rootWeb.RootWeb.ContentTypes["Document Set"], rootWeb.RootWeb.ContentTypes, docSetName));

                   // get a document set template for the new document set
                   newDocumentSetTemplate = DocumentSetTemplate.GetDocumentSetTemplate(newDocumentSetContentType);

                   //add allowable content types
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["AgendaDocument"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Remove(rootWeb.RootWeb.ContentTypes["Document"].Id);


                   newDocumentSetTemplate.DefaultDocuments.AddSetName = false;

                   newDocumentSetTemplate.Update(true);
                   newDocumentSetContentType.Update();

                   rootWeb.RootWeb.Update();


               }
           }
           else if (eventProperties.ListItem["AgendaType"].ToString() == "Other Matters")
           {
               docSetName = DocSetNames.OtherMatters;

               if (rootWeb.RootWeb.ContentTypes[docSetName] == null)
               {
                   // create the new document set content Type
                   newDocumentSetContentType = rootWeb.RootWeb.ContentTypes.Add(new SPContentType(rootWeb.RootWeb.ContentTypes["Document Set"], rootWeb.RootWeb.ContentTypes, docSetName));

                   // get a document set template for the new document set
                   newDocumentSetTemplate = DocumentSetTemplate.GetDocumentSetTemplate(newDocumentSetContentType);

                   //add allowable content types
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["AgendaDocument"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Remove(rootWeb.RootWeb.ContentTypes["Document"].Id);


                   newDocumentSetTemplate.DefaultDocuments.AddSetName = false;

                   newDocumentSetTemplate.Update(true);
                   newDocumentSetContentType.Update();

                   rootWeb.RootWeb.Update();


               }
           }
           else if (eventProperties.ListItem["AgendaType"].ToString() == "Briefing")
           {
               docSetName = DocSetNames.Briefing;

               if (rootWeb.RootWeb.ContentTypes[docSetName] == null)
               {
                   // create the new document set content Type
                   newDocumentSetContentType = rootWeb.RootWeb.ContentTypes.Add(new SPContentType(rootWeb.RootWeb.ContentTypes["Document Set"], rootWeb.RootWeb.ContentTypes, docSetName));

                   // get a document set template for the new document set
                   newDocumentSetTemplate = DocumentSetTemplate.GetDocumentSetTemplate(newDocumentSetContentType);

                   //add allowable content types
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["AgendaDocument"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Remove(rootWeb.RootWeb.ContentTypes["Document"].Id);


                   newDocumentSetTemplate.DefaultDocuments.AddSetName = false;

                   newDocumentSetTemplate.Update(true);
                   newDocumentSetContentType.Update();

                   rootWeb.RootWeb.Update();


               }
           }

           else if (eventProperties.ListItem["AgendaType"].ToString() == "Meeting Minutes")
           {
               docSetName = DocSetNames.MeetingMinutes;

               if (rootWeb.RootWeb.ContentTypes[docSetName] == null)
               {
                   // create the new document set content Type
                   newDocumentSetContentType = rootWeb.RootWeb.ContentTypes.Add(new SPContentType(rootWeb.RootWeb.ContentTypes["Document Set"], rootWeb.RootWeb.ContentTypes, docSetName));

                   // get a document set template for the new document set
                   newDocumentSetTemplate = DocumentSetTemplate.GetDocumentSetTemplate(newDocumentSetContentType);

                   //add allowable content types
                   newDocumentSetTemplate.AllowedContentTypes.Add(rootWeb.RootWeb.ContentTypes["AgendaDocument"].Id);
                   newDocumentSetTemplate.AllowedContentTypes.Remove(rootWeb.RootWeb.ContentTypes["Document"].Id);


                   newDocumentSetTemplate.DefaultDocuments.AddSetName = false;

                   newDocumentSetTemplate.Update(true);
                   newDocumentSetContentType.Update();

                   rootWeb.RootWeb.Update();
               }
           }
           
           newDocumentSetContentType = newDocumentSetContentType ?? rootWeb.RootWeb.ContentTypes[docSetName];

           documentWorkspace.AllowUnsafeUpdates = true;

           SPDocumentLibrary list = (SPDocumentLibrary)documentWorkspace.Lists[libraryNameInDocumentWorkspace];
           list.ContentTypes.Delete(list.ContentTypes["Document"].Id);
           list.ContentTypes.Add(newDocumentSetContentType);
           
           list.EnableVersioning = true;
           //list.EnableMinorVersions = true;
           list.MajorVersionLimit = 40;
           //list.MajorWithMinorVersionsLimit = 12;
           list.Update();
           
           
           SPField fldAgendaID = list.Fields.CreateNewField(SPFieldType.Text.ToString(), "AgendaID");
           SPField fldPublishToBoard = list.Fields.CreateNewField(SPFieldType.Boolean.ToString(), "PublishToBoard");
           SPField fldSponsor = list.Fields.CreateNewField(SPFieldType.User.ToString(), "Sponsor");
           list.Fields.Add(fldAgendaID);
           list.Fields.Add(fldPublishToBoard);
           list.Fields.Add(fldSponsor);
           list.Update();

           
           System.Collections.Hashtable properties = new System.Collections.Hashtable();
           properties.Add("DocumentSetDescription", string.Format("Document Set for {0}", eventProperties.ListItem["Title"].ToString()) ); //Internal Name
           properties.Add("_Title", "Board Agenda"); //Internal Name
           properties.Add("PublishToBoard", false); //Default Value is false
           properties.Add("AgendaID", eventProperties.ListItemId);
           properties.Add("Sponsor", eventProperties.Web.CurrentUser);

           //Creating the document set  
           Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet documentSet = Microsoft.Office.DocumentManagement.DocumentSets.DocumentSet.Create(list.RootFolder, 
               "Board Agenda Document Set",
               //string.Format("{0}", eventProperties.ListItem["Title"].ToString()), 
               list.ContentTypes.BestMatch(newDocumentSetContentType.Id), 
               properties,
               true);
           
           //Now add the default documents to the library
           SPQuery queryForDefaultDocs = new SPQuery()
           {
               Query = string.Format(@"<Where>
                                    <Eq>
                                        <FieldRef Name='Agenda Type'/>
                                        <Value Type='Choice'>{0}</Value>
                                    </Eq>
                                </Where>", eventProperties.ListItem["AgendaType"].ToString())
           };

           SPDocumentLibrary defaultDocsLibrary = (SPDocumentLibrary)eventProperties.Web.Lists[defaultDocumentsLibraryName];
           //SPListItemCollection lic = defaultDocsLibrary.GetItems(queryForDefaultDocs);
           SPListItemCollection lic = defaultDocsLibrary.Items;
           foreach (SPListItem defaultDocItem in lic)
           {
               if (defaultDocItem["Agenda Type"].ToString() == eventProperties.ListItem["AgendaType"].ToString())
               {
                   SPFile file = defaultDocItem.File;
                   byte[] defaultDocumentBytes = file.OpenBinary();
                   //Add the default document
                   SPListItem itemForFile = file.Item;
                   SPFile addedFile = documentSet.Folder.Files.Add(file.Name,
                       defaultDocumentBytes,
                       true);

                  
                   //DefaultDocument defaultDocument = newDocumentSetTemplate.DefaultDocuments.Add(file.Name,
                   //    rootWeb.RootWeb.ContentTypes[itemForFile.ContentType.Name].Id,
                   //    defaultDocumentBytes);

               }
           }


           //Get the Meeting Workspace Link
           string meetingWorkspaceURL = null;
           string meetingTitle = null;
           string meetingDate = null;
           SPUser spUser = GetSPUser(eventProperties.ListItem, "Created By");

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
                    </Where>", eventProperties.ListItem["CommitteeMeeting"].ToString())
               };
               foreach (SPListItem meeting in meetingsList.GetItems(query))
               {
                   meetingWorkspaceURL = meeting["Workspace"].ToString();
                   meetingTitle = meeting["Title"].ToString();
                   meetingDate = meeting["EventDate"].ToString();
               }

               eventProperties.ListItem["MeetingTitle"] = meetingTitle;
               eventProperties.ListItem["MeetingDate"] = meetingDate;

               eventProperties.ListItem.Update();
               //Also while you have the site already opened, add an item for the AgendaSummary list
               SPList agendaSummaryList = boardWeb.Lists[lookAheadListName];

               SPListItem agendaSummaryItem = agendaSummaryList.Items.Add();
               agendaSummaryItem["Board Agenda"] = eventProperties.ListItem.Title;
               agendaSummaryItem["Board Meeting"] = meetingTitle;
               agendaSummaryItem["Meeting Date"] = meetingDate;
               agendaSummaryItem["Agenda Status"] = "Agenda Created"; //TODO: Remove hardcoding for this and make it configurable.
               agendaSummaryItem["AgendaID"] = eventProperties.ListItemId;
               agendaSummaryItem["ResponsiblePerson"] = spUser.Name;
               agendaSummaryItem["Office"] = eventProperties.ListItem["AGM Office"].ToString();
               agendaSummaryItem["MeetingWorkspace"] = meetingWorkspaceURL;
               agendaSummaryItem.Update();

               //Also add the same agenda into the Meeting Workspace's Agenda list
               int agendaOrder = 0;
               if (eventProperties.ListItem["AgendaOrder"] != null)
                   agendaOrder = int.Parse(eventProperties.ListItem["AgendaOrder"].ToString());

               string presenter = string.Empty;
               if (eventProperties.ListItem["Presenter"] != null)
                   presenter = eventProperties.ListItem["Presenter"].ToString();

               AddAgendaToMeetingWorkspace(boardWeb, meetingWorkspaceURL, eventProperties.ListItem.Title, spUser, eventProperties.ListItemId, presenter, agendaOrder);
           }
           //Add the item to the Future Agenda List (Look Ahead list in EMIS)
           SPList lookAheadListInEMIS = eventProperties.Web.Lists[lookAheadListNameInEmis];
           SPListItem futureAgendaItem = lookAheadListInEMIS.AddItem();
           futureAgendaItem["Board Agenda"] = eventProperties.ListItem.Title;
           futureAgendaItem["Board Meeting"] = meetingTitle;
           futureAgendaItem["Meeting Date"] = meetingDate;
           futureAgendaItem["AgendaID"] = eventProperties.ListItemId;
           futureAgendaItem["ResponsiblePerson"] = spUser.Name;
           futureAgendaItem["Office"] = eventProperties.ListItem["AGM Office"].ToString();
           futureAgendaItem["Committee Meeting ID"] = eventProperties.ListItem["CommitteeMeeting"].ToString();
           futureAgendaItem["Agenda Status"] = "Agenda Created";
           futureAgendaItem["DocumentWorkspace"] = eventProperties.ListItem["DocumentWorkspace"].ToString();
           futureAgendaItem.Update();

           //Add the Link Item
           SPListItem newMeetingLink = documentWorkspace.Lists["Links"].Items.Add();

           newMeetingLink["URL"] = meetingWorkspaceURL;
           newMeetingLink.Update();


           SPWorkflowTemplate template = null;
           //Now associate the workflow
           //Activate all the necessary features on the site
           documentWorkspace.Features.Add(new Guid("24512e0e-7b03-466e-9209-38b39a51c581")); // Board Agenda Workflow

           foreach (SPWorkflowTemplate localwfTemplate in documentWorkspace.WorkflowTemplates)
           {
               if (localwfTemplate.Name == "BoardAgendaWorkflow") //TODO: This should come from configuration.
               {
                   template = localwfTemplate;
               }
           }
           if (template == null) // If the template was not in the document workspace, then check root web for it.
           {
               foreach (SPWorkflowTemplate wfTemplate in rootWeb.RootWeb.WorkflowTemplates)
               {
                   if (wfTemplate.Name == "BoardAgendaWorkflow") //TODO: This should come from configuration.
                   {
                       template = wfTemplate;
                   }
               }
           }
           //Delete the default task list that is created
           SPList defaultTaskList = documentWorkspace.Lists["Tasks"];
           documentWorkspace.Lists.Delete(defaultTaskList.ID);

           //After a Document Set is created, Create two lists in this Document Set
           //1. Workflow History
           //2. Agenda WF Tasks
           
           Guid taskListID = documentWorkspace.Lists.Add("Agenda Tasks", "This task list holds all the tasks associated with the Agenda Workflow", rootWeb.RootWeb.ListTemplates["Agenda Tasks"]); //TODO: Get this from configuration.
           //Guid taskListID = documentWorkspace.Lists.Add("Tasks", "", SPListTemplateType.Tasks);
           Guid historyListID = documentWorkspace.Lists.Add("Workflow History", "History list used by the Agenda Workflow", SPListTemplateType.WorkflowHistory); 

           SPWorkflowAssociation workflowAssociation = SPWorkflowAssociation.CreateListAssociation(template, "Board Agenda Workflow", documentWorkspace.Lists[taskListID], documentWorkspace.Lists[historyListID]);
           workflowAssociation.AllowManual = true;
           workflowAssociation.AutoStartCreate = false;
           workflowAssociation.AutoStartChange = false;

           documentSet.ParentList.WorkflowAssociations.Add(workflowAssociation);

           SPList AgendaList = documentWorkspace.Lists[taskListID];
           AgendaList.EnableAssignToEmail = true;
           AgendaList.Update();

           SPList taskList = documentWorkspace.Lists[taskListID];
           taskList.OnQuickLaunch = true;
           taskList.Update();

           SPList historyList = documentWorkspace.Lists[historyListID];
           historyList.OnQuickLaunch = false;
           historyList.Update();

           //Remove the Announcements Webpart.
           SPLimitedWebPartManager webPartManager = documentWorkspace.GetLimitedWebPartManager("Default.aspx", System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);

           for (int k = 0; k < webPartManager.WebParts.Count; k++)
           {
               //get reference to webpart
               WebPart wp = webPartManager.WebParts[k] as WebPart;

               //check webpart Title to find webpart which is to be removed
               if ((wp.Title == "Announcements") || (wp.Title == "Members"))
               {
                   //delete webpart
                   webPartManager.DeleteWebPart(webPartManager.WebParts[k]);
                   
                   //update spWeb object
                   documentWorkspace.Update();
               }
           }

           documentWorkspace.AllowUnsafeUpdates = false;
           

       }

       private void AddAgendaToMeetingWorkspace(SPWeb boardWeb, string meetingWorkspaceURL, string agendaTitle, SPUser sponsor, int agendaID, string presenterName, int agendaOrder)
       {
           SPFieldUrlValue workspaceURL = new SPFieldUrlValue(meetingWorkspaceURL);

           SPMeeting meetingSites = SPMeeting.GetMeetingInformation(boardWeb);
           SPWebCollection meetingWorkspaces = meetingSites.GetWorkspacesToLinkTo(false);

           SPWeb meetingWeb = null;
           foreach (SPWeb meetingWorkspace in meetingWorkspaces)
           {
               if (workspaceURL.Url.Contains(meetingWorkspace.Url))
               {
                   meetingWeb = meetingWorkspace;
                   break;
               }
           }

           SPList agendaList = meetingWeb.Lists["Agenda"];
           SPListItem newAgenda = agendaList.AddItem();
           boardWeb.EnsureUser(sponsor.LoginName);
           SPUser user = boardWeb.AllUsers[sponsor.LoginName];
           newAgenda["Sponsor"] = user;
           newAgenda["Subject"] = agendaTitle;
           newAgenda["AgendaID"] = agendaID;
           newAgenda["Owner"] = presenterName;
           newAgenda["Item Number"] = agendaOrder;
           newAgenda.Update();
       }

       private SPUser GetSPUser(SPListItem item, string fieldName)
       {
           SPFieldUser field = item.Fields[fieldName] as SPFieldUser;
           if (field != null)
           {
               SPFieldUserValue fieldValue = field.GetFieldValue(item[fieldName].ToString()) as SPFieldUserValue;

               if (fieldValue != null)
                   return fieldValue.User;
           }
           return null;
       }
    }

    internal static class DocSetNames
    {
        
        public static string ProcurementResolution = "DocSet For ProcurementResolution V1.7";
        public static string NonProcurementResolution = "DocSet For NonProcurementResolution V1.3";
        public static string OtherMatters = "DocSet For OtherMatters V1.3";
        public static string Briefing = "DocSet For Briefing V1.3";
        public static string MeetingMinutes = "DocSet For Meeting Minutes V1.3";

    }
}
