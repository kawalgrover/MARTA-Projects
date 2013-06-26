using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Collections;
using Microsoft.SharePoint;


namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("f2638a4d-bd6c-409e-a6b7-6395856c1e2b")]
    public class InsuranceListWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private bool _error = false;
        private string _myProperty = null;


        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("My Property Group")]
        [WebDisplayName("MyProperty")]
        [WebDescription("List Name")]
        public string MyProperty
        {
            get
            {
                if (_myProperty == null)
                {
                    _myProperty = "Insurance";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public InsuranceListWebPart()
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
            writer.Write("<table width='100%'  cellpadding='0' cellspacing='0'><tr><td align='left'><span class='mywebparttitle'>Help Center</span></td></tr></table>");
            


        }
    }
}
