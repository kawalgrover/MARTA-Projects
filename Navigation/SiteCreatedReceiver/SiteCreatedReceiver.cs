using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace Navigation.SiteCreatedReceiver
{
    /// <summary>
    /// Web Events
    /// </summary>
    public class SiteCreatedReceiver : SPWebEventReceiver
    {
        /// <summary>
        /// A site collection was deleted.
        /// </summary>
        public override void SiteDeleted(SPWebEventProperties properties)
        {
            base.SiteDeleted(properties);
        }

        /// <summary>
        /// A site was deleted.
        /// </summary>
        public override void WebDeleted(SPWebEventProperties properties)
        {
            base.WebDeleted(properties);
        }

        /// <summary>
        /// A site was moved.
        /// </summary>
        public override void WebMoved(SPWebEventProperties properties)
        {
            base.WebMoved(properties);
        }

        /// <summary>
        /// A site was provisioned.
        /// </summary>
        public override void WebProvisioned(SPWebEventProperties properties)
        {
            base.WebProvisioned(properties);
        }


    }
}