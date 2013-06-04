using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Linq;
using Microsoft.SharePoint.Administration.Claims;

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
                {
                    DelegationsDataContext dc = new DelegationsDataContext(delegationSite.RootWeb.Url);
                    EntityList<Delegation> delegations = dc.GetList<Delegation>("Delegations");

                    SPUser assignedToUser = GetSPUser(properties, "Assigned To");

                    Delegation delegation = delegations.FirstOrDefault();

                    var currentDelegations = delegations.Where(d => d.DelegationForId == assignedToUser.ID)
                        .Where(d => d.StartDate <= System.DateTime.Now)
                        .Where(d => d.EndDate >= System.DateTime.Now)
                        .ToList();

                    if (currentDelegations != null)
                    {
                        //If there are any valid delegations. A legal delegation takes precedence over others.
                        if (currentDelegations.Where(d => d.DelegationType == DelegationType.Legal).FirstOrDefault() != null)
                        {
                            AssignDelegation(properties, currentDelegations.Where(d => d.DelegationType == DelegationType.Legal).First());
                        }
                        else if (currentDelegations.Where(d => d.DelegationType == DelegationType.Manager).FirstOrDefault() != null)
                        {
                            AssignDelegation(properties, currentDelegations.Where(d => d.DelegationType == DelegationType.Manager).First());
                        }
                        else if (currentDelegations.Where(d => d.DelegationType == DelegationType.Self).FirstOrDefault() != null)
                        {
                            AssignDelegation(properties, currentDelegations.Where(d => d.DelegationType == DelegationType.Self).First());
                        }
                    }
                }
            }
            
            base.ItemAdding(properties);
        }

        private SPUser GetSPUser(SPItemEventProperties properties, string key)
        {
            string rawUserName = Convert.ToString(properties.AfterProperties["AssignedTo"]);

            int separatorIndex = rawUserName.IndexOf(";#");
            string claimsUserName = rawUserName.Substring(separatorIndex + 2);

            SPClaimProviderManager claimsManager = SPClaimProviderManager.Local;

            string userName = null;

            if (claimsManager != null)
            {
                userName = claimsManager.DecodeClaim(claimsUserName).Value;
            }

            return properties.Web.EnsureUser(userName);

            //SPContentType martaTaskCT = properties.Web.ContentTypes["MARTATask"];

            //SPFieldUser field = martaTaskCT.Fields[key] as SPFieldUser;

            //if (field != null)
            //{
            //    SPFieldUserValue fieldValue = field.GetFieldValue(Convert.ToString(properties.AfterProperties["AssignedTo"])) as SPFieldUserValue;
            //    if (fieldValue != null)
            //    {
            //        return fieldValue.User;
            //    }
            //}
            //return null;
        }

        private void AssignDelegation(SPItemEventProperties properties, Delegation validDelegation)
        {
            properties.AfterProperties["OriginalAssignee"] = GetSPUserValue(properties, "AssignedTo"); 
            properties.AfterProperties["AssignedTo"] = ConvertStringToUser(properties, validDelegation.AssignedTo);
            properties.AfterProperties["IsDelegated"] = true;
            properties.AfterProperties["DelegationType"] = validDelegation.DelegationType.ToString();
            
        }


        private SPFieldUserValue GetSPUserValue(SPItemEventProperties properties, string key)
        {
            SPFieldUserValue user = new SPFieldUserValue(properties.Web, Convert.ToString(properties.AfterProperties[key]));
            return user;
        }

        private SPFieldUserValue ConvertStringToUser(SPItemEventProperties properties, string userName)
        {
            SPUser user = properties.Web.EnsureUser(userName);
            SPFieldUserValue userValue = new SPFieldUserValue(properties.Web, user.ID, user.Name);
            return userValue ;
        }
        private void InitializeWebAppProperties(SPItemEventProperties properties)
        {
            SPSite site = properties.Web.Site;
            SPWebApplication webApplication = site.WebApplication;

            siteURLForDelegationsList = Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
            delegationsListName = Convert.ToString(webApplication.Properties["DelegationsListName"]);
        }
    }
}
