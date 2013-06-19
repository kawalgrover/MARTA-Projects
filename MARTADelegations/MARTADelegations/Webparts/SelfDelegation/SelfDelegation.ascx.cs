using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Linq;
using Microsoft.SharePoint.WebControls;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MARTADelegations.SelfDelegation
{
    [ToolboxItemAttribute(false)]
    public partial class SelfDelegation : WebPart
    {
        string siteURLForDelegationsList;

        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public SelfDelegation()
        {
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
                LoadDelegations();
            }
        }

        private void ResetNewDelegationPanel()
        {
            delegationID.Value = string.Empty;
            btnSubmit.Text = "Submit";
            spPeoplePicker.Accounts.Clear();
            spPeoplePicker.Entities.Clear();
            calDelegateFrom.ClearSelection();
            calDelegateTo.ClearSelection();
        }

        private void PopulateDelegation(Delegation delegation)
        {
            delegationID.Value = delegation.Id.ToString();
            btnSubmit.Text = "Update";
            SPUser user = SPContext.Current.Web.Site.RootWeb.AllUsers.GetByID(delegation.AssignedToId.Value);

            PickerEntity entity = new PickerEntity();
            entity.Key = user.LoginName;

            ArrayList entityArrayList = new ArrayList();
            entityArrayList.Add(entity);
            spPeoplePicker.UpdateEntities(entityArrayList);
            calDelegateFrom.SelectedDate = delegation.StartDate.Value;
            calDelegateTo.SelectedDate = delegation.EndDate.Value;
        }

        private void LoadDelegations()
        {
            if (siteURLForDelegationsList != null)
            {
                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                {
                    using (DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url))
                    {
                        EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                        List<Delegation> myDelegations = delegations
                            .Where(d => d.DelegationForId == SPContext.Current.Web.CurrentUser.ID)
                            .ToList();

                        grdAllDelegations.DataSource = myDelegations;
                        grdAllDelegations.DataBind();
                    }

                }
            }
        }

        void btnSubmit_Click(object sender, EventArgs e)
        {
            InitializeWebAppProperties();

            if (siteURLForDelegationsList != null)
            {

                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                {
                    DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url);
                    EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                    string[] userValues = spPeoplePicker.CommaSeparatedAccounts.Split(',');

                    SPUser assignedToUser = SPContext.Current.Web.EnsureUser(userValues[0]);

                    Delegation delegation;

                    if (string.IsNullOrEmpty(delegationID.Value))
                    {
                        delegation = new Delegation()
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
                    }
                    else
                    {
                        delegation = delegations.Where(d => d.Id == int.Parse(delegationID.Value)).FirstOrDefault();

                        if (delegation != null)
                        {
                            delegation.StartDate = calDelegateFrom.SelectedDate;
                            delegation.EndDate = calDelegateTo.SelectedDate;
                            delegation.AssignedTo = assignedToUser.LoginName;
                            delegation.AssignedToId = assignedToUser.ID;
                            delegation.DelegationType = DelegationType.Self;
                        }
                    }

                    dc.SubmitChanges();

                }
            }

            //Reload the delegations
            LoadDelegations();
            ResetNewDelegationPanel();
        }

        private void InitializeWebAppProperties()
        {
            SPWebApplication webApplication = SPContext.Current.Site.WebApplication;

            siteURLForDelegationsList = Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
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
