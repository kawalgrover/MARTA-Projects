using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Meetings;
using System.Collections.Generic;
using Microsoft.SharePoint.Utilities;
using System.Web;
using System.Data;
using System.Linq;

namespace PaperlessBoard_Board_Webparts.AgendaList
{
    public partial class AgendaListUserControl : UserControl
    {
        private string emisSiteURL;
        private string emisSiteRelativeURL;
        SPList boardMeetingsList;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatusMessage.Visible = false;

            if (!Page.IsPostBack)
            {
                InitializeWebAppProperties();

                SPWeb meetingWorkspace = SPContext.Current.Web;

                SPWeb rootBoardWeb = meetingWorkspace.Site.RootWeb;

                try
                {
                    boardMeetingsList = rootBoardWeb.Lists["Board Meeting"];
                }
                catch (Exception ex)
                {
                    lblStatusMessage.Text = string.Format("There was an exception getting the Board Meeting list. Exception was {0}", ex.Message);
                    lblStatusMessage.Visible = true;
                }

                int meetingID = 0;

                foreach (SPListItem meeting in boardMeetingsList.Items)
                {
                    SPFieldUrlValue meetingWorkspaceLink = null;

                    try
                    {
                        meetingWorkspaceLink = new SPFieldUrlValue(meeting["Workspace"].ToString());
                    }
                    catch (Exception ex)
                    {
                        lblStatusMessage.Text = string.Format("Error getting the Workspace link for the board Meeting. Exception was {0}. MeetingID was {1}", ex.Message, meeting.ID);
                        lblStatusMessage.Visible = true;
                    }

                    if (meetingWorkspaceLink != null)
                    {
                        if (meetingWorkspaceLink.Url.Contains(meetingWorkspace.Url))
                        {
                            meetingID = meeting.ID;
                            break;
                        }
                    }
                }

                if (meetingID > 0)
                    GetAgendaItemsForMeeting(meetingID);
               
            }
        }

        


        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
                emisSiteRelativeURL = webApplication.Properties["EmisSiteRelativeURL"].ToString();

            }

        }

        private void GetAgendaItemsForMeeting(int meetingID)
        {
            try
            {
                using (SPSite emisSite = new SPSite(emisSiteURL))
                {
                    using (SPWeb emisRootWeb = emisSite.OpenWeb(emisSiteRelativeURL))
                    {
                        SPList agendaList = null;
                        try
                        {
                            agendaList = emisRootWeb.Lists["Board Agenda"];
                        }
                        catch (Exception ex)
                        {
                            lblStatusMessage.Text = string.Format("Error getting the Board Agenda List from the EMIS site. Exception was {0}.", ex.Message);
                            lblStatusMessage.Visible = true;
                        }

                        SPQuery query = new SPQuery()
                        {
                            Query = string.Format(@"<Query>
                                                  <Where>
                                                    <Eq>
                                                      <FieldRef Name='CommitteeMeeting' />
                                                      <Value Type='Text'>{0}</Value>
                                                    </Eq>
                                                  </Where>
                                                </Query>", meetingID.ToString())
                        };

                        List<Agenda> agendasForMeeting = new List<Agenda>();

                        if (agendaList != null)
                        {
                            foreach (SPListItem agenda in agendaList.GetItems(query))
                            {
                                try
                                {
                                    if (agenda["CommitteeMeeting"].ToString() == meetingID.ToString())
                                    {
                                        Agenda agendaItem = new Agenda();
                                        if (agenda["AgendaOrder"] != null)
                                        {
                                            int i;
                                            if (int.TryParse(agenda["AgendaOrder"].ToString(), out i))
                                            {
                                                agendaItem.ItemNumber = i;
                                            }
                                            else
                                                agendaItem.ItemNumber = null;
                                            
                                        }

                                        if (agenda["Presenter"] != null)
                                            agendaItem.Sponsor = agenda["Presenter"].ToString();

                                        if (agenda["PublishedDocs"] != null)
                                        {
                                            agendaItem.Documents = new SPFieldUrlValue(agenda["PublishedDocs"].ToString()).Url;
                                        }
                                        agendaItem.Subject = agenda["Title"].ToString();

                                        agendasForMeeting.Add(agendaItem);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    lblStatusMessage.Text = string.Format("Error while looping through the Agendas. Exception was {0}. AgendaID was {1}. Possible error fields include 'CommitteeMeeting', 'AgendaOrder', 'Presenter', 'PublishedDocs' and 'Title'.", ex.Message, agenda.ID);
                                    lblStatusMessage.Visible = true;
                                }
                            }
                        }

                        var sortedAgendas = agendasForMeeting.OrderBy(a => a.ItemNumber);
                        grdAgendaList.DataSource = sortedAgendas;
                        grdAgendaList.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatusMessage.Text = string.Format("Error getting all the agendas for this meeting. Exception was {0}.", ex.Message);
                lblStatusMessage.Visible = true;
            }
        }



        protected void grdActionsOwed_RowComand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = grdAgendaList.Rows[index];

            string agendaID = grdAgendaList.DataKeys[index].Values[0].ToString();
            string docsLink = grdAgendaList.DataKeys[index].Values[1].ToString();

            SPUtility.Redirect(docsLink, SPRedirectFlags.DoNotEncodeUrl, HttpContext.Current);

        }
    }

    public class Agenda
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public int? ItemNumber { get; set; }
        public string Sponsor { get; set; }
        public string Documents { get; set; }
        public bool IsPublished
        {
            get
            {
                if (string.IsNullOrEmpty(Documents))
                    return false;
                else
                    return true;
            }
        }
    }
}
