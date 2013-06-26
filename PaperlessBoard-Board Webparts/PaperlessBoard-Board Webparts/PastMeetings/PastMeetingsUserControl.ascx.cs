using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint;
using System.Collections.Generic;
using PaperlessBoard_Board_Webparts.TodaysMeetings;
using Microsoft.SharePoint.Administration;
using System.Web;
using System.Linq;

namespace PaperlessBoard_Board_Webparts.PastMeetings
{
    public partial class PastMeetingsUserControl : UserControl
    {
        private string boardSiteURL;
        private string boardMeetingListName;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                InitializeWebAppProperties();
                GetUpcomingMeetings();
            }
        }


        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                boardSiteURL = webApplication.Properties["BoardSiteURL"].ToString();
                boardMeetingListName = webApplication.Properties["BoardMeetingListName"].ToString();

            }

        }

        private void GetUpcomingMeetings()
        {
            using (SPSite boardSite = new SPSite(boardSiteURL))
            {
                using (SPWeb boardRootWeb = boardSite.OpenWeb())
                {
                    SPList meetingsList = boardRootWeb.Lists[boardMeetingListName];

                    DateTime meetingDate = DateTime.Today;
                    SPQuery query = new SPQuery()
                    {
                        Query = string.Format(@"<Query>
                                                  <Where>
                                                    <Leq>
                                                      <FieldRef Name='EventDate' />
                                                      <Value IncludeTimeValue='FALSE' Type='DateTime'>{0}</Value>
                                                    </Leq>
                                                  </Where>
                                                </Query>", SPUtility.CreateISO8601DateTimeFromSystemDateTime(meetingDate))
                    };

                    List<BoardMeetings> boardMeetings = new List<BoardMeetings>();

                    foreach (SPListItem meeting in meetingsList.GetItems(query))
                    {
                        if (DateTime.Parse(meeting["EventDate"].ToString()).Date < DateTime.Today)
                        {
                            BoardMeetings boardMeeting = new BoardMeetings()
                            {
                                MeetingID = meeting.ID,
                                Title = meeting["Title"].ToString(),
                                EventDate = meeting["EventDate"].ToString()

                            };
                            SPFieldUrlValue meetingWorkspace = new SPFieldUrlValue(meeting["Workspace"].ToString());
                            
                            string siteURL = meeting.ParentList.ParentWeb.Site.Url;
                            string completeURL = meetingWorkspace.Url;

                            //Get the index of the last slash
                            int lastSlash = completeURL.LastIndexOf("/");
                            string relativeURL = completeURL.Substring(lastSlash);
                            boardMeeting.Workspace = relativeURL; //meetingWorkspace.Url;

                            boardMeetings.Add(boardMeeting);
                        }
                    }


                    var sortedMeetings = boardMeetings.OrderBy(m => m.Title);
                    grdMeetings.DataSource = sortedMeetings;
                    grdMeetings.DataBind();
                }
            }
        }



        protected void grdActionsOwed_RowComand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = grdMeetings.Rows[index];

            string MeetingID = grdMeetings.DataKeys[index].Values[0].ToString();
            string MeetingLink = grdMeetings.DataKeys[index].Values[1].ToString();

            SPUtility.Redirect(MeetingLink, SPRedirectFlags.UseSource, HttpContext.Current);

        }
    }
}
