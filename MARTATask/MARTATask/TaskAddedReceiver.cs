using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARTATask
{
    public class TaskAddedReceiver : SPItemEventReceiver
    {
        string siteURLForDelegationsList;
        string delegationsListName;
        /// <summary>
        /// An item is being added.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            InitializeWebAppProperties(properties);

            if (siteURLForDelegationsList != null)
            {
                using (SPSite delegationSite = new SPSite(siteURLForDelegationsList))
                using (SPWeb delegationWeb = delegationSite.RootWeb)
                {
                    SPList delegationList = delegationWeb.Lists[delegationsListName];

                }
            }
            //Check if the item is being assigned to by legal. Legal Delegations

            //Find out the MasterAssignmentsTable
            

            //And then check to see if the person that this task is being assigned to, if someone else is delegated for him.

            
            properties.ListItem["Assigned To"] = "kg";
            properties.ListItem.Update();

            base.ItemAdding(properties);
        }

        private void InitializeWebAppProperties(SPItemEventProperties properties)
        {
            SPSite site = properties.Web.Site;
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = site.WebApplication;

            siteURLForDelegationsList = Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
            delegationsListName = Convert.ToString(webApplication.Properties["DelegationsListName"]);
        }
    }
}
