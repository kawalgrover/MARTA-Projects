using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebPartPages;
using System.Collections;
using System.Text;


namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("b53ee5b4-d340-4c01-8c7d-5d133638e717")]
    public class AxisLinksWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private bool _error = false;
        private string _myProperty = null;


        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName")]
        [WebDescription("The name of the list containing links")]
        public string MyProperty
        {
            get
            {
                if (_myProperty == null)
                {
                    _myProperty = "Axis Links"; //defaulting to the list
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public AxisLinksWebPart()
        {
            this.ExportMode = WebPartExportMode.All;
        }

        /// <summary>
        /// Create all your controls here for rendering.
        /// Try to avoid using the RenderWebPart() method.
        /// </summary>
        protected override void CreateChildControls()
        {
            if (!_error)
            {
                try
                {

                    base.CreateChildControls();

                    // Your code here...
                    this.Controls.Add(new LiteralControl(this.MyProperty));
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }

        /// <summary>
        /// Ensures that the CreateChildControls() is called before events.
        /// Use CreateChildControls() to create your controls.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            if (!_error)
            {
                try
                {
                    base.OnLoad(e);
                    this.EnsureChildControls();

                    // Your code here...
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }

        /// <summary>
        /// Clear all child controls and add an error message for display.
        /// </summary>
        /// <param name="ex"></param>
        private void HandleException(Exception ex)
        {
            this._error = true;
            this.Controls.Clear();
            this.Controls.Add(new LiteralControl(ex.Message));
        }
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("<hr  class='hrdbar' />");
            SPList list = SPContext.Current.Web.Lists[MyProperty];

            if (list != null)
            {
                writer.Write("<table width='100%' height='20px' cellpadding='0' cellspacing='0'><tr><td align='left'  width='100%'><span class='mywebparttitle'>Axis Links</span></td></tr></table><ul class='rightsideul'>");                
                foreach (SPListItem item in list.Items)
                {
                    string[] arr = Convert.ToString(item["URL"]).Split(',');

                    writer.Write("<li class='rightsideli'><a href='" + arr[0] + "' target='_blank'>" + Convert.ToString(item["UrlTitle"]) + "</a></li>");
                }
                writer.Write("</ul>");
            }
            else
            {
                writer.Write("List " + MyProperty + " doesn't exists");
            }

        } //Render

    } //class

} //namespace
