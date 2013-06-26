using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace MARTASharedTypes.Features.Fields
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("d62a215d-65d5-4ebe-a98f-11f82fa3de27")]
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
            Guid fieldID_ActionOwed = new Guid("{605EDB7C-2CCA-4875-A6C5-AF6E190FA3AF}"); // ActionOwed
            Guid fieldID_IsDelegated = new Guid("{4953D6C5-4997-4510-AB00-7A1243933FF1}"); //IsDelegated
            Guid fieldID_OriginalAssignee = new Guid("{B59D9889-B4F6-46BB-ABC4-75E34B06EAF6}"); //Original Assignee
            Guid fieldID_DelegateDueDate = new Guid("{179836E0-2916-49DA-8734-0D1297E2BC03}"); //DelegateDueDate
            Guid fieldID_TaskSource = new Guid("{E1ABA978-D44A-4600-A6E0-D4F3C4FEE7A4}"); //TaskSource
            Guid fieldID_RelatedInfo = new Guid("{761C8B12-4187-4278-8772-6FF13A09B2E9}"); //RelatedInfo

            if (web.Fields.Contains(fieldID_ActionOwed))
            {
                web.Fields[fieldID_ActionOwed].Delete();
            }
            if (web.Fields.Contains(fieldID_IsDelegated))
            {
                web.Fields[fieldID_IsDelegated].Delete();
            }
            if (web.Fields.Contains(fieldID_OriginalAssignee))
            {
                web.Fields[fieldID_OriginalAssignee].Delete();
            }
            if (web.Fields.Contains(fieldID_DelegateDueDate))
            {
                web.Fields[fieldID_DelegateDueDate].Delete();
            }
            if (web.Fields.Contains(fieldID_TaskSource))
            {
                web.Fields[fieldID_TaskSource].Delete();
            }
            if (web.Fields.Contains(fieldID_RelatedInfo))
            {
                web.Fields[fieldID_RelatedInfo].Delete();
            }
        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
