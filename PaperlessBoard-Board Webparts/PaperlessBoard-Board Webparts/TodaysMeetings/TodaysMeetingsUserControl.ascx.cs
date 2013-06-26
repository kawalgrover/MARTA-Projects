using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.Utilities;
using System.Web;
using System.Collections.Generic;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Linq;

namespace PaperlessBoard_Board_Webparts.TodaysMeetings
{
    public partial class TodaysMeetingsUserControl : UserControl
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

                    DateTime meetingDate = DateTime.Today.AddDays(90);
                    SPQuery query = new SPQuery()
                    {
                        Query = string.Format(@"<Query>
                                                  <Where>
                                                    <Eq>
                                                      <FieldRef Name='EventDate' />
                                                      <Value IncludeTimeValue='FALSE' Type='DateTime'>{0}</Value>
                                                    </Eq>
                                                  </Where>
                                                </Query>", SPUtility.CreateISO8601DateTimeFromSystemDateTime(meetingDate))
                    };

                    List<BoardMeetings> boardMeetings = new List<BoardMeetings>();

                    foreach (SPListItem meeting in meetingsList.GetItems(query))
                    {
                        if (DateTime.Parse(meeting["EventDate"].ToString()).Date == DateTime.Today)
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
