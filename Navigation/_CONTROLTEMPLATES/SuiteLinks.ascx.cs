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

                #region oldCode
                //if (topNavTermStoreSiteURL != null)
                //{
                //    using (SPSite site = new SPSite(topNavTermStoreSiteURL))
                //    {
                //        using (SPWeb web = site.OpenWeb())
                //        {
                //            TaxonomySession taxonomySession = new TaxonomySession(site, updateCache: true);

                //            /// Use the first TermStore object in the list.
                //            if (taxonomySession.TermStores.Count == 0)
                //                throw new InvalidOperationException("The Taxonomy Service is offline or missing");

                //            TermStore termStore = taxonomySession.TermStores["Shared Types Metadata Service"]; //TODO: Make this configurable
                //            TermSet topNavTermSet = termStore.GetTermSet(termSetID);

                //            TermCollection topNavTerms = topNavTermSet.GetAllTerms();

                //            MenuItemCollection menuItems = new MenuItemCollection();

                //            foreach (Term navTerm in topNavTerms)
                //            {

                //                MenuItem menuItem = new MenuItem() { Text = navTerm.Name, NavigateUrl = navTerm.LocalCustomProperties["_Sys_Nav_SimpleLinkUrl"] };
                //                menuItems.Add(menuItem);
                //            }

                //            mnuSuiteBar.DataSource = topNavTerms;
                //            mnuSuiteBar.DataBind();
                //        }
                //    }
                //}
                #endregion

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
                topNavTermStoreSiteURL = Convert.ToString(webApplication.Properties["TopNavTermStoreSite"]);
                termSetID = new Guid(Convert.ToString(webApplication.Properties["TermSetID"]));
            }

        }
    }
}
