using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System.Web.UI.HtmlControls;

namespace MARTABranding.ControlTemplates.MARTABranding
{
    public partial class MartaGlobalNavigation : UserControl
    {
        public string globalNavSiteName;
        public string globalNavListName;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitializeWebAppProperties();
                using (SPSite navSite = new SPSite(globalNavSiteName))
                {
                    using (SPWeb navWeb = navSite.OpenWeb())
                    {
                        SPList navList = navWeb.Lists[globalNavListName];

                        foreach (SPListItem navLink in navList.Items)
                        {
                            HtmlGenericControl newLink = new HtmlGenericControl("li");
                            SPFieldUrlValue link =  new SPFieldUrlValue(Convert.ToString(navLink["URL"]));
                            HtmlGenericControl newAnchor = new HtmlGenericControl("a");
                            newAnchor.InnerText = link.Description;
                            newAnchor.Attributes.Add("href", link.Url);
                            newLink.Controls.Add(newAnchor);

                            martaGlobalNav.Controls.Add(newLink);
                        }
                    }
                }
            }
        }


        private void InitializeWebAppProperties()
        {
            SPWeb currentWeb = SPContext.Current.Web;

            SPWebApplication webApplication = currentWeb.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                globalNavSiteName = webApplication.Properties["GlobalNavSiteName"].ToString();
                globalNavListName = webApplication.Properties["GlobalNavListName"].ToString();
            }
        }
    }
}
