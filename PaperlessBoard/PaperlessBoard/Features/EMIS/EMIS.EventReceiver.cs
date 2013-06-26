using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Administration;

namespace MARTA.PaperlessBoard.Features.List_Definitions
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("23d07b2d-d419-49d9-8f4c-ac4e10410b84")]
    public class List_DefinitionsEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            //SPWebApplication myWebApplication = (properties.Feature.Parent as SPWeb).Site.WebApplication;//SPWebApplication.Lookup(new Uri("http://WebApplicationURL"));
            //if (!myWebApplication.Properties.ContainsKey("DefaultDocumentsLibrary"))
            //{
            //    myWebApplication.Properties.Add("DefaultDocumentsLibrary", "Default Documents");
            //}
            //if (!myWebApplication.Properties.ContainsKey("LibraryNameInDocumentWorkspace"))
            //{
            //    myWebApplication.Properties.Add("LibraryNameInDocumentWorkspace", "Shared Documents");
            //}
            //if (!myWebApplication.Properties.ContainsKey("BoardSiteURL"))
            //{
            //    myWebApplication.Properties.Add("BoardSiteURL", "http://m264981:1411");
            //}
            //if (!myWebApplication.Properties.ContainsKey("BoardMeetingListName"))
            //{
            //    myWebApplication.Properties.Add("BoardMeetingListName", "Board Meeting");
            //}
            //if (!myWebApplication.Properties.ContainsKey("LookAheadListName"))
            //{
            //    myWebApplication.Properties.Add("LookAheadListName", "Agenda Summary");
            //}
            //if (!myWebApplication.Properties.ContainsKey("EmisSiteRelativeURL"))
            //{
            //    myWebApplication.Properties.Add("EmisSiteRelativeURL", "");
            //}
            //if (!myWebApplication.Properties.ContainsKey("EmisSiteURL"))
            //{
            //    myWebApplication.Properties.Add("EmisSiteURL", "http://m264981");
            //}
            //myWebApplication.Update();
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
