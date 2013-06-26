using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using System.Collections.Generic;
using System.Web.Services;
using System.ServiceModel.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SharePoint.Administration;
using System.Linq;

namespace MARTA.PaperlessBoard
{
    public partial class NewAgenda : WebPartPage
    {
        protected Panel pnlAgenda;
        protected Panel pnlNotAuthorized;
        protected DropDownList ddlAGMOffice;
        protected DropDownList ddlAgendaType;

        protected void Page_Load(object sender, EventArgs e)
        {
            //ScriptManager scriptManager1 = ScriptManager.GetCurrent(this.Page);
            //if (scriptManager1 == null)
            //{
            //    scriptManager1 = new ScriptManager() { ID = "ScriptManager1" };
            //    this.Controls.Add(scriptManager1);
            //}
            //scriptManager1.Services.Add(new ServiceReference("~/_vti_bin/PaperlessBoard/endpoint.svc"));
        }

        protected void AGMOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPWebApplication webApplication = SPContext.Current.Site.WebApplication;

            string keyPeopleListName = webApplication.Properties["MasterKeyPeopleListName"].ToString();

            SPList list = SPContext.Current.Web.Lists[keyPeopleListName];

            ShowAuthPanel(false);

            SPQuery query = new SPQuery()
            {
                Query = string.Format(@"<Query>
                                          <Where>
                                            <And>
                                              <Eq>
                                                <FieldRef Name='Agenda Type' />
                                                <Value Type='Choice'>{0}</Value>
                                              </Eq>
                                              <And>
                                                <Eq>
                                                  <FieldRef Name='AGM Office' />
                                                  <Value Type='Choice'>{1}</Value>
                                                </Eq>
                                                <Eq>
                                                  <FieldRef Name='PositionInMarta' />
                                                  <Value Type='Text'>Agenda Coordinator</Value>
                                                </Eq>
                                              </And>
                                            </And>
                                          </Where>
                                        </Query>", ddlAgendaType.SelectedValue, ddlAGMOffice.SelectedValue)
            };

            if (list != null)
            {
                SPFieldUserValueCollection authUsers = new SPFieldUserValueCollection();

                foreach (SPListItem item in list.GetItems(query))
                {
                    //For some reason the Query seems to be returning all data and not what its filtered by, so explicity check here.
                    if ((item["PositionInMarta"].ToString() == "Agenda Coordinator") && (item["AGM Office"].ToString() == ddlAGMOffice.SelectedValue) && (item["Agenda Type"].ToString() == ddlAgendaType.SelectedValue))
                    {
                        string authUsersFieldValue = item["KeyPerson"].ToString();

                        
                        authUsers.Add(new SPFieldUserValue(item.Web, authUsersFieldValue));
                    }
                }

                SPUser currentUser = list.ParentWeb.CurrentUser;
                SPFieldUserValue currentUserValue = new SPFieldUserValue(list.ParentWeb, currentUser.ID, currentUser.Name);

                if (authUsers.Where(u => u.User.LoginName == currentUser.LoginName).SingleOrDefault() != null)
                {
                    ShowAuthPanel(true);
                }
                else
                    ShowAuthPanel(false);
                    
            }
           
        }

        private void ShowAuthPanel(bool isAuthorized)
        {
            if (isAuthorized)
            {
                pnlAgenda.Visible = true;
                pnlNotAuthorized.Visible = false;
            }
            else
            {
                pnlAgenda.Visible = false;
                pnlNotAuthorized.Visible = true;
            }
        }

        ////[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //[WebMethod]
        //public static List<BoardMeetingInfo> GetBoardMeetings(string meetingType)
        //{
        //    List<BoardMeetingInfo> boardMeetings = new List<BoardMeetingInfo>();

        //    using (SPSite site = new SPSite("http://m264981:1411"))
        //    using (SPWeb web = site.OpenWeb())
        //    {
        //        SPList list = web.Lists["Board Meeting"];
        //        SPListItemCollection meetings = list.Items;

        //        foreach (SPListItem meeting in meetings)
        //        {
        //            if (meeting["Committee"].ToString() == meetingType)
        //            {
        //                DateTime meetingStartTime = DateTime.Parse(meeting["EventDate"].ToString());
        //                if (meetingStartTime > DateTime.Now)
        //                {
        //                    BoardMeetingInfo bmi = new BoardMeetingInfo()
        //                    {
        //                        StartTime = DateTime.Parse(meeting["EventDate"].ToString()),
        //                        Title = meeting["Title"].ToString(),
        //                        WorkspaceURL = meeting["Workspace"].ToString(),
        //                        MeetingID = meeting.ID
        //                    };
        //                    boardMeetings.Add(bmi);
        //                }
        //            }
        //        }
        //    }

        //    return boardMeetings;
        //}
    }
}
