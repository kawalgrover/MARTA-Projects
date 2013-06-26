using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Administration;

namespace PB_Emis.List_Definitions.Board_Meetings.Board_Meeting_List.BoardMeetingUpdated
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BoardMeetingUpdated : SPItemEventReceiver
    {

        string emisSiteURL;
        string emisWebURL;
        string boardMeetingListNameOnEmisSite;

       /// <summary>
       /// An item was updated.
       /// </summary>
       public override void ItemUpdated(SPItemEventProperties properties)
       {
           InitializeProperties(properties);

           //Update the BoardMeeting List in Emis
           using (SPSite site = new SPSite(emisSiteURL))
           using (SPWeb emisWeb = site.OpenWeb(emisWebURL))
           {
               SPList boardMeetingList = emisWeb.Lists[boardMeetingListNameOnEmisSite];
               SPQuery query = new SPQuery()
               {
                   Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='MeetingID' />
                                                  <Value Type='Text'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", properties.ListItemId.ToString())
               };

               foreach (SPListItem meeting in boardMeetingList.GetItems(query))
               {
                   if (meeting["MeetingID"].ToString() == properties.ListItemId.ToString())
                   {
                       meeting["MeetingTitle"] = properties.ListItem["Title"].ToString(); ;
                       meeting["MeetingDate"] = properties.ListItem["EventDate"].ToString();
                       meeting.Update();
                       break;
                   }
               }

               //Now update all board Agendas that have this meeting.
               SPList boardAgendaList = emisWeb.Lists["Board Agenda"];
               SPQuery boardAgendaQuery = new SPQuery()
               {
                   Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='CommitteeMeeting' />
                                                  <Value Type='Text'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", properties.ListItemId.ToString())
               };
               foreach (SPListItem boardAgenda in boardAgendaList.GetItems(boardAgendaQuery))
               {
                   if (boardAgenda["CommitteeMeeting"].ToString() == properties.ListItemId.ToString())
                   {
                       boardAgenda["MeetingTitle"] = properties.ListItem["Title"].ToString(); ;
                       boardAgenda["MeetingDate"] = properties.ListItem["EventDate"].ToString(); ;
                       boardAgenda.Update();
                   }
               }

           }

           base.ItemUpdated(properties);
       }

       /// <summary>
       /// An item was deleted.
       /// </summary>
       public override void ItemDeleted(SPItemEventProperties properties)
       {
           base.ItemDeleted(properties);
       }

       private void InitializeProperties(SPItemEventProperties properties)
       {

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
       }
    }
}
