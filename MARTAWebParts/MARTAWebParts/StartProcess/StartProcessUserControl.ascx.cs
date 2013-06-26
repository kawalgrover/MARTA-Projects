using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace MARTAProcessSite.StartProcess
{
    public partial class StartProcessUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnStartProcess.Text = this.WebPart.ButtonText;
            if (string.IsNullOrEmpty(this.WebPart.StartProcessURL))
            {
                lblStatusMessage.Text = "Please set the process start path in the properties";
                btnStartProcess.Enabled = false;
                return;
            }
            
        }

        public StartProcess WebPart { get; set; }
    }
}
