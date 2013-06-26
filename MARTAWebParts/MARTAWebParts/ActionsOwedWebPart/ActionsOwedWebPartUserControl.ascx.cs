using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.SharePoint.Utilities;
using System.Web;
using System.Linq;
using System.Text;

namespace MARTAWebParts.ActionsOwedWebPart
{
    public partial class ActionsOwedWebPartUserControl : UserControl
    {
        private string sites;
        private List<ActionOwed> actionsOwed;

        public ActionsOwedWebPart WebPart { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            grdActionsOwed.Sorting += new GridViewSortEventHandler(grdActionsOwed_Sorting);
            chkMyDelegatedTasks.CheckedChanged += new EventHandler(chkMyDelegatedTasks_CheckedChanged);
            chkRecentTasksOnly.CheckedChanged += new EventHandler(chkRecentTasksOnly_CheckedChanged);

            if (!Page.IsPostBack)
            {
                InitializeWebAppProperties();

                try
                {
                    GetAllActionsOwed();
                }
                
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(lblStatusMessage.Text);

                    sb.Append(Environment.NewLine);
                    sb.Append("Error Getting All Actions Owed.");
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format(" ErrorMessage: {0} ", ex.Message));
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Format(" StackTrace: {0} ", ex.StackTrace));
                    lblStatusMessage.Text = sb.ToString();
                }
                   
            }
        }

        private void GetAllActionsOwed()
        {
            actionsOwed = new List<ActionOwed>();

            if (this.WebPart.Mode == DashboardMode.LocalSiteOnly)
            {
                SPWeb currentWeb = SPContext.Current.Web;
                GetAllMARTATasksFromWeb(currentWeb);
            }
            else if (this.WebPart.Mode == DashboardMode.RootSiteCollectionOnly)
            {
                SPWeb rootWeb = SPContext.Current.Site.RootWeb;
                GetAllMARTATasksFromWeb(rootWeb);
            }
            else if (this.WebPart.Mode == DashboardMode.RootSiteCollectionAndAllSubsites)
            {
                SPWeb rootWeb = SPContext.Current.Site.RootWeb;
                GetAllMARTATasksFromWeb(rootWeb);

                foreach (SPWeb subSite in rootWeb.Webs)
                {
                    GetAllMARTATasksFromWeb(subSite);
                }
            }
            else if (this.WebPart.Mode == DashboardMode.SiteCollections)
            {
                throw new NotImplementedException();
            }
            else if (this.WebPart.Mode == DashboardMode.WebApplicationsAndAllSiteCollections)
            {
                throw new NotImplementedException();
            }

            var sortedActionsOwed = actionsOwed.OrderBy(a => a.DueDate);
            grdActionsOwed.DataSource = sortedActionsOwed;
            grdActionsOwed.DataBind();

        }

        private void GetAllMARTATasksFromWeb(SPWeb web)
        {
            
            SPContentType martaTaskContentType = web.AvailableContentTypes["MARTA Task"];
            SPContentType martaWFTaskContentType = web.AvailableContentTypes["MARTA Workflow Task"];

            IList<SPContentTypeUsage> martaTaskUsages = null;
            IList<SPContentTypeUsage> martaWFTaskUsages = null;

            try
            {
                martaTaskUsages = SPContentTypeUsage.GetUsages(martaTaskContentType);
                martaWFTaskUsages = SPContentTypeUsage.GetUsages(martaWFTaskContentType);

                //Combine the usages of the WF Marta Task with the regular MARTA Task.
                foreach (SPContentTypeUsage usage in martaWFTaskUsages)
                {
                    if (martaTaskUsages.Where(u => u.Url == usage.Url).SingleOrDefault() == null)
                        martaTaskUsages.Add(usage);
                }
            }
            catch (Exception ex)
            {
                lblStatusMessage.Text = string.Format("Error getting Content Types for MARTA Task and/or MARTA Workflow Task. \r\n ErrorMessage: {0} \r\n StackTrace: {1}", ex.Message, ex.StackTrace);
            }

            foreach (SPContentTypeUsage taskUsage in martaTaskUsages)
            {

                if (taskUsage.IsUrlToList)
                {
                    if (taskUsage.Url.StartsWith("/Lists"))
                    {
                        try
                        {
                            SPList taskList = web.GetList(taskUsage.Url);



                            //Get the MARTA Tasks and put them in a collection

                            SPQuery queryForActionsOwed = new SPQuery()
                            {
                                Query = @"<Where>
                                               <And>
                                                   <Eq>
                                                       <FieldRef Name='AssignedTo' />
                                                       <Value Type='User'><UserID/></Value>
                                                   </Eq>
                                                   <Neq>
                                                       <FieldRef Name='Status' />
                                                       <Value Type='Choice'>Completed</Value>
                                                   </Neq>
                                               </And>
                                           </Where>
                                           <OrderBy>
                                               <FieldRef Name='DueDate'/>
                                           </OrderBy>"
                            };

                            foreach (SPListItem activeTask in taskList.GetItems(queryForActionsOwed))
                            {

                                ActionOwed action = new ActionOwed()
                                {
                                    TaskID = activeTask["ID"].ToString(),
                                    Title = activeTask["Title"].ToString(),
                                    DueDate = DateTime.Parse(activeTask["DueDate"].ToString()),
                                    Status = activeTask["Status"].ToString(),
                                    OriginalAssignee = (activeTask["OriginalAssignee"] != null) ? activeTask["OriginalAssignee"].ToString() : String.Empty,
                                    Action = (activeTask["ActionOwed"] != null) ? activeTask["ActionOwed"].ToString() : String.Empty,
                                    Source = (activeTask["TaskSource"] != null) ? activeTask["TaskSource"].ToString() : String.Empty,
                                    FileRef = activeTask["FileRef"].ToString(),
                                    TaskSite = web.Site.Url
                                };
                                if (activeTask["IsDelegated"] == null)
                                {
                                    action.IsDelegated = false;
                                }
                                else if (string.IsNullOrEmpty(activeTask["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = false;
                                }
                                else if (activeTask["IsDelegated"].ToString() == "1")
                                {
                                    action.IsDelegated = true;
                                }
                                else if (bool.Parse(activeTask["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = true;
                                }

                                //string taskRelativeLink = activeTask["FileRef"].ToString().Substring(activeTask["FileRef"].ToString().IndexOf("#") + 1, (activeTask["FileRef"].ToString().Length - activeTask["FileRef"].ToString().IndexOf("#") - 1));
                                action.TaskLink = string.Format(@"{0}\{1}", taskList.ParentWebUrl, taskList.RootFolder.Url);
                                action.AssignedTo = activeTask["AssignedTo"].ToString().Substring(activeTask["AssignedTo"].ToString().IndexOf("#") + 1, (activeTask["AssignedTo"].ToString().Length - activeTask["AssignedTo"].ToString().IndexOf("#") - 1));
                                actionsOwed.Add(action);

                            }
                        }
                        catch (Exception ex)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append(lblStatusMessage.Text);

                            sb.Append(Environment.NewLine);
                            sb.Append(string.Format("The list at {0} could not be opened. Its tasks are not included in this dashboard.", taskUsage.Url));
                          
                            lblStatusMessage.Text = sb.ToString();
                        }
                    }
                    //    }
                    //}
                }
            }
        }

        private void GetAllActionsOwed(string userID)
        {
            List<ActionOwed> actionsOwed = new List<ActionOwed>();

            SPSecurity.RunWithElevatedPrivileges(delegate()
                   {
                       string[] actionsOwedSites = sites.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                       
                       foreach (string site in actionsOwedSites)
                       {
                           using (SPSite emisSite = new SPSite(site))
                           {
                               using (SPWeb emisRootWeb = emisSite.OpenWeb())
                               {
                                   SPSiteDataQuery query = new SPSiteDataQuery();
                                   query.Lists = "<Lists ServerTemplate=\"107\" />";
                                   query.ViewFields = "<FieldRef Name=\"Title\" />" +
                                       "<FieldRef Name=\"ID\" />" +
                                       "<FieldRef Name=\"AssignedTo\" Nullable=\"TRUE\" Type=\"User\" />" +
                                       "<FieldRef Name=\"Status\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                       "<FieldRef Name=\"DueDate\" Nullable=\"TRUE\" Type=\"DateTime\" />" +
                                       "<FieldRef Name=\"IsDelegated\" Nullable=\"TRUE\" Type=\"Boolean\" />" +
                                       "<FieldRef Name=\"OriginalAssignee\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                       "<FieldRef Name=\"ActionOwed\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                        "<FieldRef Name=\"TaskSource\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                       "<FieldRef Name=\"FileRef\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                       "<FieldRef Name=\"Related Content\" Nullable=\"TRUE\" Type=\"Text\" />";

                                   query.Query =
                                       "<Where>" +
                                           "<And>" +
                                               "<Eq>" +
                                                   "<FieldRef Name='AssignedTo' />" +
                                                   " <Value Type='User'>" + userID + "</Value>" +
                                               "</Eq>" +
                                               "<Neq>" +
                                                   "<FieldRef Name='Status' />" +
                                                   "<Value Type='Choice'>Completed</Value>" +
                                               "</Neq>" +
                                           "</And>" +
                                       "</Where>" +
                                       "<OrderBy>" +
                                           "<FieldRef Name=\"DueDate\" />" +
                                       "</OrderBy>";

                                   query.Webs = "<Webs Scope=\"SiteCollection\" />";

                                   Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: About to get data from all subsites for {0}", site);
                                   Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: SPSiteDataQuery = {0}", query.Query);

                                   DataTable dt = emisRootWeb.GetSiteData(query);

                                   Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: Got data from all subsites for {0}", site);


                                   foreach (DataRow row in dt.Rows)
                                   {
                                       ActionOwed action = new ActionOwed()
                                       {
                                           TaskID = row["ID"].ToString(),
                                           Title = row["Title"].ToString(),
                                           DueDate = DateTime.Parse(row["DueDate"].ToString()),
                                           Status = row["Status"].ToString(),
                                           OriginalAssignee = row["OriginalAssignee"].ToString(),
                                           Action = row["ActionOwed"].ToString(),
                                           Source = row["TaskSource"].ToString(),
                                           FileRef = row["FileRef"].ToString(),
                                           TaskSite = site
                                       };
                                       if (string.IsNullOrEmpty(row["IsDelegated"].ToString()))
                                       {
                                           action.IsDelegated = false;
                                       }
                                       else if (row["IsDelegated"].ToString() == "1")
                                       {
                                           action.IsDelegated = true;
                                       }
                                       else if (bool.Parse(row["IsDelegated"].ToString()))
                                       {
                                           action.IsDelegated = true;
                                       }

                                       string taskRelativeLink = row["FileRef"].ToString().Substring(row["FileRef"].ToString().IndexOf("#") + 1, (row["FileRef"].ToString().Length - row["FileRef"].ToString().IndexOf("#") - 1));
                                       action.TaskLink = taskRelativeLink;
                                       action.AssignedTo = row["AssignedTo"].ToString().Substring(row["AssignedTo"].ToString().IndexOf("#") + 1, (row["AssignedTo"].ToString().Length - row["AssignedTo"].ToString().IndexOf("#") - 1));
                                       actionsOwed.Add(action);
                                   }



                               }
                           }
                       }
                   });

            grdActionsOwed.DataSource = actionsOwed;
            grdActionsOwed.DataBind();
            
        }

        void chkRecentTasksOnly_CheckedChanged(object sender, EventArgs e)
        {
            chkMyDelegatedTasks.Checked = false;

            InitializeWebAppProperties();

            if (chkRecentTasksOnly.Checked)
            {

                string[] actionsOwedSites = sites.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                List<ActionOwed> actionsOwed = new List<ActionOwed>();
                DateTime yesterday = DateTime.Today.AddDays(-1);

                foreach (string site in actionsOwedSites)
                {
                    using (SPSite emisSite = new SPSite(site))
                    {
                        using (SPWeb emisRootWeb = emisSite.OpenWeb())
                        {
                            //Get all agendas
                            SPList baList = emisRootWeb.Lists["Board Agenda"];
                            SPQuery queryFutureAgendas = new SPQuery()
                            {
                                Query = string.Format(@"<Query>
                                                        <Where>
                                                            <Geq><FieldRef Name='MeetingDate' />
                                                                <Value IncludeTimeValue='FALSE' Type='DateTime'>{0}</Value>
                                                            </Geq>
                                                        </Where>
                                                    </Query>", SPUtility.CreateISO8601DateTimeFromSystemDateTime(DateTime.Today))
                            };

                            foreach (SPListItem futureAgenda in baList.GetItems(queryFutureAgendas))
                            {
                                if (futureAgenda["MeetingDate"] != null)
                                {
                                    if (DateTime.Parse(futureAgenda["MeetingDate"].ToString()) > DateTime.Today)
                                    {
                                        SPFieldUrlValue workspaceURLField = new SPFieldUrlValue(futureAgenda["DocumentWorkspace"].ToString());
                                        string workspaceURL = workspaceURLField.Url;

                                        if (workspaceURL.IndexOf("Shared Documents") > 0)
                                        {
                                            workspaceURL = workspaceURL.Substring(0, workspaceURL.IndexOf("Shared Documents") - 1);
                                        }

                                        string relativeWSURL = workspaceURL.Remove(0, site.Length);

                                        relativeWSURL = relativeWSURL.Replace("/", "");
                                        //Now open up the workspace
                                        using (SPWeb subSite = emisSite.OpenWeb(relativeWSURL))
                                        {
                                            try
                                            {
                                                SPList agendaTaskList = subSite.Lists["Agenda Tasks"];

                                                if (agendaTaskList != null)
                                                {
                                                    SPQuery queryForActionsOwed = new SPQuery()
                                                    {
                                                        Query = string.Format(@"<Where>
                                                                    <And> 
                                                                         <Geq> 
                                                                             <FieldRef Name='Created' /> 
                                                                             <Value IncludeTimeValue='FALSE' Type='DateTime'>{0}</Value> 
                                                                         </Geq> 
                                                                         <And> 
                                                                            <Eq> 
                                                                                <FieldRef Name='AssignedTo' /> 
                                                                                 <Value Type='User'><UserID/></Value> 
                                                                            </Eq> 
                                                                            <Neq> 
                                                                                <FieldRef Name='Status' /> 
                                                                                <Value Type='Choice'>Completed</Value> 
                                                                            </Neq> 
                                                                        </And> 
                                                                    </And> 
                                                                </Where>
                                                                <OrderBy>
                                                                    <FieldRef Name='DueDate'/>
                                                                </OrderBy>", SPUtility.CreateISO8601DateTimeFromSystemDateTime(yesterday))
                                                    };

                                                    foreach (SPListItem activeTask in agendaTaskList.GetItems(queryForActionsOwed))
                                                    {
                                                        ActionOwed action = new ActionOwed()
                                                        {
                                                            TaskID = activeTask["ID"].ToString(),
                                                            Title = activeTask["Title"].ToString(),
                                                            DueDate = DateTime.Parse(activeTask["DueDate"].ToString()),
                                                            Status = activeTask["Status"].ToString(),
                                                            OriginalAssignee = (activeTask["OriginalAssignee"] != null) ? activeTask["OriginalAssignee"].ToString() : String.Empty,
                                                            Action = (activeTask["ActionOwed"] != null) ? activeTask["ActionOwed"].ToString() : String.Empty,
                                                            Source = (activeTask["TaskSource"] != null) ? activeTask["TaskSource"].ToString() : String.Empty,
                                                            FileRef = activeTask["FileRef"].ToString(),
                                                            TaskSite = site
                                                        };
                                                        if (activeTask["IsDelegated"] == null)
                                                        {
                                                            action.IsDelegated = false;
                                                        }
                                                        else if (string.IsNullOrEmpty(activeTask["IsDelegated"].ToString()))
                                                        {
                                                            action.IsDelegated = false;
                                                        }
                                                        else if (activeTask["IsDelegated"].ToString() == "1")
                                                        {
                                                            action.IsDelegated = true;
                                                        }
                                                        else if (bool.Parse(activeTask["IsDelegated"].ToString()))
                                                        {
                                                            action.IsDelegated = true;
                                                        }

                                                        string taskRelativeLink = activeTask["FileRef"].ToString().Substring(activeTask["FileRef"].ToString().IndexOf("#") + 1, (activeTask["FileRef"].ToString().Length - activeTask["FileRef"].ToString().IndexOf("#") - 1));
                                                        action.TaskLink = taskRelativeLink;
                                                        action.AssignedTo = activeTask["AssignedTo"].ToString().Substring(activeTask["AssignedTo"].ToString().IndexOf("#") + 1, (activeTask["AssignedTo"].ToString().Length - activeTask["AssignedTo"].ToString().IndexOf("#") - 1));
                                                        actionsOwed.Add(action);
                                                    }
                                                }
                                            }
                                            catch (Exception exc)
                                            {
                                                Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: There was an error while getting data out from {0}. The error was {1}. The stack trace is {2}.", subSite.Url, exc.Message, exc.StackTrace);

                                            }
                                        }
                                    }
                                }
                            }


                        }
                    }
                }
                var sortedActionsOwed = actionsOwed.OrderBy(a => a.DueDate);
                grdActionsOwed.DataSource = sortedActionsOwed;
                grdActionsOwed.DataBind();
                /*
                foreach (string site in actionsOwedSites)
                {
                    using (SPSite emisSite = new SPSite(site))
                    {
                        using (SPWeb emisRootWeb = emisSite.OpenWeb())
                        {
                            SPSiteDataQuery query = new SPSiteDataQuery();
                            query.Lists = "<Lists ServerTemplate=\"107\" />";
                            query.ViewFields = "<FieldRef Name=\"Title\" />" +
                                "<FieldRef Name=\"ID\" />" +
                                "<FieldRef Name=\"AssignedTo\" Nullable=\"TRUE\" Type=\"User\" />" +
                                "<FieldRef Name=\"Status\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"DueDate\" Nullable=\"TRUE\" Type=\"DateTime\" />" +
                                "<FieldRef Name=\"IsDelegated\" Nullable=\"TRUE\" Type=\"Boolean\" />" +
                                "<FieldRef Name=\"OriginalAssignee\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"ActionOwed\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                 "<FieldRef Name=\"TaskSource\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"FileRef\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"Related Content\" Nullable=\"TRUE\" Type=\"Text\" />";

                            query.Query =
                                "<Where>" +
                                    "<And>" +
                                         "<Geq>" +
                                             "<FieldRef Name='Created' />" +
                                             "<Value IncludeTimeValue='FALSE' Type='DateTime'>" + SPUtility.CreateISO8601DateTimeFromSystemDateTime(yesterday) + "</Value>" +
                                         "</Geq>" +
                                         "<And>" +
                                            "<Eq>" +
                                                "<FieldRef Name='AssignedTo' />" +
                                                " <Value Type='User'><UserID/></Value>" +
                                            "</Eq>" +
                                            "<Neq>" +
                                                "<FieldRef Name='Status' />" +
                                                "<Value Type='Choice'>Completed</Value>" +
                                            "</Neq>" +
                                        "</And>" +
                                    "</And>" +
                                "</Where>" +
                                "<OrderBy>" +
                                    "<FieldRef Name=\"DueDate\" />" +
                                "</OrderBy>";

                            query.Webs = "<Webs Scope=\"SiteCollection\" />";

                            DataTable dt = emisRootWeb.GetSiteData(query);

                            
                            foreach (DataRow row in dt.Rows)
                            {
                                ActionOwed action = new ActionOwed()
                                {
                                    TaskID = row["ID"].ToString(),
                                    Title = row["Title"].ToString(),
                                    DueDate = DateTime.Parse(row["DueDate"].ToString()),
                                    Status = row["Status"].ToString(),
                                    OriginalAssignee = row["OriginalAssignee"].ToString(),
                                    Action = row["ActionOwed"].ToString(),
                                    Source = row["TaskSource"].ToString(),
                                    FileRef = row["FileRef"].ToString(),
                                    TaskSite = site
                                };
                                if (string.IsNullOrEmpty(row["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = false;
                                }
                                else if (row["IsDelegated"].ToString() == "1")
                                {
                                    action.IsDelegated = true;
                                }
                                else if (bool.Parse(row["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = true;
                                }

                                string taskRelativeLink = row["FileRef"].ToString().Substring(row["FileRef"].ToString().IndexOf("#") + 1, (row["FileRef"].ToString().Length - row["FileRef"].ToString().IndexOf("#") - 1));
                                action.TaskLink = taskRelativeLink;
                                action.AssignedTo = row["AssignedTo"].ToString().Substring(row["AssignedTo"].ToString().IndexOf("#") + 1, (row["AssignedTo"].ToString().Length - row["AssignedTo"].ToString().IndexOf("#") - 1));
                                actionsOwed.Add(action);
                            }
                            
                        }
                    }

                }
               
                grdActionsOwed.DataSource = actionsOwed;
                grdActionsOwed.DataBind();
                 *  */

            }
            else
            {
                GetAllActionsOwed(SPContext.Current.Web.CurrentUser.Name);
            }
        }

        void chkMyDelegatedTasks_CheckedChanged(object sender, EventArgs e)
        {
            chkRecentTasksOnly.Checked = false;

            InitializeWebAppProperties();

            if (chkMyDelegatedTasks.Checked)
            {
                string[] actionsOwedSites = sites.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

                List<ActionOwed> actionsOwed = new List<ActionOwed>();

                foreach (string site in actionsOwedSites)
                {
                    using (SPSite emisSite = new SPSite(site))
                    {
                        using (SPWeb emisRootWeb = emisSite.OpenWeb())
                        {
                            //Get all agendas
                            SPList baList = emisRootWeb.Lists["Board Agenda"];
                            SPQuery queryFutureAgendas = new SPQuery()
                            {
                                Query = string.Format(@"<Query>
                                                        <Where>
                                                            <Geq><FieldRef Name='MeetingDate' />
                                                                <Value IncludeTimeValue='FALSE' Type='DateTime'>{0}</Value>
                                                            </Geq>
                                                        </Where>
                                                    </Query>", SPUtility.CreateISO8601DateTimeFromSystemDateTime(DateTime.Today))
                            };

                            foreach (SPListItem futureAgenda in baList.GetItems(queryFutureAgendas))
                            {
                                if (futureAgenda["MeetingDate"] != null)
                                {
                                    if (DateTime.Parse(futureAgenda["MeetingDate"].ToString()) > DateTime.Today)
                                    {
                                        SPFieldUrlValue workspaceURLField = new SPFieldUrlValue(futureAgenda["DocumentWorkspace"].ToString());
                                        string workspaceURL = workspaceURLField.Url;

                                        if (workspaceURL.IndexOf("Shared Documents") > 0)
                                        {
                                            workspaceURL = workspaceURL.Substring(0, workspaceURL.IndexOf("Shared Documents") - 1);
                                        }

                                        string relativeWSURL = workspaceURL.Remove(0, site.Length);

                                        relativeWSURL = relativeWSURL.Replace("/", "");
                                        //Now open up the workspace
                                        using (SPWeb subSite = emisSite.OpenWeb(relativeWSURL))
                                        {
                                            try
                                            {
                                                SPList agendaTaskList = subSite.Lists["Agenda Tasks"];

                                                if (agendaTaskList != null)
                                                {
                                                    SPQuery queryForActionsOwed = new SPQuery()
                                                    {
                                                        Query = @"<Where>
                                                                   <And>
                                                                       <Eq>
                                                                           <FieldRef Name='OriginalAssignee' />
                                                                           <Value Type='User'><UserID/></Value>
                                                                       </Eq>
                                                                       <Neq>
                                                                           <FieldRef Name='Status' />
                                                                           <Value Type='Choice'>Completed</Value>
                                                                       </Neq>
                                                                   </And>
                                                               </Where>
                                                               <OrderBy>
                                                                   <FieldRef Name='DueDate'/>
                                                               </OrderBy>"
                                                    };

                                                    foreach (SPListItem activeTask in agendaTaskList.GetItems(queryForActionsOwed))
                                                    {
                                                        ActionOwed action = new ActionOwed()
                                                        {
                                                            TaskID = activeTask["ID"].ToString(),
                                                            Title = activeTask["Title"].ToString(),
                                                            DueDate = DateTime.Parse(activeTask["DueDate"].ToString()),
                                                            Status = activeTask["Status"].ToString(),
                                                            OriginalAssignee = (activeTask["OriginalAssignee"] != null) ? activeTask["OriginalAssignee"].ToString() : String.Empty,
                                                            Action = (activeTask["ActionOwed"] != null) ? activeTask["ActionOwed"].ToString() : String.Empty,
                                                            Source = (activeTask["TaskSource"] != null) ? activeTask["TaskSource"].ToString() : String.Empty,
                                                            FileRef = activeTask["FileRef"].ToString(),
                                                            TaskSite = site
                                                        };
                                                        if (activeTask["IsDelegated"] == null)
                                                        {
                                                            action.IsDelegated = false;
                                                        }
                                                        else if (string.IsNullOrEmpty(activeTask["IsDelegated"].ToString()))
                                                        {
                                                            action.IsDelegated = false;
                                                        }
                                                        else if (activeTask["IsDelegated"].ToString() == "1")
                                                        {
                                                            action.IsDelegated = true;
                                                        }
                                                        else if (bool.Parse(activeTask["IsDelegated"].ToString()))
                                                        {
                                                            action.IsDelegated = true;
                                                        }

                                                        string taskRelativeLink = activeTask["FileRef"].ToString().Substring(activeTask["FileRef"].ToString().IndexOf("#") + 1, (activeTask["FileRef"].ToString().Length - activeTask["FileRef"].ToString().IndexOf("#") - 1));
                                                        action.TaskLink = taskRelativeLink;
                                                        action.AssignedTo = activeTask["AssignedTo"].ToString().Substring(activeTask["AssignedTo"].ToString().IndexOf("#") + 1, (activeTask["AssignedTo"].ToString().Length - activeTask["AssignedTo"].ToString().IndexOf("#") - 1));
                                                        actionsOwed.Add(action);
                                                    }
                                                }
                                            }
                                            catch (Exception exc)
                                            {
                                                Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: There was an error while getting data out from {0}. The error was {1}. The stack trace is {2}.", subSite.Url, exc.Message, exc.StackTrace);

                                            }
                                        }
                                    }
                                }
                            }


                        }
                    }
                }
                var sortedActionsOwed = actionsOwed.OrderBy(a => a.DueDate);
                grdActionsOwed.DataSource = sortedActionsOwed;
                grdActionsOwed.DataBind();

                /*
                foreach (string site in actionsOwedSites)
                {
                    using (SPSite emisSite = new SPSite(site))
                    {
                        using (SPWeb emisRootWeb = emisSite.OpenWeb())
                        {
                            SPSiteDataQuery query = new SPSiteDataQuery();
                            query.Lists = "<Lists ServerTemplate=\"107\" />";
                            query.ViewFields = "<FieldRef Name=\"Title\" />" +
                                "<FieldRef Name=\"ID\" />" +
                                "<FieldRef Name=\"AssignedTo\" Nullable=\"TRUE\" Type=\"User\" />" +
                                "<FieldRef Name=\"Status\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"DueDate\" Nullable=\"TRUE\" Type=\"DateTime\" />" +
                                "<FieldRef Name=\"IsDelegated\" Nullable=\"TRUE\" Type=\"Boolean\" />" +
                                "<FieldRef Name=\"OriginalAssignee\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"ActionOwed\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                 "<FieldRef Name=\"TaskSource\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"FileRef\" Nullable=\"TRUE\" Type=\"Text\" />" +
                                "<FieldRef Name=\"Related Content\" Nullable=\"TRUE\" Type=\"Text\" />";

                            query.Query =
                                "<Where>" +
                                    "<And>" +
                                        "<Eq>" +
                                            "<FieldRef Name='OriginalAssignee' />" +
                                            " <Value Type='User'><UserID/></Value>" +
                                        "</Eq>" +
                                        "<Neq>" +
                                            "<FieldRef Name='Status' />" +
                                            "<Value Type='Choice'>Completed</Value>" +
                                        "</Neq>" +
                                    "</And>" +
                                "</Where>" +
                                "<OrderBy>" +
                                    "<FieldRef Name=\"DueDate\" />" +
                                "</OrderBy>";

                            query.Webs = "<Webs Scope=\"SiteCollection\" />";

                            DataTable dt = emisRootWeb.GetSiteData(query);

                            foreach (DataRow row in dt.Rows)
                            {
                                ActionOwed action = new ActionOwed()
                                {
                                    TaskID = row["ID"].ToString(),
                                    Title = row["Title"].ToString(),
                                    DueDate = DateTime.Parse(row["DueDate"].ToString()),
                                    Status = row["Status"].ToString(),
                                    OriginalAssignee = row["OriginalAssignee"].ToString(),
                                    Action = row["ActionOwed"].ToString(),
                                    Source = row["TaskSource"].ToString(),
                                    FileRef = row["FileRef"].ToString(),
                                    TaskSite = site
                                };
                                if (string.IsNullOrEmpty(row["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = false;
                                }
                                else if (row["IsDelegated"].ToString() == "1")
                                {
                                    action.IsDelegated = true;
                                }
                                else if (bool.Parse(row["IsDelegated"].ToString()))
                                {
                                    action.IsDelegated = true;
                                }

                                string taskRelativeLink = row["FileRef"].ToString().Substring(row["FileRef"].ToString().IndexOf("#") + 1, (row["FileRef"].ToString().Length - row["FileRef"].ToString().IndexOf("#") - 1));
                                action.TaskLink = taskRelativeLink;
                                action.AssignedTo = row["AssignedTo"].ToString().Substring(row["AssignedTo"].ToString().IndexOf("#") + 1, (row["AssignedTo"].ToString().Length - row["AssignedTo"].ToString().IndexOf("#") - 1));
                                actionsOwed.Add(action);
                            }


                            grdActionsOwed.DataSource = actionsOwed;
                            grdActionsOwed.DataBind();
                        }
                    }
                }
                */
                
            }
            else
            {
                GetAllActionsOwed(SPContext.Current.Web.CurrentUser.Name);
            }
        }

        protected void grdActionsOwed_RowComand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);

            GridViewRow row = grdActionsOwed.Rows[index];

            string TaskID = grdActionsOwed.DataKeys[index].Values[0].ToString();
            string TaskLink = grdActionsOwed.DataKeys[index].Values[1].ToString();
            string taskSite = grdActionsOwed.DataKeys[index].Values[2].ToString();

            string listRelativeLink = TaskLink.Substring(0, TaskLink.LastIndexOf("/"));
            //string webLink = listRelativeLink.Substring(0, listRelativeLink.LastIndexOf("Lists"));
            //if (webLink.IndexOf("/Agenda-") > 0)
            //{
            //    webLink = webLink.Substring(webLink.IndexOf("/Agenda-"));
            //    webLink = webLink.Replace("/", "");
            //}
            string taskURL = "";
            string taskListID = "";
            string taskContentTypeID = "";
            string relatedContentLink = "";
            InitializeWebAppProperties();

            using (SPSite site = new SPSite(taskSite))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    SPList martaTask = web.GetList(TaskLink);
                    taskListID = martaTask.ID.ToString();

                    SPQuery query = new SPQuery()
                    {
                        Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='ID' />
                                                  <Value Type='Counter'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", TaskID)
                    };

                    SPListItem task = martaTask.GetItemById(Convert.ToInt32(TaskID));
                    {
                        if (task.ContentType.Name == "Workflow Task")
                        {
                            SPFieldUrlValue relatedContent = new SPFieldUrlValue(Convert.ToString(task["Related Content"]));
                            relatedContentLink = relatedContent.Url;
                        }
                        else
                        {
                            SPFieldUrlValue relatedContent = new SPFieldUrlValue(Convert.ToString(task["RelatedInfo"]));
                            relatedContentLink = relatedContent.Url;
                        }
                       
                        taskContentTypeID = task.ContentType.Id.ToString();
                    }
                }

            }

            if (e.CommandName == "Task")
            {
                string redirectTaskURl = string.Format("{0}/_layouts/listform.aspx?PageType=6&ListID={1}&ID={2}&ContentTypeID={3}", taskSite, taskListID, TaskID, taskContentTypeID);

                Microsoft.Office.Server.Diagnostics.PortalLog.LogString("ActionsOwed WebPart: redirectTaskURl = {0}", redirectTaskURl);
                
                Page.Response.Redirect(redirectTaskURl);

               
            }
            else if (e.CommandName == "Documents")
            {
                Page.Response.Redirect(relatedContentLink);
                
            }

        }


        void grdActionsOwed_Sorting(object sender, GridViewSortEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;
            
            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                sites = webApplication.Properties["ActionsOwedSites"].ToString();
            }

        }


    }

    public class ActionOwed
    {
        public string TaskID { get; set; }

        public string Title {get; set;}

        public string AssignedTo {get; set;}

        public string Status{get;set;}

        public DateTime DueDate {get; set;}

        public string DueDateString
        {
            get { return DueDate.ToShortDateString(); }
        }

        public bool IsDelegated {get; set;}

        public string OriginalAssignee {get;set;}

        public string Action {get; set;}

        public string Source {get; set;}

        public string FileRef {get; set;}

        public string TaskLink { get; set; }

        public string RelatedContent { get; set; }

        public string TaskSite { get; set; }
    }
}
