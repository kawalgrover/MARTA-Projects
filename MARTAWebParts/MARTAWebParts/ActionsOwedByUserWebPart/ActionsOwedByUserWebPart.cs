using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace MARTAWebParts.ActionsOwedByUserWebPart
{
    [ToolboxItemAttribute(false)]
    public class ActionsOwedByUserWebPart : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/MARTAWebParts/ActionsOwedByUserWebPart/ActionsOwedByUserWebPartUserControl.ascx";
        private string namesOfUsers = null;

        protected override void CreateChildControls()
        {
            ActionsOwedByUserWebPartUserControl control = Page.LoadControl(_ascxPath) as ActionsOwedByUserWebPartUserControl;

            if (control != null)
            {
                control.WebPart = this;
            }

            Controls.Add(control);
        }

        [Description("Enter name in the format(LastName, FirstName) of users (separated by ;)")]
        [WebBrowsable(true)]
        [Personalizable()]
        public string NamesOfUsers
        {
            get
            {
                if (namesOfUsers == null)
                {
                    namesOfUsers = String.Empty;
                }
                return namesOfUsers;
            }
            set { namesOfUsers = value; }
        }
    }
}
