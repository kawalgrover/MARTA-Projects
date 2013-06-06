using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARTADelegations
{
    internal static class Utility
    {
        public static string GetDelegationsListSite()
        {
            SPWebApplication webApplication = SPContext.Current.Site.WebApplication;

            return Convert.ToString(webApplication.Properties["DelegationsListSiteURL"]);
        }

    }
}
