using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace MARTABrand.CreateSite
{
    /// <summary>
    /// Web Events
    /// </summary>
    public class CreateSite : SPWebEventReceiver
    {
       /// <summary>
       /// A site was provisioned.
       /// </summary>
       public override void WebProvisioned(SPWebEventProperties properties)
       {
            SPWeb childSite = properties.Web;
            SPWeb topSite = childSite.Site.RootWeb;
            childSite.MasterUrl = topSite.MasterUrl;
            childSite.CustomMasterUrl = topSite.CustomMasterUrl;
            childSite.Update();
       }


    }
}
