using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Administration;

namespace PB_Emis.Features.PB_Board
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("31e4cefb-a201-4431-8d11-00999ad8c79b")]
    public class PB_BoardEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            //SPWebApplication myWebApplication = (properties.Feature.Parent as SPWeb).Site.WebApplication;//SPWebApplication.Lookup(new Uri("http://WebApplicationURL"));
            //if (!myWebApplication.Properties.ContainsKey("EmisSiteURL"))
            //{
            //    myWebApplication.Properties.Add("EmisSiteURL", "http://m264981");
            //}
            //if (!myWebApplication.Properties.ContainsKey("EmisWebURL"))
            //{
            //    myWebApplication.Properties.Add("EmisWebURL", "");
            //}
            //if (!myWebApplication.Properties.ContainsKey("BoardMeetingListNameOnEmis"))
            //{
            //    myWebApplication.Properties.Add("BoardMeetingListNameOnEmis", "BoardMeetings");
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

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            SPWeb web = properties.Feature.Parent as SPWeb;
            Guid fieldID_BoardCommittee = new Guid("{81601602-CE87-4220-A6C7-E58342292477}"); //Board Committee
            Guid fieldID_BoardAgenda = new Guid("{33E09F17-C8CE-4438-9750-7178584EA722}"); //Board Agenda
            Guid fieldID_Meeting = new Guid("{60B001C8-C91E-4B2B-98FC-01FC23EA9847}"); //Meeting
            Guid fieldID_MeetingDate = new Guid("{6A262E75-ADF6-4C20-A592-9E07670B2760}"); //Meeting Date
            Guid fieldID_AgendStatus = new Guid("{C315BE2D-F245-4846-A02E-1340911391AA}"); //Agenda Status
            Guid fieldID_AgendaID = new Guid("{94DDA9CB-2D56-488A-8974-EE8DDE04F864}"); //Agenda Status
            
            if (web.Fields.Contains(fieldID_BoardCommittee))
            {
                web.Fields[fieldID_BoardCommittee].Delete();
            }

            if (web.Fields.Contains(fieldID_BoardAgenda))
            {
                web.Fields[fieldID_BoardAgenda].Delete();
            }

            if (web.Fields.Contains(fieldID_Meeting))
            {
                web.Fields[fieldID_Meeting].Delete();
            }

            if (web.Fields.Contains(fieldID_MeetingDate))
            {
                web.Fields[fieldID_MeetingDate].Delete();
            }

            if (web.Fields.Contains(fieldID_AgendStatus))
            {
                web.Fields[fieldID_AgendStatus].Delete();
            }

            if (web.Fields.Contains(fieldID_AgendaID))
            {
                web.Fields[fieldID_AgendaID].Delete();
            }
        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
