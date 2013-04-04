using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;

namespace Navigation.Features.PreRequisitesFeature
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("ec5a0a46-9038-4def-b798-003c76835ab7")]
    public class PreRequisitesFeatureEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSite parentSite = (SPSite)properties.Feature.Parent;
            SPWeb parentWeb = parentSite.RootWeb;
            //Guids for required Features that might need to be activated
            Guid sitePublishingGuid = new Guid("F6924D36-2FA8-4f0b-B16D-06B7250180FA"); //Site Publishing Feature
            Guid webPublishingGuid = new Guid("F6924D36-2FA8-4f0b-B16D-06B7250180FA"); //Web Publishing Feature
            
            //Ensure features Exist, if they do not, they will be added to the site/web to be activated.
            EnsureSiteFeatureActivated(sitePublishingGuid, parentSite);
            EnsureWebFeatureActivated(webPublishingGuid, parentSite, parentWeb);
            
        }

        /// <summary>
        /// Activates a feature scoped to Web
        /// </summary>
        /// <param name="featureGuid">The guid of the feature to activate</param>
        /// <param name="lSite">The site the web the feature will be activated in is located</param>
        /// <param name="lWeb">The web the feature will be activated in</param>
        private void EnsureWebFeatureActivated(Guid featureGuid, SPSite lSite, SPWeb lWeb)
        {
            using (SPSite site = new SPSite(lSite.ID))
            {
                using (SPWeb web = site.OpenWeb(lWeb.ID))
                {
                    site.AllowUnsafeUpdates = true;
                    web.AllowUnsafeUpdates = true;
                    SPFeature feature = null;
                    try
                    {
                        feature = web.Features[featureGuid];
                    }
                    catch
                    {
                        web.Features.Add(featureGuid, false);
                    }
                    site.AllowUnsafeUpdates = false;
                    web.AllowUnsafeUpdates = false;
                }
            }
        }

        /// <summary>
        /// Activates a feature scoped to site
        /// </summary>
        /// <param name="featureGuid">The guid of the feature to activate.</param>
        /// <param name="lSite">The site the feature will be activated in.</param>
        private void EnsureSiteFeatureActivated(Guid featureGuid, SPSite lSite)
        {
            using (SPSite site = new SPSite(lSite.ID))
            {
                site.AllowUnsafeUpdates = true;
                SPFeature feature = null;
                try
                {
                    feature = site.Features[featureGuid];
                }
                catch
                {
                    site.Features.Add(featureGuid, false);
                }
                site.AllowUnsafeUpdates = false;
            }
        }

        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


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
