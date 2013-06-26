using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace MARTAWebParts.ActionsOwedWebPart
{
    [ToolboxItemAttribute(false)]
    public class ActionsOwedWebPart : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/MARTAWebParts/ActionsOwedWebPart/ActionsOwedWebPartUserControl.ascx";
        protected DashboardMode dashboardMode;

        protected override void CreateChildControls()
        {
            ActionsOwedWebPartUserControl control = Page.LoadControl(_ascxPath) as ActionsOwedWebPartUserControl;

            if (control != null)
            {
                control.WebPart = this;
            }

            Controls.Add(control);

        }

        [Description("Mode of gathering for MARTA Tasks")]
        [WebBrowsable(true)]
        [Personalizable()]
        public DashboardMode Mode
        {
            get
            {
                if (dashboardMode == null)
                {
                    dashboardMode = DashboardMode.LocalSiteOnly;
                }
                return dashboardMode;
            }
            set { dashboardMode = value; }
        }

        protected void grdActionsOwed_Sorting(object sender, GridViewSortEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public enum DashboardMode
    {
        LocalSiteOnly,
        RootSiteCollectionOnly,
        RootSiteCollectionAndAllSubsites,
        SiteCollections,
        WebApplicationsAndAllSiteCollections
    }


}
