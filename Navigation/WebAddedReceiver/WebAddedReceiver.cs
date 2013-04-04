using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Taxonomy;
using Microsoft.SharePoint.Publishing.Navigation;
using Microsoft.SharePoint.Administration;

namespace Navigation.WebAddedReceiver
{
    /// <summary>
    /// Web Events
    /// </summary>
    public class WebAddedReceiver : SPWebEventReceiver
    {
        const string termStorePropertyKey = "MetadataNavTermStore";
        const string globalTermSetIDPropertyKey = "MetadataNavGlobalTermSetID";
        const string localTermSetIDPropertyKey = "MetadataNavLocalTermSetID";
        string termStoreName; 

        /// <summary>
        /// A site was provisioned.
        /// </summary>
        public override void WebProvisioned(SPWebEventProperties properties)
        {
            base.WebProvisioned(properties);

            SPWeb currentWeb = properties.Web;
            InitializeWebAppProperties(currentWeb);
                    
            TaxonomySession taxonomySession = new TaxonomySession(currentWeb.Site, updateCache: true);

            //Use the first Termstore object to see if Taxonomy Service is offline or missing.
            if (taxonomySession.TermStores.Count == 0)
                throw new InvalidOperationException("The Taxonomy Service is offline or missing.");

            string globalTermSetID = "Empty";
            string localTermSetID = "Empty";

            //Get the values from the property bags.
            globalTermSetID = Convert.ToString(currentWeb.Site.RootWeb.AllProperties[globalTermSetIDPropertyKey]);
            localTermSetID = Convert.ToString(currentWeb.Site.RootWeb.AllProperties[localTermSetIDPropertyKey]);

            TermStore termStore = taxonomySession.TermStores[termStoreName];

            

            TermSet globalTermSet = termStore.GetTermSet(new Guid(globalTermSetID));
            TermSet localTermSet = termStore.GetTermSet(new Guid(localTermSetID));

            Group termSetGroup = termStore.GetSiteCollectionGroup(currentWeb.Site);

            WebNavigationSettings webNavigationSettings = new WebNavigationSettings(currentWeb);
            webNavigationSettings.GlobalNavigation.Source = StandardNavigationSource.TaxonomyProvider;
            webNavigationSettings.CurrentNavigation.Source = StandardNavigationSource.TaxonomyProvider;

            webNavigationSettings.GlobalNavigation.TermStoreId = termStore.Id;
            webNavigationSettings.GlobalNavigation.TermSetId = new Guid(globalTermSetID);

            webNavigationSettings.CurrentNavigation.TermStoreId = termStore.Id;
            webNavigationSettings.CurrentNavigation.TermSetId = new Guid(localTermSetID);

            webNavigationSettings.AddNewPagesToNavigation = false;
            webNavigationSettings.CreateFriendlyUrlsForNewPages = true;

            webNavigationSettings.Update();
            currentWeb.Update();
        }


        private void InitializeWebAppProperties(SPWeb currentWeb)
        {
            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                termStoreName = Convert.ToString(webApplication.Properties["TopNavTermStore"]);
            }

        }
    }
}