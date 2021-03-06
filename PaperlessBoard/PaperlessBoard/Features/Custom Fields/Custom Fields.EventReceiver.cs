using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;

namespace MARTA.ContentTypes.BoardMeetingDocument.Features.Custom_Fields
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("9046fe97-ba10-464a-a713-e6e1f1807b01")]
    public class Custom_FieldsEventReceiver : SPFeatureReceiver
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
            Guid fieldID_AGMOffice = new Guid("{683E1185-CAD8-48D2-B4E9-3BFF11931856}"); // AGM Office
            Guid fieldID_BoardCommittee = new Guid("{81601602-CE87-4220-A6C7-E58342292477}"); //Board Committee
            Guid fieldID_CommitteeMeeting = new Guid("{6407F7C9-06F2-43D7-9FE7-C19E6B1547E1}"); //Committee Meeting
            Guid fieldID_AgendaType = new Guid("{94110E4E-91DC-4419-A5CE-9E24AD5EB9FE}");
            Guid fieldID_VotingRequirements = new Guid("{20CD7D82-64D8-4D37-A977-BF81894A1BFF}");

            Guid fieldID_CAA_Description = new Guid("{E0ED5D79-9A5E-470D-BA22-BB03FF5AB613}");
            Guid fieldID_CAA_Contractor = new Guid("{13DBF942-92D6-4781-9BAB-FAC8AD6034BA}");
            Guid fieldID_CAA_ContractNumbers = new Guid("{A3A999A3-8CD4-4F70-8CD9-C93742B08040}");

            if (web.Fields.Contains(fieldID_AGMOffice))
            {
                web.Fields[fieldID_AGMOffice].Delete();
            }
            if (web.Fields.Contains(fieldID_BoardCommittee))
            {
                web.Fields[fieldID_BoardCommittee].Delete();
            }
            if (web.Fields.Contains(fieldID_CommitteeMeeting))
            {
                web.Fields[fieldID_CommitteeMeeting].Delete();
            }
            if (web.Fields.Contains(fieldID_AgendaType))
            {
                web.Fields[fieldID_AgendaType].Delete();
            }
            if (web.Fields.Contains(fieldID_VotingRequirements))
            {
                web.Fields[fieldID_VotingRequirements].Delete();
            }
            if (web.Fields.Contains(fieldID_CAA_Description))
            {
                web.Fields[fieldID_CAA_Description].Delete();
            }
            if (web.Fields.Contains(fieldID_CAA_Contractor))
            {
                web.Fields[fieldID_CAA_Contractor].Delete();
            }
            if (web.Fields.Contains(fieldID_CAA_ContractNumbers))
            {
                web.Fields[fieldID_CAA_ContractNumbers].Delete();
            }
        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
