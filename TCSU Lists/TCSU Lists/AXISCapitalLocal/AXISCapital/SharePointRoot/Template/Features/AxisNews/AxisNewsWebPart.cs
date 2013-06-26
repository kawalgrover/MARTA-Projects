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
    [Guid("147bf33c-d1bf-4050-8b46-d8861ab3ff21")]
    public class AxisNewsWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private bool _error = false;
        private string _myProperty = null;
        private string _category = null;

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
                    _myProperty = "Pages";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }

        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("My Property Group")]
        [WebDisplayName("Category")]
        [WebDescription("Meaningless Property")]
        public string Category
        {
            get
            {
                if (_category == null)
                {
                    _category = "AxisNews";
                }
                return _category;
            }
            set { _category = value; }
        }

        public AxisNewsWebPart()
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
            
            SPList list = SPContext.Current.Web.Lists[this.MyProperty];
            if (list != null)
            {
                DataSet data = CreateDataTable();
                if (data != null)
                {
                    foreach (SPListItem item in list.Items)
                    {
                        if (Convert.ToString(item["PageCategory"]) == Category)
                        {
                            DataRow row = data.Tables[0].NewRow();
                            row["title"] = item.Title;
                            row["content"] = Convert.ToString(item["Page Content"]);
                            row["imgPath"] = "/PublishingImages/" + Convert.ToString(item["ImageNameWithExtension"]);
                            row["siteUrl"] = Convert.ToString(item["EncodedAbsUrl"]);
                            row["subTitle"] = Convert.ToString(item["Description"]);
                            data.Tables[0].Rows.Add(row);
                        }
                    }

                    StringBuilder listofnews = new StringBuilder("<ul>");
                    if (data.Tables[0].Rows.Count != 0)
                    {
                        string imgPath = string.Empty; ;
                        string title = string.Empty;
                        string content = string.Empty;
                        string strurl = string.Empty;
                        string subTitle = string.Empty;
                        

                        if (data.Tables[0].Rows.Count > 4)
                        {
                            bool isFirstTime = true;
                            int counter = 0;
                            foreach (DataRow row in data.Tables[0].Rows)
                            {
                                if (isFirstTime)
                                {
                                    imgPath = Convert.ToString(row["imgPath"]);
                                    title = Convert.ToString(row["title"]);
                                    strurl = Convert.ToString(row["siteUrl"]);
                                    subTitle = Convert.ToString(row["subTitle"]);
                                    isFirstTime = false;
                                }
                                else
                                {
                                    listofnews.Append("<li><a href='" + Convert.ToString(row["siteUrl"]) + "'>" + Convert.ToString(row["title"]) + "</a></li>");
                                    if (Convert.ToString(row["content"]).Length >= 150)
                                    {
                                        content = Convert.ToString(row["content"]).Substring(0, 148);
                                    }
                                    else
                                    {
                                        content = Convert.ToString(row["content"]);
                                    }
                                }
                                counter++;
                                if (counter == 4)
                                {
                                    break;
                                }
                            }
                            


                        }
                        else
                        {
                             bool isFirstTime = true;                           
                            foreach (DataRow row in data.Tables[0].Rows)
                            {
                                if (isFirstTime)
                                {
                                    imgPath = Convert.ToString(row["imgPath"]);
                                    title = Convert.ToString(row["title"]);
                                    strurl = Convert.ToString(row["siteUrl"]);
                                    subTitle = Convert.ToString(row["subTitle"]);
                                    isFirstTime = false;
                                }
                                else
                                {
                                    listofnews.Append("<li><a href='" + Convert.ToString(row["siteUrl"]) + "'>" + Convert.ToString(row["title"]) + "</a></li>");
                                    if (Convert.ToString(row["content"]).Length >= 150)
                                    {
                                        content = Convert.ToString(row["content"]).Substring(0, 148);
                                    }
                                    else
                                    {
                                        content = Convert.ToString(row["content"]);
                                    }
                                }
                               
                            }                       


                            
                        }

                       

                        listofnews.Append("</ul>");

                        StringBuilder pagecontent = new StringBuilder("");
                        pagecontent.Append(content);
                        pagecontent.Append("...<br><br>");
                        pagecontent.Append("<a href='" + strurl + "'>Read More</a>");



                        writer.Write("<table width='100%' height='34px' cellpadding='0' cellspacing='0'><tr><td width='50%'><span class='mywebparttitle'>AXIS News</span></td><td width='50%'  align='right' valign='middle' style='padding-right:20px'><a href='Articles.aspx' style='color:#000000'>View All</a></td></tr></table>");
                       writer.Write("<table width='100%' class='axis-news'>"
                        + "<tr><td  align='left' valign='top' width='150px'><img src='" + imgPath + "' width='150' height='175'/></td>"
                        + "<td   align='left' valign='top' width='320px'><span class='axisnewstitle'>" + title + "</span><br><span class='axisnewssubtitle'>" + subTitle + "</span><br>" + pagecontent + "</td>"
                        + "<td  align='left' valign='top'>"
                        + listofnews + "</td>"
                        + "</tr></table>");

                    }
                }
            }
            else
            {
                writer.Write(this.MyProperty + " does not exist");
            }
        }
        public DataSet CreateDataTable()
        {
            DataSet data = new DataSet();
            DataTable table = new DataTable();

            DataColumn sno = new DataColumn();
            sno.ColumnName = "sno";
            sno.DataType = System.Type.GetType("System.Int32");
            sno.AutoIncrement = true;
            sno.AutoIncrementSeed = 1;
            sno.AutoIncrementStep = 1;
            table.Columns.Add(sno);

            DataColumn title = new DataColumn();
            title.ColumnName = "title";
            table.Columns.Add(title);

            DataColumn content = new DataColumn();
            content.ColumnName = "content";
            table.Columns.Add(content);

            DataColumn imgPath = new DataColumn();
            imgPath.ColumnName = "imgPath";
            table.Columns.Add(imgPath);

            DataColumn siteUrl = new DataColumn();
            siteUrl.ColumnName = "siteUrl";
            table.Columns.Add(siteUrl);

            DataColumn subTitle = new DataColumn();
            subTitle.ColumnName = "subTitle";
            table.Columns.Add("subTitle");

            data.Tables.Add(table);
            return data;

        }
    }
}
