using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Publishing.Navigation;
using Microsoft.SharePoint.Taxonomy;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Publishing;
using Microsoft.SharePoint.Navigation;
using Microsoft.SharePoint.Utilities;
using System.Resources;
using System.Xml;
using System.IO;

namespace Navigation.Features.MARTA_Navigation
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("66be5091-ebd7-48a5-ad6c-4ac609202b2a")]
    public class MARTA_NavigationEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.
        const string termStorePropertyKey = "MetadataNavTermStore";
        const string globalTermSetIDPropertyKey = "MetadataNavGlobalTermSetID";
        const string localTermSetIDPropertyKey = "MetadataNavLocalTermSetID";
        string termStoreName = "Shared Types Metadata Service"; //Default Value TODO: Perhaps get thsi value from Web App properties so that its not hard-coded.

        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                termStoreName = Convert.ToString(webApplication.Properties["TopNavTermStore"]);
            }

        }
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSite currentSite = properties.Feature.Parent as SPSite;

            if (currentSite != null)
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    InitializeWebAppProperties();
                    //Set the master page to be our CustomMaster page.
                    SPWeb currentWeb = currentSite.RootWeb;
                    currentWeb.AllowUnsafeUpdates = true;

                    string masterURL = currentWeb.Site.RootWeb.ServerRelativeUrl + "/_catalogs/masterpage/MasterPage/CustomMaster.master";
                    string customMasterURL = currentWeb.Site.RootWeb.ServerRelativeUrl + "/_catalogs/masterpage/MasterPage/CustomMaster.master";
                    currentWeb.MasterUrl = masterURL;
                    currentWeb.CustomMasterUrl = customMasterURL;
                    currentWeb.Update();


                    //Some templates might have subsites from start.
                    foreach (SPWeb subWeb in currentWeb.Site.RootWeb.GetSubwebsForCurrentUser())
                    {
                        ChangeMasterPage(subWeb, masterURL, customMasterURL);
                    }

                    TaxonomySession taxonomySession = new TaxonomySession(currentWeb.Site, updateCache: true);

                    //Use the first Termstore object to see if Taxonomy Service is offline or missing.
                    if (taxonomySession.TermStores.Count == 0)
                        throw new InvalidOperationException("The Taxonomy Service is offline or missing.");

                    string globalTermSetID = "Empty";
                    string localTermSetID = "Empty";

                    //Check property bag for TermSetID key and value. If it doesn't exist create it.

                    if (!currentSite.RootWeb.AllProperties.ContainsKey(globalTermSetIDPropertyKey))
                    {
                        currentSite.RootWeb.AllProperties.Add(globalTermSetIDPropertyKey, globalTermSetID);
                        currentSite.RootWeb.Update();
                    }
                    if (!currentSite.RootWeb.AllProperties.ContainsKey(localTermSetIDPropertyKey))
                    {
                        currentSite.RootWeb.AllProperties.Add(localTermSetIDPropertyKey, localTermSetID);
                        currentSite.RootWeb.Update();
                    }

                    //Get the values from the property bags.
                    globalTermSetID = Convert.ToString(currentWeb.Site.RootWeb.AllProperties[globalTermSetIDPropertyKey]);
                    localTermSetID = Convert.ToString(currentWeb.Site.RootWeb.AllProperties[localTermSetIDPropertyKey]);

                    TermStore termStore = taxonomySession.TermStores[termStoreName];

                    if (globalTermSetID == "Empty")
                    {
                        TermSet newTermSet = CreateTermSet(termStore, Guid.NewGuid(), currentWeb, TermStoreType.Global);
                        currentSite.RootWeb.AllProperties[globalTermSetIDPropertyKey] = newTermSet.Id.ToString();
                        currentSite.RootWeb.Update();
                        globalTermSetID = newTermSet.Id.ToString();

                    }
                    if (localTermSetID == "Empty")
                    {
                        TermSet newTermSet = CreateTermSet(termStore, Guid.NewGuid(), currentWeb, TermStoreType.Local);
                        currentSite.RootWeb.AllProperties[localTermSetIDPropertyKey] = newTermSet.Id.ToString();
                        currentSite.RootWeb.Update();
                        localTermSetID = newTermSet.Id.ToString();
                    }

                    TermSet globalTermSet = termStore.GetTermSet(new Guid(globalTermSetID));
                    TermSet localTermSet = termStore.GetTermSet(new Guid(localTermSetID));

                    Group termSetGroup = termStore.GetSiteCollectionGroup(currentSite);

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


                });

            }
        }

        private enum TermStoreType
        {
            Global = 10,
            Local = 20
        }

        private TermSet CreateTermSet(TermStore termStore, Guid termSetID, SPWeb currentWeb, TermStoreType tsType)
        {
            //termSet is null. Create new termSet, and set the property in the property bag.
            Group siteCollectionGroup = termStore.GetSiteCollectionGroup(currentWeb.Site);
            //Group navTermsGroup = termStore.Groups["Navigation"]; //TODO: Get this from configuration or passed in.

            string termStoreName = (tsType == TermStoreType.Global) ? string.Format("GlobalNavTSFor{0}", termSetID) : string.Format("LocalNavTSFor{0}", termSetID);
            TermSet newTermSet = siteCollectionGroup.CreateTermSet(termStoreName, termSetID);
            
            
            NavigationTermSet navTermSet = NavigationTermSet.GetAsResolvedByWeb(newTermSet, currentWeb, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);

            navTermSet.IsNavigationTermSet = true;
            navTermSet.TargetUrlForChildTerms.Value = "~site/SitePages/Home.aspx";

            //NavigationTerm term1 = navTermSet.CreateTerm("Term 1", NavigationLinkType.SimpleLink);
            //term1.SimpleLinkUrl = "http://www.bing.com/";


            uint langID = (uint) currentWeb.Locale.LCID;
            string termMap = SPUtility.GetLocalizedString("$Resources:MARTANavigation,WebTemplateTeamSiteGlobal", "MARTANavigation", langID);
            //Guid term2Guid = Guid.NewGuid();
            //NavigationTerm term2 = navTermSet.CreateTerm("Term 2", NavigationLinkType.FriendlyUrl,
            //    term2Guid);

            //NavigationTerm childTerm = term2.CreateTerm("Term 2 child", NavigationLinkType.FriendlyUrl);

            ///// Commit changes.
            //childTerm.GetTaxonomyTerm().TermStore.CommitAll();

            BuildNavTerms(navTermSet, termMap);

            termStore.CommitAll();

            return newTermSet;
            //Add this to the property bag of the web as well.
        }

        private void BuildNavTerms(NavigationTermSet navTermSet, string termMap)
        {
            XmlReader rdr = XmlReader.Create(new StringReader(termMap));
            
            XmlDocument termDoc = new XmlDocument();
            termDoc.Load(rdr);

            XmlElement root = termDoc.DocumentElement;
            foreach (XmlNode termNode in root.ChildNodes)
            {
                NavigationTerm rootTerm = CreateRootTerm(navTermSet, termNode.Attributes["Title"].Value, termNode.Attributes["URL"].Value);
                
                foreach (XmlNode childTermNode in termNode.ChildNodes)
                {
                    CreateSubTerm(rootTerm, childTermNode.Attributes["Title"].Value, childTermNode.Attributes["URL"].Value);
                }
            }
        }

        private NavigationTerm CreateRootTerm(NavigationTermSet navTermSet, string termTitle, string termURL)
        {
            NavigationTerm navTerm = navTermSet.CreateTerm(termTitle, NavigationLinkType.SimpleLink);
            navTerm.SimpleLinkUrl = termURL;
            return navTerm;
        }

        private NavigationTerm CreateSubTerm(NavigationTerm navTerm, string termTitle, string termURL)
        {
            NavigationTerm subTerm = navTerm.CreateTerm(termTitle, NavigationLinkType.SimpleLink);
            subTerm.SimpleLinkUrl = termURL;
            return navTerm;
            
        }

        private void ChangeMasterPage(SPWeb web, string masterURL, string customURL)
        {
            web.MasterUrl = masterURL;
            web.CustomMasterUrl = customURL;
            web.Update();
            web.Dispose();
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPSite currentSite = properties.Feature.Parent as SPSite;
            SPWeb currentWeb = currentSite.RootWeb;
            currentWeb.AllowUnsafeUpdates = true;

            string masterURL = currentWeb.Site.RootWeb.ServerRelativeUrl + "/_catalogs/masterpage/v4.master";
            string customMasterURL = currentWeb.Site.RootWeb.ServerRelativeUrl + "/_catalogs/masterpage/v4.master";
            currentWeb.MasterUrl = masterURL;
            currentWeb.CustomMasterUrl = customMasterURL;
            currentWeb.Update();


            //Some templates might have subsites from start.
            foreach (SPWeb subWeb in currentWeb.Site.RootWeb.GetSubwebsForCurrentUser())
            {
                ChangeMasterPage(subWeb, masterURL, customMasterURL);
            }
        }


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
