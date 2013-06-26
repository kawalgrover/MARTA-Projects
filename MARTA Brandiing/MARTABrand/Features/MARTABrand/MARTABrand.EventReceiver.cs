using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Utilities;

namespace MARTABrand.Features.Feature1
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("f3db0c0e-2d75-4228-b812-8ec26b8dabd9")]
    public class MARTABrandEventReceiver : SPFeatureReceiver
    {
        protected string customizedMasterUrl = "/_catalogs/masterpage/MARTABrand.master";
        protected string previewImageName = "/_layouts/images/MARTA/mymarta-logo.png";
        protected string defaultMasterUrl = "/_catalogs/masterpage/v4.master";
        protected string customizedThemeUrl = "/_catalogs/themes/MARTA/MyMARTATheme.thmx";
        
        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            SPSite site = properties.Feature.Parent as SPSite;
            if (site == null)
                return;

            SPWeb rootWeb = site.RootWeb;
            string WebAppRelativePath = rootWeb.ServerRelativeUrl;
            if (WebAppRelativePath != "/")
            {
                rootWeb.AllProperties["OldMasterUrl"] = WebAppRelativePath + defaultMasterUrl;
                rootWeb.AllProperties["OldCustomMasterUrl"] = WebAppRelativePath + defaultMasterUrl;
                rootWeb.MasterUrl = WebAppRelativePath + customizedMasterUrl;
                rootWeb.CustomMasterUrl = WebAppRelativePath + customizedMasterUrl;
                rootWeb.Update();
            }
            else
            {
                rootWeb.AllProperties["OldMasterUrl"] = defaultMasterUrl;
                rootWeb.AllProperties["OldCustomMasterUrl"] = defaultMasterUrl;
                rootWeb.MasterUrl = customizedMasterUrl;
                rootWeb.CustomMasterUrl = customizedMasterUrl;
                rootWeb.Update();
            }

            //using (SPWeb spweb = site.OpenWeb())
            //{
            //    ThmxTheme theme = ThmxTheme.Open(site, "_catalogs/theme/Berry.thmx");
            //    theme.ApplyTo(spweb, false);
            //    spweb.Update();
            //}
            

            foreach (SPWeb subWeb in rootWeb.Webs)
            {
                ProcessSubWebs(subWeb, true);
            }

            

        }

        private void ProcessSubWebs(SPWeb web, bool isActivation)
        {
            if (isActivation)
            {
                if (web.ServerRelativeUrl != "/")
                {
                    web.AllProperties["OldMasterUrl"] = web.ServerRelativeUrl + web.MasterUrl;
                    web.AllProperties["OldCustomMasterUrl"] = web.ServerRelativeUrl + web.CustomMasterUrl;
                    web.MasterUrl = web.Site.RootWeb.MasterUrl;
                    web.CustomMasterUrl = web.Site.RootWeb.MasterUrl;
                }
                else
                {
                    web.AllProperties["OldMasterUrl"] = web.MasterUrl;
                    web.AllProperties["OldCustomMasterUrl"] = web.CustomMasterUrl;
                    web.MasterUrl = web.Site.RootWeb.MasterUrl;
                    web.CustomMasterUrl = web.Site.RootWeb.MasterUrl;
                }
            }
            else
            {
                DeactivateWeb(web);
            }
            web.Update();

            foreach (SPWeb subWeb in web.Webs)
            {
                ProcessSubWebs(subWeb, isActivation);
            }
        }
        
        public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        {
            //System.Diagnostics.Debugger.Break();

            SPSite site = properties.Feature.Parent as SPSite;
            if (site == null)
                return;

            SPWeb rootWeb = site.RootWeb;
            string WebAppRelativePath = rootWeb.ServerRelativeUrl;

            DeactivateWeb(rootWeb);
            rootWeb.Update();

            foreach (SPWeb subWeb in rootWeb.Webs)
            {
                ProcessSubWebs(subWeb, false);
            }

            if (rootWeb.MasterUrl != WebAppRelativePath + customizedMasterUrl)
            {
                try
                {
                    bool fileExists = false;

                    if (WebAppRelativePath != "/")
                    {
                        fileExists = rootWeb.GetFile(WebAppRelativePath + customizedMasterUrl).Exists;
                        SPFile file = rootWeb.GetFile(WebAppRelativePath + customizedMasterUrl);
                        SPFolder masterPageGallery = file.ParentFolder;

                        SPFolder temp = masterPageGallery.SubFolders.Add("Temp");
                        file.MoveTo(temp.Url + "/" + file.Name);
                        temp.Delete();
                    }
                    else
                    {
                        fileExists = rootWeb.GetFile(customizedMasterUrl).Exists;
                        SPFile file = rootWeb.GetFile(customizedMasterUrl);
                        SPFolder masterPageGallery = file.ParentFolder;

                        SPFolder temp = masterPageGallery.SubFolders.Add("Temp");
                        file.MoveTo(temp.Url + "/" + file.Name);
                        temp.Delete();
                    }

                    //fileExists = masterPageGallery.SubFolders["Preview Images"].SubFolders["Custom"].Exists;
                    //SPFolder customFolder = masterPageGallery.SubFolders["Preview Images"].SubFolders["Custom"];
                    //if (customFolder.Files.Count == 1 && customFolder.Files[0].Name == previewImageName)
                    //{
                    //    masterPageGallery.SubFolders[" "].SubFolders["Custom"].Delete();
                    //}
                    //else if (customFolder.Files.Count > 1 && customFolder.Files[previewImageName].Exists)
                    //{
                    //    customFolder.Files[previewImageName].Delete();
                    //}
                }
                catch (ArgumentException)
                {
                    return;
                }
            }
        }

        private void DeactivateWeb(SPWeb web)
        {
            if (web.AllProperties.ContainsKey("OldMasterUrl"))
            {
                string oldMasterUrl = web.AllProperties["OldMasterUrl"].ToString();
                try
                {
                    bool fileExists = web.GetFile(oldMasterUrl).Exists;

                    if(fileExists)
                        web.MasterUrl = oldMasterUrl;
                    else
                        web.MasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                }
                catch (ArgumentException)
                {
                    web.MasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                }

                string oldCustomUrl = web.AllProperties["OldCustomMasterUrl"].ToString();
                try
                {
                    bool fileExists = web.GetFile(oldCustomUrl).Exists;
                    if (fileExists)
                        web.CustomMasterUrl = web.AllProperties["OldCustomMasterUrl"].ToString();
                    else
                        web.CustomMasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                }
                catch (ArgumentException)
                {
                    web.CustomMasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                }

                web.AllProperties.Remove("OldMasterUrl");
                web.AllProperties.Remove("OldCustomMasterUrl");
            }
            else
            {
                if (web.ServerRelativeUrl.Equals("/"))
                {
                    web.MasterUrl = defaultMasterUrl;
                    web.CustomMasterUrl = defaultMasterUrl;
                }
                else
                {
                    web.MasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                    web.CustomMasterUrl = web.ServerRelativeUrl + defaultMasterUrl;
                }
            }
        }

        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //    SPSite site = properties.Feature.Parent as SPSite;
        //    {
        //        site.Features.Add(properties.Feature.DefinitionId);
        //    }
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        {
            Guid featureId = properties.Definition.Id;

            //  Create web service  
            SPWebService webService = SPFarm.Local.Services.GetValue<SPWebService>("");

            //  Deactivate all feature instances at Site or Web scope  
            foreach (SPWebApplication webapp in webService.WebApplications)
            {
                foreach (SPSite site in webapp.Sites)
                {
                    if (properties.Definition.Scope == SPFeatureScope.Site)
                    {
                        site.Features.Remove(featureId, true);

                        SPWeb rootWeb = site.RootWeb;
                        string WebAppRelativePath = rootWeb.ServerRelativeUrl;
                        if (WebAppRelativePath != "/")
                        {
                            rootWeb.MasterUrl = WebAppRelativePath + defaultMasterUrl;
                            rootWeb.CustomMasterUrl = WebAppRelativePath + defaultMasterUrl;
                            rootWeb.Update();
                        }
                        else
                        {
                            rootWeb.MasterUrl = defaultMasterUrl;
                            rootWeb.CustomMasterUrl = defaultMasterUrl;
                            rootWeb.Update();
                        }
                    }

                    foreach (SPWeb web in site.RootWeb.Webs)
                    {
                        if (properties.Definition.Scope == SPFeatureScope.Web)
                            web.Features.Remove(featureId, true);

                        string WebAppRelativePath = web.ServerRelativeUrl;
                        if (WebAppRelativePath != "/")
                        {
                            web.MasterUrl = WebAppRelativePath + defaultMasterUrl;
                            web.CustomMasterUrl = WebAppRelativePath + defaultMasterUrl;
                            web.Update();
                        }
                        else
                        {
                            web.MasterUrl = defaultMasterUrl;
                            web.CustomMasterUrl = defaultMasterUrl;
                            web.Update();
                        }

                        web.Dispose();
                    }

                    site.Dispose();
                }
            }  
        }

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
