using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Linq;
using Microsoft.SharePoint.WebControls;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;

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

        private void InitializeWebAppProperties()
        {
            SPWebApplication webApplication = SPContext.Current.Site.WebApplication;

            siteURLForDelegationsList = Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
         }
    }
}
