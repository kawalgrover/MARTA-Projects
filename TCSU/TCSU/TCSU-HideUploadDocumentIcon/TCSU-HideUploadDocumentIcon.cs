using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace TCSU.TCSU_HideUploadDocumentIcon
{
    [ToolboxItemAttribute(false)]
    public class TCSU_HideUploadDocumentIcon : WebPart
    {
        protected override void CreateChildControls()
        {
            SPRibbon currentRibbon = SPRibbon.GetCurrent(this.Page);
            if (currentRibbon != null)
            {
                System.Web.UI.WebControls.Menu mnu = currentRibbon.FindControl("Ribbon.Documents.New.AddDocument.Menu") as System.Web.UI.WebControls.Menu;
                if (mnu != null)
                    mnu.Enabled = false;
            }
        }
    }
}
