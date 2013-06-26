using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace MARTABranding.Features.MARTA_Branding
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("6eb548b0-6735-421b-a35e-f9d3705316cb")]
    public class MARTA_BrandingEventReceiver : SPFeatureReceiver
    {
        
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWeb currentWeb = (SPWeb)properties.Feature.Parent;

            currentWeb.MasterUrl = "/_catalogs/masterpage/MARTA_publishing.master";
            currentWeb.CustomMasterUrl = "/_catalogs/masterpage/MARTA_publishing.master";
            currentWeb.Update();
        }


        
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            SPWeb currentWeb = (SPWeb)properties.Feature.Parent;

            currentWeb.MasterUrl = "/_catalogs/masterpage/v4.master";
            currentWeb.CustomMasterUrl = "/_catalogs/masterpage/v4.master";
            currentWeb.Update();
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
