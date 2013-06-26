using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace ExecutiveTaskTracking.Features.Fields
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("8a400aff-4630-4513-afea-eefa61c68f8d")]
    public class FieldsEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        //public override void FeatureActivated(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            Guid fieldID_ActionRequired = new Guid("{6A71ED76-9DFB-4D51-A8C8-A8BC97E25950}");
            Guid fieldID_DefaultDueDays = new Guid("{CD38DA47-F17A-49B0-9E3D-BB5622D69181}");
            Guid fieldID_DelegateTo = new Guid("{629C85FE-8FA6-4649-BFE8-1E095688FEA7}");
            Guid fieldID_DueDate = new Guid("{2410235D-B2AB-43DE-A4FD-F86C9F70EB97}");
            Guid fieldID_ExecutiveTaskStatus = new Guid("{474E7E8C-B16E-4D0E-AD44-0C5C86811C26}");
            Guid fieldID_HighPriority = new Guid("{FB0F91FD-6434-4483-8FB3-9A79A2594AB6}");
            Guid fieldID_TaskCoordinator = new Guid("{68A57E4A-80AE-4E0E-9F22-7F232036C210}");

            if (web.Fields.Contains(fieldID_ActionRequired))
            {
                web.Fields[fieldID_ActionRequired].Delete();
            }
            if (web.Fields.Contains(fieldID_DefaultDueDays))
            {
                web.Fields[fieldID_DefaultDueDays].Delete();
            }
            if (web.Fields.Contains(fieldID_DelegateTo))
            {
                web.Fields[fieldID_DelegateTo].Delete();
            }
            if (web.Fields.Contains(fieldID_DueDate))
            {
                web.Fields[fieldID_DueDate].Delete();
            }
            if (web.Fields.Contains(fieldID_ExecutiveTaskStatus))
            {
                web.Fields[fieldID_ExecutiveTaskStatus].Delete();
            }
            if (web.Fields.Contains(fieldID_HighPriority))
            {
                web.Fields[fieldID_HighPriority].Delete();
            }
            if (web.Fields.Contains(fieldID_TaskCoordinator))
            {
                web.Fields[fieldID_TaskCoordinator].Delete();
            }

        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
