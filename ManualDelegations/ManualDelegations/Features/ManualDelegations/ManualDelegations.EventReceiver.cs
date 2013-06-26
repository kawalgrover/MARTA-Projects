using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Workflow;
using System.Linq;

namespace ExecutiveTaskTracking.Features.ManualDelegations
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("21cd067a-f57e-4d93-95ea-c213a47303e2")]
    public class ManualDelegationsEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPWeb web = GetWeb(properties);

            //first, check if the Executive Tasks library already exists or not
            if (web.Lists.TryGetList("Executive Tasks") == null)
            {
                SPContentType executiveTaskContentType = web.AvailableContentTypes["Executive Task"];

                SPListTemplate listTemplate = web.ListTemplates["Document Library"];

                Guid executiveTasksLibraryGuid = web.Lists.Add("Executive Tasks", "This library contains executive tasks.", listTemplate);

                SPDocumentLibrary executiveTasksLibrary = (SPDocumentLibrary)web.Lists[executiveTasksLibraryGuid];
                
                executiveTasksLibrary.ContentTypesEnabled = true;
                
                executiveTasksLibrary.ContentTypes.Add(executiveTaskContentType);

                executiveTasksLibrary.Update();

                if (executiveTasksLibrary.ContentTypes[web.AvailableContentTypes["Document"].Name] != null)
                {
                    //executiveTasksLibrary.ContentTypes.Delete(web.AvailableContentTypes["Document"].Id);

                    SPContentType documentContentType = executiveTasksLibrary.ContentTypes["Document"];
                    documentContentType.Delete();
                    executiveTasksLibrary.Update();
                }
                executiveTasksLibrary.OnQuickLaunch = true;
                executiveTasksLibrary.Update();

                // Make sure that the MARTA Task List feature is activated. This is what is used by the Workflow.

                
                //web.Features.Add(new Guid("{cdf0191d-3253-4d14-b28a-9fe8d6b69fd4}"));

                // Associate the Workflow to the newly created Document Library.

                SPWorkflowTemplate template = null;

                foreach (SPWorkflowTemplate localwfTemplate in web.WorkflowTemplates)
                {
                    if (localwfTemplate.Name == "Executive Task Tracking Workflow") //TODO: This should come from configuration.
                    {
                        template = localwfTemplate;
                        break;
                    }
                }

                Guid historyListID = web.Lists.Add("Workflow History", "History list used by the Agenda Workflow", SPListTemplateType.WorkflowHistory);

                SPWorkflowAssociation workflowAssociation = SPWorkflowAssociation.CreateListAssociation(template, "Executive Task Tracking Workflow", web.Lists["MARTA Tasks"], web.Lists[historyListID]);
                workflowAssociation.AllowManual = true;
                workflowAssociation.AutoStartCreate = false;
                workflowAssociation.AutoStartChange = false;

                executiveTasksLibrary.WorkflowAssociations.Add(workflowAssociation);
            }

            
        }

        private static SPWeb GetWeb(SPFeatureReceiverProperties properties)
        {
            SPWeb site;
            if (properties.Feature.Parent is SPWeb)
            {
                site = ((SPWeb)properties.Feature.Parent);
            }
            else if (properties.Feature.Parent is SPSite)
            {
                site = ((SPSite)properties.Feature.Parent).RootWeb;
            }
            else
            {
                throw new Exception("Unable to retrieve SPWeb - this feature is not Site or Web-scoped.");
            }
            return site;
        }

        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        {
            //SPSecurity.RunWithElevatedPrivileges(delegate()
            //{
            //    SPSite currentSite = GetWeb(properties).Site;
            //    currentSite.AllowUnsafeUpdates = true;
            //    currentSite.Features.Add(new Guid("{3bae86a2-776d-499d-9db8-fa4cdc7884f8}"));
            //    currentSite.AllowUnsafeUpdates = false;

            //});
        }


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
