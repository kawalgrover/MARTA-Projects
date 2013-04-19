using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Taxonomy;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Navigation.CONTROLTEMPLATES
{
    public partial class SuiteLinks : UserControl
    {
        string topNavTermStoreSiteURL;
        Guid termSetID;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            InitializeWebAppProperties();
            
            HtmlGenericControl oScript = new HtmlGenericControl("script");
            oScript.Attributes.Add("type", "text/javascript");
            oScript.InnerHtml = string.Format("Mavention.GlobalNavigation.init('{0}', '{1}')", topNavTermStoreSiteURL, termSetID);

            InitTopNavPlaceHolder.Controls.Add(oScript);

                
        }

        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                topNavTermStoreSiteURL = Convert.ToString(webApplication.Properties["TopNavTermStore"]);
                termSetID = new Guid(Convert.ToString(webApplication.Properties["TermSetID"]));

                
            }

        }
    }
}
