using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Utilities;
using System.Collections.ObjectModel;

namespace MARTABrand
{
    public class MARTAMasterSF : System.Web.UI.MasterPage
    {
       protected Label Label2;

       protected void Page_Load(object sender, EventArgs e)
        {
            //SPSecurity.RunWithElevatedPrivileges(delegate()
            // {
            //     using (SPSite oSiteCollection = new SPSite(SPContext.Current.Site.ID))
            //     {
            //         SPWebCollection collWebsite = oSiteCollection.AllWebs;
            //         Label2.Text = "<ul>";
            //         for (int i = 0; i < collWebsite.Count; i++)
            //         {
            //             if(!collWebsite[i].IsRootWeb)
            //                Label2.Text += "<li><a href='" + collWebsite[i].Url + "'>" + SPEncode.HtmlEncode(collWebsite[i].Title) + "</a></li>";
            //         }
            //         Label2.Text += "</ul>";

            //         //using (SPWeb spweb = oSiteCollection.OpenWeb())
            //         //{
            //         //    try
            //         //    {
            //         //        spweb.AllowUnsafeUpdates = true;
            //         //        //oSiteCollection.AllowUnsafeUpdates = true;

            //         //        //ThmxTheme theme = ThmxTheme.Open(oSiteCollection, "_catalogs/theme/Berry.thmx");
            //         //        //theme.ApplyTo(spweb, true);
            //         //        spweb.Update();
            //         //        ThmxTheme.SetThemeUrlForWeb(spweb, null);
            //         //    }
            //         //    finally
            //         //    {
            //         //        spweb.AllowUnsafeUpdates = false;
            //         //        oSiteCollection.AllowUnsafeUpdates = false;
            //         //    }
            //         //}

            //            //bool currentSetting = SPContext.Current.Web.AllowUnsafeUpdates; 
            //            //SPContext.Current.Web.AllowUnsafeUpdates = true;

            //            //SPSite site = SPContext.Current.Site; // or whatever way you get the SPSite instance  
            //            //SPWeb web = site.OpenWeb(); // or whatever way you get the SP web instance 
            //            //ThmxTheme.SetThemeUrlForWeb(web, null, true);
            //            //web.Update();
 
            //            //SPContext.Current.Web.AllowUnsafeUpdates = currentSetting; 

                     
            //     }
            // });
        }
    }
}
