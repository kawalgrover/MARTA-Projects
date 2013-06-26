using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebPartPages;
using System.Collections;
using System.Text;
using System.Data;

namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("14c8663a-a707-4cdb-a110-269dbd3af725")]
    public class NewscenterWebPart : Microsoft.SharePoint.WebPartPages.WebPart
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
                    _myProperty = "News Center";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public NewscenterWebPart()
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
                 writer.Write("<table width='100%' border='0' cellspacing='0' cellpadding='0'><tr><td class='mywebparttitle'>News Center</td></tr></table>");


                 foreach (SPListItem item in list.Items)
                 {
                     try
                     {

                         DataSet data = new DataSet();
                         data.ReadXml(Convert.ToString(item["PageUrl"]));
                         writer.Write("<table width='100%' border='0' cellspacing='0'  cellpadding='0'><tr><td class='newscentercategory'>" + item.Title + "</td></tr>");
                         int count = 1;
                         foreach (DataRow row in data.Tables["item"].Rows)
                         {
                             if (count <= 3)
                             {
                                 string title = Convert.ToString(row["title"]);
                                 string description = Convert.ToString(row["description"]);
                                 string link = Convert.ToString(row["link"]);

                                 string content = string.Empty;
                                 if (description.Length > 100)
                                 {
                                     content = description.Substring(0, 99) + "....";
                                 }
                                 else
                                 {
                                     content = description;
                                 }

                                 DateTime pubdate = DateTime.Parse(Convert.ToString(row["pubDate"]));

                                 writer.Write("<tr><td class='newscentertitle'><a href='" + link + "'>" + title + "</a> <span>" + pubdate.ToString("MMMM") + " " + pubdate.ToString("dd") + ", " + pubdate.ToString("yyyy") + "</span></td></tr>"
                                 + "<tr><td class='newscenterdesc'>" + content + "</td></tr>");
                             }
                             count++;
                             
                         }
                         writer.Write("<tr><td class='newscenterbar'><hr/></td></tr></table>");
                     }
                     catch (Exception exc)
                     {
                         writer.Write("<h1>" + exc.Message + "</h1>");
                     }
                 }
             }
             else
             {
                 writer.Write("The list " + this.MyProperty + " does not exist");
             }
        }
    }
}
