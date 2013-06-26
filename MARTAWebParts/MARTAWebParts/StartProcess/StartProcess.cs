using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace MARTAProcessSite.StartProcess
{
    [ToolboxItemAttribute(false)]
    public class StartProcess : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/MARTAProcessSite/StartProcess/StartProcessUserControl.ascx";
        protected string buttonText;
        protected string processStartPath;

        protected override void CreateChildControls()
        {

            StartProcessUserControl control = Page.LoadControl(_ascxPath) as StartProcessUserControl;

            if (control != null)
            {
                control.WebPart = this;
            }

            Controls.Add(control);
        }

        [Description("Button Text")]
        [WebBrowsable(true)]
        [Personalizable()]
        public string ButtonText
        {
            get
            {
                if (buttonText == null)
                {
                    buttonText = "Start Process";
                }
                return buttonText;
            }
            set { buttonText = value; }
        }


        [Description("Start Process URL")]
        [WebBrowsable(true)]
        [Personalizable()]
        public string StartProcessURL
        {
            get
            {
                return processStartPath;
            }
            set { processStartPath = value; }
        }
    }
}
