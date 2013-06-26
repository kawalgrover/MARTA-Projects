using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Meetings;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.WebPartPages;
using System.Xml;
using System.Globalization;

namespace PB_Emis.List_Definitions.Board_Meetings.Board_Meeting_List.BoardMeetingReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BoardMeetingReceiver : SPItemEventReceiver
    {
       /// <summary>
       /// An item was added.
       /// </summary>
       public override void ItemAdded(SPItemEventProperties properties)
       {
           CreateMeetingWorkspace(properties);
           CopyToEmisSite(properties);

           base.ItemAdded(properties);
       }

       private void CopyToEmisSite(SPItemEventProperties properties)
       {
           string emisSiteURL = null;
           string emisWebURL = null;
           string boardMeetingListNameOnEmisSite = null;

           SPWebApplication webApplication = properties.Web.Site.WebApplication;
           if (webApplication.Properties != null && webApplication.Properties.Count > 0)
           {
               if (webApplication.Properties.ContainsKey("EmisSiteURL"))
               {
                   emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
               }
               if (webApplication.Properties.ContainsKey("EmisWebURL"))
               {
                   emisWebURL = webApplication.Properties["EmisWebURL"].ToString();
               }
               if (webApplication.Properties.ContainsKey("BoardMeetingListNameOnEmis"))
               {
                   boardMeetingListNameOnEmisSite = webApplication.Properties["BoardMeetingListNameOnEmis"].ToString();
               }
           }
           using (SPSite site = new SPSite(emisSiteURL))
           using (SPWeb emisWeb = site.OpenWeb(emisWebURL))
           {
               SPList boardMeetingList = emisWeb.Lists[boardMeetingListNameOnEmisSite];
               SPListItem newMeeting = boardMeetingList.AddItem();
               newMeeting["Title"] = properties.ListItem["Title"].ToString();
               newMeeting["MeetingID"] = properties.ListItemId;
               //newMeeting["WorkspaceURL"] = properties.ListItem["Workspace"].ToString();
               newMeeting["MeetingDate"] = properties.ListItem["EventDate"].ToString();
               newMeeting["Committee"] = properties.ListItem["Board Committee"].ToString();

               newMeeting.Update();
           }

       }
       private void CreateMeetingWorkspace(SPItemEventProperties properties)
       {
           using (SPWeb web = properties.OpenWeb())
           using (SPSite site = web.Site)
           {
               const Int32 LOCALE_ID_ENGLISH = 1033;
               SPWebTemplateCollection templates = site.GetWebTemplates(Convert.ToUInt32(LOCALE_ID_ENGLISH));

               try
               {
                   SPWebTemplate template = templates["MPS#0"];
                   SPSecurity.RunWithElevatedPrivileges(delegate()
                   {
                       using (SPSite elevatedSite = new SPSite(site.ID))
                       using (SPWeb elevatedWeb = elevatedSite.OpenWeb())
                       {
                           SPWeb meetingWorkspace = elevatedWeb.Webs.Add(
                           string.Format("{0}-{1}", properties.List.Title,
                           Guid.NewGuid().ToString()),
                           properties.ListItem["Title"].ToString(),
                           properties.ListItem["Location"].ToString(),
                           Convert.ToUInt32(LOCALE_ID_ENGLISH),
                           template,
                           false, //TODO: This will change to true. We will need custom permissions for each meeting workspace.
                           false);

                           SPMeeting meeting = SPMeeting.GetMeetingInformation(meetingWorkspace);

                           meeting.LinkWithEvent(web,
                               properties.ListId.ToString(),
                               properties.ListItemId,
                               "WorkspaceLink",
                               "Workspace");

                           meetingWorkspace.AllowUnsafeUpdates = true;
                           string currentTheme = web.Theme;
                           meetingWorkspace.ApplyTheme(currentTheme);
                           //Add the DocumentSet content Type to 'Document Library'
                           SPList documentLibrary = meetingWorkspace.Lists["Document Library"];
                           documentLibrary.ContentTypes.Add(site.RootWeb.ContentTypes["Document Set"]);
                           documentLibrary.Update();

                           //Remove the Objectives List and Attendees List from meeting workspace
                          
                           SPList objectivesList = meetingWorkspace.Lists["Objectives"];
                           SPList attendeesList = meetingWorkspace.Lists["Attendees"];

                           meetingWorkspace.Lists.Delete(objectivesList.ID);
                           attendeesList.Hidden = true;
                           attendeesList.Update();

                           //Hide the webpart

                           SPLimitedWebPartManager webPartManager = meetingWorkspace.GetLimitedWebPartManager("Default.aspx", System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);

                           for (int k = 0; k < webPartManager.WebParts.Count; k++)
                           {
                               //get reference to webpart
                               WebPart wp = webPartManager.WebParts[k] as WebPart;

                               webPartManager.DeleteWebPart(webPartManager.WebParts[k]);
                               //update spWeb object
                               meetingWorkspace.Update();
                               
                           }

                           //Add the extra fields to the Agenda List
                           SPList meetingAgendaList = meetingWorkspace.Lists["Agenda"];
                           SPField ownerField = meetingAgendaList.Fields["Owner"];
                           SPField timeField = meetingAgendaList.Fields["Time"];

                           ownerField.Title = "Presenter";
                           timeField.Title = "Time (in minutes)";
                           ownerField.Update();
                           timeField.Update();

                           SPField fldSponsor = meetingAgendaList.Fields.CreateNewField(SPFieldType.User.ToString(), "Sponsor");
                           SPField fldItemNumber = meetingAgendaList.Fields.CreateNewField(SPFieldType.Number.ToString(), "Item Number");
                           SPField fldOffice = meetingAgendaList.Fields.CreateNewField(SPFieldType.Text.ToString(), "Office");
                           SPField fldAgendaID = meetingAgendaList.Fields.CreateNewField(SPFieldType.Number.ToString(), "AgendaID");
                           SPField fldDocuments = meetingAgendaList.Fields.CreateNewField(SPFieldType.URL.ToString(), "Documents");

                           meetingAgendaList.Fields.Add(fldSponsor);
                           meetingAgendaList.Fields.Add(fldItemNumber);
                           meetingAgendaList.Fields.Add(fldOffice);
                           meetingAgendaList.Fields.Add(fldDocuments);
                           meetingAgendaList.Fields.Add(fldAgendaID);
                           meetingAgendaList.Update();

                           SPView defaultView = meetingAgendaList.Views["All Items"];
                           SPViewFieldCollection viewFields = defaultView.ViewFields;
                           viewFields.Add(meetingAgendaList.Fields["Sponsor"]);
                           viewFields.Add(meetingAgendaList.Fields["Item Number"]);
                           viewFields.Add(meetingAgendaList.Fields["Office"]);
                           viewFields.Add(meetingAgendaList.Fields["Documents"]);
                           defaultView.Update();

                           meetingWorkspace.Update();

                           meetingWorkspace.AllowUnsafeUpdates = false;
                           
                       }
                   });
               }
               catch (Exception ex)
               {
                   properties.Cancel = true;
                   properties.ErrorMessage = ex.Message;
               }
           }
       }

       public static System.Web.UI.WebControls.WebParts.WebPart CreateWebPart(SPWeb web, string webPartName, SPLimitedWebPartManager webPartManager)
       {

           SPQuery qry = new SPQuery();

           qry.Query = String.Format(CultureInfo.CurrentCulture,
               "<Where><Eq><FieldRef Name='FileLeafRef'/><Value Type='File'>{0}</Value></Eq></Where>",
               webPartName);

           SPList webPartGallery = null;



           if (null == web.ParentWeb)
           {
               webPartGallery = web.GetCatalog(SPListTemplateType.WebPartCatalog);
           }

           else
           {
               webPartGallery = web.Site.RootWeb.GetCatalog(SPListTemplateType.WebPartCatalog);
           }



           SPListItemCollection webParts = webPartGallery.GetItems(qry);



           XmlReader xmlReader = new XmlTextReader(webParts[0].File.OpenBinaryStream());

           string errorMsg;

           System.Web.UI.WebControls.WebParts.WebPart webPart = webPartManager.ImportWebPart(xmlReader, out errorMsg);



           return webPart;

       }



    }
}
