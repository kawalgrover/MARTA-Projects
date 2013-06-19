using Microsoft.Office.Server.UserProfiles;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration.DatabaseProvider;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;
using Microsoft.SharePoint.Linq;
using Microsoft.SharePoint.Administration;

namespace MARTADelegations.Webparts.ManagerDelegation
{
    [ToolboxItemAttribute(false)]
    public partial class ManagerDelegation : WebPart
    {
        string siteURLForDelegationsList;
        List<UserProfile> directReports;

        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public ManagerDelegation()
        {
        }

        private void GetSubordinates()
        {
            SPServiceContext serviceContext = SPServiceContext.GetContext(SPContext.Current.Site);
            UserProfileManager upm = new UserProfileManager(serviceContext);

            UserProfile currentUserProfile = upm.GetUserProfile(SPContext.Current.Web.CurrentUser.LoginName);

            if (currentUserProfile != null)
            {
                directReports = currentUserProfile.GetDirectReports().ToList();

                if ((directReports != null) && (directReports.Count > 0))
                {
                    lblMessage.Text = string.Empty;
                    pnlDelegation.Visible = true;
                    foreach (UserProfile subordinate in directReports)
                    {
                        ListItem profile = new ListItem() { Text = subordinate.DisplayName, Value = subordinate.AccountName };
                        ddlSubordinates.Items.Add(profile);
                    }
                }
                else
                {
                    lblMessage.Text = "No direct reports found!";
                    pnlDelegation.Visible = false;
                }
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitializeWebAppProperties();
                GetSubordinates();
                LoadDelegations();
            }
        }

        private void LoadDelegations()
        {
            if (siteURLForDelegationsList != null)
            {
                if (directReports != null)
                {
                    using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                    {
                        SPWeb rootWeb = delegationSite.RootWeb;
                        rootWeb.AllowUnsafeUpdates = true;
                        rootWeb.Update();

                        using (DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url))
                        {
                            EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                            List<int> drUsers = new List<int>();

                            foreach (UserProfile directReport in directReports)
                            {
                                SPUser drUser = delegationSite.RootWeb.EnsureUser(directReport.AccountName);
                                drUsers.Add(drUser.ID);
                            }

                            List<Delegation> myDelegations = delegations
                                .Where(d => drUsers.Contains(d.DelegationForId.Value))
                                .ToList();

                            grdAllDelegations.DataSource = myDelegations;
                            grdAllDelegations.DataBind();
                        }

                        rootWeb.AllowUnsafeUpdates = false;
                        rootWeb.Update();
                    }
                }
            }
        }

        private void InitializeWebAppProperties()
        {
            SPWebApplication webApplication = SPContext.Current.Site.WebApplication;

            siteURLForDelegationsList = Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
        }


        void btnSubmit_Click(object sender, EventArgs e)
        {
            string siteURLForDelegationsList = Utility.GetDelegationsListSite();

            if (siteURLForDelegationsList != null)
            {

                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                {
                    DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url);
                    EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                    string selectedUser = ddlSubordinates.SelectedValue;

                    SPUser assignedToUser = SPContext.Current.Web.EnsureUser(selectedUser);

                    Delegation delegation = new Delegation()
                    {
                        DelegationFor = SPContext.Current.Web.CurrentUser.LoginName,
                        DelegationForId = SPContext.Current.Web.CurrentUser.ID,
                        StartDate = calDelegateFrom.SelectedDate,
                        EndDate = calDelegateTo.SelectedDate,
                        AssignedTo = assignedToUser.LoginName,
                        AssignedToId = assignedToUser.ID,
                        DelegationType = DelegationType.Self
                    };

                    delegations.InsertOnSubmit(delegation);

                    dc.SubmitChanges();

                }
            }

            //Set value for message
        }

        private void ResetNewDelegationPanel()
        {
            delegationID.Value = string.Empty;
            btnSubmit.Text = "Submit";
            calDelegateFrom.ClearSelection();
            calDelegateTo.ClearSelection();
        }

        private void PopulateDelegation(Delegation delegation)
        {
            delegationID.Value = delegation.Id.ToString();
            btnSubmit.Text = "Update";
            SPUser user = SPContext.Current.Web.Site.RootWeb.AllUsers.GetByID(delegation.AssignedToId.Value);

            ddlSubordinates.Items.FindByValue(user.LoginName).Selected = true;

            calDelegateFrom.SelectedDate = delegation.StartDate.Value;
            calDelegateTo.SelectedDate = delegation.EndDate.Value;
        }


        protected void btnEditDelegation_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            int delegationID = int.Parse(e.CommandArgument.ToString());

            InitializeWebAppProperties();

            if (siteURLForDelegationsList != null)
            {
                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                {
                    DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url);
                    EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                    Delegation selectedDelegation = delegations.Where(d => d.Id == delegationID).FirstOrDefault();

                    PopulateDelegation(selectedDelegation);
                }
            }
        }

        protected void btnDeleteDelegation_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            int delegationID = int.Parse(e.CommandArgument.ToString());

            InitializeWebAppProperties();

            if (siteURLForDelegationsList != null)
            {
                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                {
                    DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url);
                    EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                    Delegation selectedDelegation = delegations.Where(d => d.Id == delegationID).FirstOrDefault();

                    delegations.DeleteOnSubmit(selectedDelegation);

                    dc.SubmitChanges();
                }
            }

            LoadDelegations();
        }
    }
}
