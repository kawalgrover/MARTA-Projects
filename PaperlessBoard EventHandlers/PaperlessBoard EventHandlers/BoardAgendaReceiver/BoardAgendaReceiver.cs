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

using PaperlessBoard;
using System.Web.UI.WebControls;
using Microsoft.SharePoint.Navigation;

namespace MARTA.PaperlessBoard.List_Definitions.Board_Agenda.BoardAgendaReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BoardAgendaReceiver : SPItemEventReceiver
    {
        
       /// <summary>
       /// An agenda item is about to be added.
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
                               string.Format("{0}-{1}", "Agenda", Guid.NewGuid().ToString()),
                               properties.ListItem.Title,
                               string.Format("Document Workspace for {0}", properties.ListItem["Title"].ToString()),
                               Convert.ToUInt32(LOCALE_ID_ENGLISH),
                               template,
                               false, //TODO: This will change to true. We will need custom permissions for each meeting workspace.
                               false);

                           properties.ListItem["Agenda Status"] = AgendaStatus.AgendaCreated;

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
           //First change the permissions for the documentWorkspace
           documentWorkspace.AllowUnsafeUpdates = true;
           documentWorkspace.BreakRoleInheritance(false);

           string agendaType = eventProperties.ListItem["AgendaType"].ToString();
           string agmOffice = eventProperties.ListItem["AGM Office"].ToString();

           try
           {
               SPFieldUserValueCollection authUsers = PaperLessBoardHelper.GetKeyPeopleForAgenda(agendaType, agmOffice, eventProperties);
               foreach (SPFieldUserValue userValue in authUsers)
               {
                   SPRoleAssignment role;

                   role = new SPRoleAssignment(eventProperties.Web.EnsureUser(userValue.LookupValue));


                   role.RoleDefinitionBindings.Add(documentWorkspace.RoleDefinitions.GetByType(SPRoleType.Contributor));

                   documentWorkspace.RoleAssignments.Add(role);
                   documentWorkspace.Update();
               }
               //In addition the following groups get certain permissions
               //TODO: These permissions should ideally come from configuration

               SPGroup agendaCoordinators = eventProperties.Web.Groups["Agenda Coordinators"];
               SPRoleDefinition roleDefForAgendaCoordinators = eventProperties.Web.RoleDefinitions["Read"];

               SPRoleAssignment roleForAgendaCoordinators = new SPRoleAssignment(agendaCoordinators);
               roleForAgendaCoordinators.RoleDefinitionBindings.Add(roleDefForAgendaCoordinators);
               documentWorkspace.RoleAssignments.Add(roleForAgendaCoordinators);
               documentWorkspace.Update();

               SPGroup emisPortalMembers = eventProperties.Web.Groups["EMIS Portal Members"];
               SPRoleDefinition roleDefForEmisPortalMembers = eventProperties.Web.RoleDefinitions["Restricted Contribute"];
               SPRoleAssignment roleForEmisPortalMembers = new SPRoleAssignment(emisPortalMembers);
               roleForEmisPortalMembers.RoleDefinitionBindings.Add(roleDefForEmisPortalMembers);
               documentWorkspace.RoleAssignments.Add(roleForEmisPortalMembers);
               documentWorkspace.Update();

               SPGroup boardOfficeMembers = eventProperties.Web.Groups["Board Office Members"];
               SPRoleDefinition roleDefForBoardOfficeMemebers = eventProperties.Web.RoleDefinitions["Full Control"];
               SPRoleAssignment roleForBoardOfficeMembers = new SPRoleAssignment(boardOfficeMembers);
               roleForBoardOfficeMembers.RoleDefinitionBindings.Add(roleDefForBoardOfficeMemebers);
               documentWorkspace.RoleAssignments.Add(roleForBoardOfficeMembers);
               documentWorkspace.Update();

               SPGroup cpmManagers = eventProperties.Web.Groups["CPM Managers"];
               SPRoleDefinition roleDefForCPMManagers = eventProperties.Web.RoleDefinitions["Restricted Contribute"];
               SPRoleAssignment roleForCPMManagers = new SPRoleAssignment(cpmManagers);
               roleForCPMManagers.RoleDefinitionBindings.Add(roleDefForCPMManagers);
               documentWorkspace.RoleAssignments.Add(roleForCPMManagers);
               documentWorkspace.Update();

           }
           catch (Exception exc)
           {
               Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception – {0} – {1} – {2}", "Board Agenda Receiver Error while adding Key People and setting Permissions in workspace", exc.Message, exc.StackTrace);
           }
            //Make sure it inherits the theme from the rootWeb
            string currentTheme = rootWeb.RootWeb.Theme;
            documentWorkspace.ApplyTheme(currentTheme);

            string docSetName = "Agenda Workspace DS-6";
            string defaultDocumentsLibraryName = null;
            string libraryNameInDocumentWorkspace = null;
            string boardSiteURL = null;
            string boardMeetingListName = null;
            string lookAheadListName = null;
            string masterKeyPeopleListName = null;
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
                   lookAheadListName = webApplication.Properties["LookAheadListName"].ToString();
                   masterKeyPeopleListName = webApplication.Properties["MasterKeyPeopleListName"].ToString();
               }
           }

           DocumentSetTemplate newDocumentSetTemplate = null;
           

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

           list.ContentTypes.Add(newDocumentSetContentType);

           foreach (SPContentType defaultContentType in list.ContentTypes)
           {
               if (defaultContentType.Name != newDocumentSetContentType.Name)
                    list.ContentTypes.Delete(list.ContentTypes[defaultContentType.Name].Id);
           }
           
           
           
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

           //SPView defaultView = list.Views["All Documents"];
           //SPViewFieldCollection viewFields = defaultView.ViewFields;
           //viewFields.Add(list.Fields["PublishDocumentToBoard"]);

           //defaultView.Update();


           System.Collections.Hashtable properties = new System.Collections.Hashtable();
           properties.Add("DocumentSetDescription", string.Format("Document Set for {0}", eventProperties.ListItem["Title"].ToString()) ); //Internal Name
           properties.Add("_Title", eventProperties.ListItem["Title"].ToString()); //Internal Name
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

           string docSetHomePageURL = documentSet.WelcomePageUrl.Substring(0, documentSet.WelcomePageUrl.IndexOf("&RootFolder"));
           eventProperties.ListItem["DocumentWorkspace"] = string.Format("{0}, {1}", docSetHomePageURL, "Document Workspace");
           //Now add the default documents to the library

           eventProperties.ListItem.Update();

           
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

               }
           }


           //Get the Meeting Workspace Link
           string meetingWorkspaceURL = null;
           string meetingTitle = null;
           string meetingDate = null;
           SPUser spUser = eventProperties.Web.CurrentUser; // GetSPUser(eventProperties.ListItem, "Created By");

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

               /*
               //Also while you have the site already opened, add an item for the AgendaSummary list
               SPList agendaSummaryList = boardWeb.Lists[lookAheadListName];

               SPListItem agendaSummaryItem = agendaSummaryList.Items.Add();
               agendaSummaryItem["Board Agenda"] = eventProperties.ListItem["Title"].ToString();
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

               AddAgendaToMeetingWorkspace(boardWeb, meetingWorkspaceURL, eventProperties.ListItem["Title"].ToString(), spUser, eventProperties.ListItemId, presenter, agendaOrder);
                * 
                * */
           }

          

           SPWorkflowTemplate template = null;
           SPWorkflowTemplate notifyCoordinatorsWFTemplate = null;
           SPWorkflowTemplate reviewContentWFTemplate = null;
           SPWorkflowTemplate digitalSignaturesWFTemplate = null;

           //Now associate the workflow
           //Activate all the necessary features on the site
           documentWorkspace.Features.Add(new Guid("24512e0e-7b03-466e-9209-38b39a51c581")); // Board Agenda Workflows

           foreach (SPWorkflowTemplate localwfTemplate in documentWorkspace.WorkflowTemplates)
           {
               if (localwfTemplate.Name == "BoardAgendaWorkflow") //TODO: This should come from configuration.
               {
                   template = localwfTemplate;
                   break;
               }
           }

           foreach (SPWorkflowTemplate localwfTemplate in documentWorkspace.WorkflowTemplates)
           {
               if (localwfTemplate.Name == "NotifyCoordinatorsWorkflow") //TODO: This should come from configuration.
               {
                   notifyCoordinatorsWFTemplate = localwfTemplate;
                   break;
               }
           }

           foreach (SPWorkflowTemplate localwfTemplate in documentWorkspace.WorkflowTemplates)
           {
               if (localwfTemplate.Name == "Review Agenda Workflow") //TODO: This should come from configuration.
               {
                   reviewContentWFTemplate = localwfTemplate;
                   break;
               }
           }

           foreach (SPWorkflowTemplate localwfTemplate in documentWorkspace.WorkflowTemplates)
           {
               if (localwfTemplate.Name == "Digital Signatures") //TODO: This should come from configuration.
               {
                   digitalSignaturesWFTemplate = localwfTemplate;
                   break;
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

           if (notifyCoordinatorsWFTemplate == null)
           {
               foreach (SPWorkflowTemplate wfTemplate in rootWeb.RootWeb.WorkflowTemplates)
               {
                   if (wfTemplate.Name == "NotifyCoordinatorsWorkflow") //TODO: This should come from configuration.
                   {
                       notifyCoordinatorsWFTemplate = wfTemplate;
                   }
               }
           }

           if (reviewContentWFTemplate == null)
           {
               foreach (SPWorkflowTemplate wfTemplate in rootWeb.RootWeb.WorkflowTemplates)
               {
                   if (wfTemplate.Name == "Review Agenda Workflow") //TODO: This should come from configuration.
                   {
                       reviewContentWFTemplate = wfTemplate;
                   }
               }
           }

           if (digitalSignaturesWFTemplate == null)
           {
               foreach (SPWorkflowTemplate wfTemplate in rootWeb.RootWeb.WorkflowTemplates)
               {
                   if (wfTemplate.Name == "Digital Signatures") //TODO: This should come from configuration.
                   {
                       digitalSignaturesWFTemplate = wfTemplate;
                   }
               }
           }

           //Delete the default task list that is created
           SPList defaultTaskList = documentWorkspace.Lists["Tasks"];
           documentWorkspace.Lists.Delete(defaultTaskList.ID);

           //After a Document Set is created, Create three lists in this Document Workspace
           //1. Workflow History
           //2. Agenda WF Tasks
           //3. KeyPeople
           
           Guid taskListID = documentWorkspace.Lists.Add("Agenda Tasks", "This task list holds all the tasks associated with the Agenda Workflow", rootWeb.RootWeb.ListTemplates["Agenda Tasks"]); //TODO: Get this from configuration.
           //Guid taskListID = documentWorkspace.Lists.Add("Tasks", "", SPListTemplateType.Tasks);
           Guid historyListID = documentWorkspace.Lists.Add("Workflow History", "History list used by the Agenda Workflow", SPListTemplateType.WorkflowHistory);

           Guid keyPeopleListID = documentWorkspace.Lists.Add("Key People", "List of key people associated with this Agenda", rootWeb.RootWeb.ListTemplates["KeyPeopleDefinition"]);

           SPWorkflowAssociation workflowAssociation = SPWorkflowAssociation.CreateListAssociation(template, "Board Agenda Workflow", documentWorkspace.Lists[taskListID], documentWorkspace.Lists[historyListID]);
           workflowAssociation.AllowManual = true;
           workflowAssociation.AutoStartCreate = false;
           workflowAssociation.AutoStartChange = false;

           documentSet.ParentList.WorkflowAssociations.Add(workflowAssociation);

           SPWorkflowAssociation wfAssociationForNotifyCoordinators = SPWorkflowAssociation.CreateListAssociation(notifyCoordinatorsWFTemplate, "Notify Coordinators Workflow", documentWorkspace.Lists[taskListID], documentWorkspace.Lists[historyListID]);
           wfAssociationForNotifyCoordinators.AllowManual = true;
           wfAssociationForNotifyCoordinators.AutoStartCreate = false;
           wfAssociationForNotifyCoordinators.AutoStartChange = false;

           documentSet.ParentList.WorkflowAssociations.Add(wfAssociationForNotifyCoordinators);

           SPWorkflowAssociation wfAssociationForReviewContent = SPWorkflowAssociation.CreateListAssociation(reviewContentWFTemplate, "Review Content Workflow", documentWorkspace.Lists[taskListID], documentWorkspace.Lists[historyListID]);
           wfAssociationForReviewContent.AllowManual = true;
           wfAssociationForReviewContent.AutoStartCreate = false;
           wfAssociationForReviewContent.AutoStartChange = false;

           documentSet.ParentList.WorkflowAssociations.Add(wfAssociationForReviewContent);

           SPWorkflowAssociation wfAssociationForDigitalSignatures = SPWorkflowAssociation.CreateListAssociation(digitalSignaturesWFTemplate, "Digital Signatures", documentWorkspace.Lists[taskListID], documentWorkspace.Lists[historyListID]);
           wfAssociationForDigitalSignatures.AllowManual = true;
           wfAssociationForDigitalSignatures.AutoStartCreate = false;
           wfAssociationForDigitalSignatures.AutoStartChange = false;

           documentSet.ParentList.WorkflowAssociations.Add(wfAssociationForDigitalSignatures);


           SPList AgendaList = documentWorkspace.Lists[taskListID];
           AgendaList.EnableAssignToEmail = true;
           AgendaList.Update();

           SPList taskList = documentWorkspace.Lists[taskListID];
           taskList.OnQuickLaunch = true;
           taskList.Update();

           SPView defaultView = taskList.Views["All Tasks"];
           SPViewFieldCollection viewFields = defaultView.ViewFields;
           viewFields.Add(taskList.Fields["Comments"]);
           viewFields.Delete(taskList.Fields["Predecessors"]);
           viewFields.Delete(taskList.Fields["Description"]);
           
           defaultView.Update();


           SPList historyList = documentWorkspace.Lists[historyListID];
           historyList.OnQuickLaunch = false;
           historyList.Update();

           SPList keyPeopleList = documentWorkspace.Lists[keyPeopleListID];
           keyPeopleList.OnQuickLaunch = true;
           keyPeopleList.Update();

           SPList defaultCalendarList = documentWorkspace.Lists["Calendar"];
           defaultCalendarList.OnQuickLaunch = false;
           defaultCalendarList.Update();

           AddKeyPeopleToAgenda(rootWeb, documentWorkspace, keyPeopleListID, masterKeyPeopleListName, agendaType, eventProperties.ListItem["AGM Office"].ToString());

           string assemblyName = "PaperlessBoard EventHandlers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=072ce623fbaeb261";
           keyPeopleList.EventReceivers.Add(SPEventReceiverType.ItemAdded, assemblyName, "PaperlessBoard_EventHandlers.KeyPeopleAddedEventReceiver.KeyPeopleAddedEventReceiver");
           keyPeopleList.EventReceivers.Add(SPEventReceiverType.ItemDeleted, assemblyName, "PaperlessBoard_EventHandlers.KeyPeopleAddedEventReceiver.KeyPeopleAddedEventReceiver");
           keyPeopleList.EventReceivers.Add(SPEventReceiverType.ItemUpdated, assemblyName, "PaperlessBoard_EventHandlers.KeyPeopleAddedEventReceiver.KeyPeopleAddedEventReceiver");

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

           AddWebPartsToWelcomePage(documentWorkspace, documentSet.WelcomePageUrl);

           try
           {
               CleanUpQuickLaunch(documentWorkspace);
           }
           catch (Exception ex)
           {
               Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception – {0} – {1} – {2}", "Error in Agenda Reciever while cleaning up quick launch.", ex.Message, ex.StackTrace);
              
           }

           documentWorkspace.AllowUnsafeUpdates = false;
           

       }

       private void CleanUpQuickLaunch(SPWeb documentWorkspace)
       {
           SPNavigationNodeCollection quickLaunch = documentWorkspace.Navigation.QuickLaunch;
           RecurseNodes(quickLaunch);
       }

       private void RecurseNodes(SPNavigationNodeCollection nodes)
       {
           for(int i = 0; i < nodes.Count; i++)
           {
               if ((nodes[i].Title == "Agenda Tasks") || (nodes[i].Title == "Key People"))
               {
                   //Keep it
               }
               else
               {
                   nodes[i].Delete();
               }
               if (nodes[i].Children != null)
                   RecurseNodes(nodes[i].Children);
           }
           
       }


       private void AddWebPartsToWelcomePage(SPWeb documentWorkspace, string welcomePageURL)
       {
           SPLimitedWebPartManager webPartManager = documentWorkspace.GetLimitedWebPartManager(welcomePageURL, System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);

           string SiteURL = documentWorkspace.Site.RootWeb.Url;
           // Workflow Dashboard Web Part
           SilverlightWebPart swpWFDashboard = new SilverlightWebPart();
           swpWFDashboard.Url = string.Format(@"{0}/{1}/WorkflowDashboard.xap", SiteURL, "Apps") ;
           swpWFDashboard.Height = new Unit("200px");
           swpWFDashboard.Title = "Workflow Dashboard";
           swpWFDashboard.ChromeType = System.Web.UI.WebControls.WebParts.PartChromeType.TitleOnly;
           
           
           webPartManager.AddWebPart(swpWFDashboard, "Zone 2", 0);
           

           // Key Events Web part
           SilverlightWebPart swpKeyEvents = new SilverlightWebPart();
           swpKeyEvents.Url = string.Format(@"{0}/{1}/PaperlessBoardSLWebparts.xap", SiteURL, "Apps") ;
           swpKeyEvents.Title = "Key Events";
           swpKeyEvents.ChromeType = System.Web.UI.WebControls.WebParts.PartChromeType.TitleOnly;

           webPartManager.AddWebPart(swpKeyEvents, "Zone 2", 1);

           // Key People Web Part
           SilverlightWebPart swpActiveTasks = new SilverlightWebPart();
           swpActiveTasks.Url = string.Format(@"{0}/{1}/ActiveTasksForWorkspace.xap", SiteURL, "Apps");
           swpActiveTasks.Title = "Active Tasks";
           swpActiveTasks.ChromeType = System.Web.UI.WebControls.WebParts.PartChromeType.TitleOnly;

           webPartManager.AddWebPart(swpActiveTasks, "Zone 2", 2);

           // Key People Web Part
           SilverlightWebPart swpKeyPeople = new SilverlightWebPart();
           swpKeyPeople.Url = string.Format(@"{0}/{1}/PBSilverlightKeyPeopleInAgendaWP.xap", SiteURL, "Apps") ;
           swpKeyPeople.Title = "Key People";
           swpKeyPeople.ChromeType = System.Web.UI.WebControls.WebParts.PartChromeType.TitleOnly;
           swpKeyPeople.Height = new Unit("300px");
           webPartManager.AddWebPart(swpKeyPeople, "Zone 2", 3);
           
           documentWorkspace.Update();
       }

       private void AddKeyPeopleToAgenda(SPSite rootSite, SPWeb documentWorkspace, Guid keyPeopleListID, string masterKeyPeopleListName, string agendaType, string aGMOffice)
       {
          
           SPList keyPeopleList = documentWorkspace.Lists[keyPeopleListID];

           SPList masterKeyPeopleList = rootSite.RootWeb.Lists[masterKeyPeopleListName];

           SPQuery query = new SPQuery()
           {
               Query = string.Format(@" <Query>
                                          <Where>
                                            <And>
                                              <Eq>
                                                <FieldRef Name='Agenda_x0020_Type' />
                                                <Value Type='Choice'>{0}</Value>
                                              </Eq>
                                              <Eq>
                                                <FieldRef Name='AGM_x0020_Office' />
                                                <Value Type='Choice'>{1}</Value>
                                              </Eq>
                                            </And>
                                          </Where>
                                        </Query>", agendaType, aGMOffice)

              
           };

           foreach (SPListItem keyPerson in masterKeyPeopleList.GetItems(query))
           {
               if ((keyPerson["Agenda Type"].ToString() == agendaType) && (keyPerson["AGM Office"].ToString() == aGMOffice))
               {
                   SPListItem keyPersonForAgenda = keyPeopleList.AddItem();
                   keyPersonForAgenda["Position"] = keyPerson["Position"];

                   if (keyPerson["Position"].ToString() == "Agenda Coordinator")
                   {
                       SPFieldUserValue keyPersonValue = new SPFieldUserValue(rootSite.RootWeb, keyPerson["KeyPerson"].ToString());

                       keyPersonForAgenda["KeyPerson"] = keyPersonValue.User;
                       keyPerson["IsContributor"] = true;
                   }

                   keyPersonForAgenda.Update();
               }
           }

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
        
        public static string ProcurementResolution = "PB_DS_PR_V2.02";
        public static string NonProcurementResolution = "DocSet For NonProcurementResolution V1.3";
        public static string OtherMatters = "DocSet For OtherMatters V1.3";
        public static string Briefing = "DocSet For Briefing V1.3";
        public static string MeetingMinutes = "DocSet For Meeting Minutes V1.3";

    }
}
