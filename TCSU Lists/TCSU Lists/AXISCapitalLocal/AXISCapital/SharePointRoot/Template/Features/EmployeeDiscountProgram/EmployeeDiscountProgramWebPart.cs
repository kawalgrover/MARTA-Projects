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
    [Guid("26d84ac1-8d70-41b6-baa4-8db07a004b00")]
    public class EmployeeDiscountProgramWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private bool _error = false;
        private string _myProperty = null;


        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("My Property Group")]
        [WebDisplayName("MyProperty")]
        [WebDescription("Meaningless Property")]
        public string MyProperty
        {
            get
            {
                if (_myProperty == null)
                {
                    _myProperty = "Employee Discount Program";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public EmployeeDiscountProgramWebPart()
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

        protected override void Render(HtmlTextWriter writer)
        {
            try
            {
                writer.Write("<hr  class='hrdbar' />");
                SPList list = SPContext.Current.Web.Lists[this.MyProperty];
                writer.Write("<table width='100%' height='20px' cellpadding='0' cellspacing='0'><tr><td align='left'  width='100%'><span class='mywebparttitle'>Employee Discount Program</span></td></tr></table>");
                if (list != null)
                {
                    writer.Write("<ul class='rightsideul'>");
                    foreach (SPListItem item in list.Items)
                    {
                        writer.Write("<li class='rightsideli'><a href='" + Convert.ToString(item["PageLink"]) + "' target='_blank'>" + item.Title + "</a></li>");
                    }
                    writer.Write("</ul>");

                }
                else
                {
                    writer.Write("List "+  this.MyProperty + " does not exist");
                }
            }
            catch (Exception exc)
            {

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
    }
}
