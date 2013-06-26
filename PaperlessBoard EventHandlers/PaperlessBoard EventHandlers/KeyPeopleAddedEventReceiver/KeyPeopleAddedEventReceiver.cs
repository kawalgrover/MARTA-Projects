using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Administration;

namespace PaperlessBoard_EventHandlers.KeyPeopleAddedEventReceiver
{
        
    /// <summary>
    /// List Item Events
    /// </summary>
    public class KeyPeopleAddedEventReceiver : SPItemEventReceiver
    {
        string emisSiteURL = null;
       
       /// <summary>
       /// An item was added.
       /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            Microsoft.Office.Server.Diagnostics.PortalLog.LogString("KeyPeople EventReceiver: Starting ItemAdded on keyPeople for list on {0}", properties.Web.Url);

            SPSecurity.RunWithElevatedPrivileges(delegate()
                    {
                        if (properties.ListItem["KeyPerson"] != null)
                        {
                            SPFieldUserValue keyPersonValue = new SPFieldUserValue(properties.Web.Site.RootWeb, properties.ListItem["KeyPerson"].ToString());
                            GiveUserPrivelegesToWorkspace(keyPersonValue.User, properties);
                        }
                    });
            base.ItemAdded(properties);
            Microsoft.Office.Server.Diagnostics.PortalLog.LogString("KeyPeople EventReceiver: Completing ItemAdded on keyPeople for list on {0}", properties.Web.Url);

        }

        private void GiveUserPrivelegesToWorkspace(SPUser user, SPItemEventProperties properties)
        {
            InitializeWebAppProperties(properties);
            string workspaceURL = properties.Web.ServerRelativeUrl;
            //workspaceURL = workspaceURL.Remove(0, emisSiteURL.Length);
            workspaceURL = workspaceURL.Substring(workspaceURL.IndexOf("Agenda-"));
            
            using (SPSite emisSite = new SPSite(emisSiteURL))
            {
                using (SPWeb currentWorkspace = emisSite.OpenWeb(workspaceURL))
                {
                    currentWorkspace.AllowUnsafeUpdates = true;

                    SPRoleAssignment role;

                    role = new SPRoleAssignment(currentWorkspace.EnsureUser(user.LoginName));

                    role.RoleDefinitionBindings.Add(currentWorkspace.RoleDefinitions["Restricted Contribute"]);

                    currentWorkspace.RoleAssignments.Add(role);
                    currentWorkspace.AllowUnsafeUpdates = false;
                    currentWorkspace.Update();
                }
            }
            
        }

       /// <summary>
       /// An item was updated.
       /// </summary>
       public override void ItemUpdated(SPItemEventProperties properties)
       {
           Microsoft.Office.Server.Diagnostics.PortalLog.LogString("KeyPeople EventReceiver: Starting ItemUpdated on keyPeople for list on {0}", properties.Web.Url);

           SPSecurity.RunWithElevatedPrivileges(delegate()
                    {
                        if (properties.ListItem["KeyPerson"] != null)
                        {
                            //SPFieldUserValue keyPersonValueBefore = new SPFieldUserValue(properties.Web.Site.RootWeb, properties.BeforeProperties["KeyPerson"].ToString());
                            SPFieldUserValue keyPersonValueAfter = new SPFieldUserValue(properties.Web.Site.RootWeb, properties.ListItem["KeyPerson"].ToString());
                            if (keyPersonValueAfter != null)
                            {
                                GiveUserPrivelegesToWorkspace(keyPersonValueAfter.User, properties);
                            }
                        }
                    });
           base.ItemUpdated(properties);

           Microsoft.Office.Server.Diagnostics.PortalLog.LogString("KeyPeople EventReceiver: Starting ItemUpdated on keyPeople for list on {0}", properties.Web.Url);

       }

       /// <summary>
       /// An item was deleted.
       /// </summary>
       public override void ItemDeleted(SPItemEventProperties properties)
       {
           SPSecurity.RunWithElevatedPrivileges(delegate()
                   {
                       SPFieldUserValue keyPersonValue = new SPFieldUserValue(properties.Web.Site.RootWeb, properties.ListItem["KeyPerson"].ToString());

                       properties.Web.RoleAssignments.Remove(keyPersonValue.User);
                       properties.Web.Update();
                   });

           base.ItemDeleted(properties);
       }

       private void InitializeWebAppProperties(SPItemEventProperties properties)
       {
           SPWebApplication webApplication = properties.Web.Site.WebApplication;
           if (webApplication.Properties != null && webApplication.Properties.Count > 0)
           {
               if (webApplication.Properties.ContainsKey("DefaultDocumentsLibrary"))
               {
                   emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
               }
           }
       }
    }
}
