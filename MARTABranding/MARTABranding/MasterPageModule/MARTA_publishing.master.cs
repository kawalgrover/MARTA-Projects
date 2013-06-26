using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MARTABranding.MasterPageModule
{
    public class MARTA_publishing : MasterPage
    {
        protected System.Web.UI.HtmlControls.HtmlGenericControl divRibbonContainer;
        protected Label Label1;

        protected void Page_Load(object sender, EventArgs e)
        {
            //divRibbonContainer.Visible = false;
            //Label1.Text = "Hello World!";
        }
    }
}
