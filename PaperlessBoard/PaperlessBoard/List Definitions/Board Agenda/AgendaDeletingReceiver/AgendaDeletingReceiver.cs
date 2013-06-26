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

namespace MARTA.PaperlessBoard.List_Definitions.Board_Agenda.AgendaDeletingReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class AgendaDeletingReceiver : SPItemEventReceiver
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
       /// An item is about to be deleted.
       /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
       {
           /*
            * When at agenda is deleted, it needs to:
            * 1. Be deleted from the Emis Look Ahead List
            * 2. The document workspace associated with that agenda needs to be deleted.
            * 3. Be deleted from the Board look ahead list
            * 4. Be deleted from the Agenda List in the corresponding meeting workspace
            * 
            * 
            * */

           //1. Delete from the Emis Look ahead list first.
           int AgendaID = properties.ListItemId;
           // Update Look Ahead list in Emis
           InitializeWebAppProperties(properties);
           using (PBEntitiesDataContext ctx = new PBEntitiesDataContext(emisSiteURL))
           {
               EntityList<FutureAgendaItemsLookAheadForEmis> agendas = ctx.GetList<FutureAgendaItemsLookAheadForEmis>("Future Agenda Items");
               
               var agendaInLookAheadEmis = agendas.Where(a => a.AgendaID == properties.ListItemId.ToString()).Single();
               agendas.DeleteOnSubmit(agendaInLookAheadEmis);

               ctx.SubmitChanges();
           }

           //Delete the document workspace associated with that Agenda.
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

           documentWorkspace.Delete();

           // Now go the Board site and take care of look ahead list there.
          
           using (SPSite boardSite = new SPSite(boardSiteURL))
           using (SPWeb boardWeb = boardSite.OpenWeb())
           {
               SPList boardLookAheadList = boardWeb.Lists[lookAheadListNameInBoard];
               SPFieldUrlValue meetingWorkspaceURL = null;
           
               foreach (SPListItem agenda in boardLookAheadList.Items)
               {
                   if (agenda["AgendaID"].ToString() == AgendaID.ToString())
                   {
                       meetingWorkspaceURL = new SPFieldUrlValue(agenda["MeetingWorkspace"].ToString());
                       agenda.Delete();
                       boardLookAheadList.Update();
                       break;
                   }
               }

               //Now go to the meeting workspace and delete the agenda from in there.
               SPMeeting meetingSites = SPMeeting.GetMeetingInformation(boardWeb);
               SPWebCollection meetingWorkspaces = meetingSites.GetWorkspacesToLinkTo(false);
               
               foreach (SPWeb meetingWorkspace in meetingWorkspaces)
               {
                   if (meetingWorkspaceURL.Url.Contains(meetingWorkspace.Url))
                   {
                       SPList workspaceAgendaList = meetingWorkspace.Lists["Agenda"];
                       foreach (SPListItem agenda in workspaceAgendaList.Items)
                       {
                           if (agenda["Subject"].ToString() == properties.ListItem.Title)
                           {
                               agenda.Delete();
                               workspaceAgendaList.Update();
                               break;
                           }
                       }

                       //And if there is a document set with that Agenda Name, that has to go as well.
                       SPList sourceDocumentLibrary = meetingWorkspace.Lists["Document Library"];

                       foreach (SPListItem sourceDoc in sourceDocumentLibrary.Items)
                       {
                            //If the title of the item matches the name of the Document Set, its our Document Set List Item.
                           if (sourceDoc["Name"].ToString() == properties.ListItem.Title)
                           {
                               sourceDoc.Delete();
                               sourceDocumentLibrary.Update();
                               break;
                           }
                       }
                       break;
                                   
                   }

                   
               }

           }


           base.ItemDeleted(properties);
       }


    }
}
