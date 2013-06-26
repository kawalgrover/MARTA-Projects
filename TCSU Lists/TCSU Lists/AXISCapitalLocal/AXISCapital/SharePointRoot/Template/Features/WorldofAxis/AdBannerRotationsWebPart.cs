using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Collections;
using System.Web.UI.HtmlControls;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint;
using System.Data;


namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("fe502435-8f61-484c-b414-b8ff4d347c59")]
    public class AdBannerRotationsWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        


        #region MemberVariables


        private string _List1;
        private string _List2;
        private string _List3;
        private string _List4;
        DataSet data;



        #endregion
      


        #region Constructors


        public AdBannerRotationsWebPart()
        {

        }

        #endregion



        #region Properties

        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName 1")]
        [WebDescription("1st List")]
        public string List1
        {
            get
            {
                if (_List1 == null)
                {
                    _List1 = "WorldOfAxisBannerImages"; //defaulting to the list
                }
                return _List1;
            }
            set { _List1 = value; }
        }


        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName 2")]
        [WebDescription("2st List")]
        public string List2
        {
            get
            {
                if (_List2 == null)
                {
                    _List2 = "Axis Insurance Menu"; //defaulting to the list
                }
                return _List2;
            }
            set { _List2 = value; }
        }


        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName 3")]
        [WebDescription("3rd List")]
        public string List3
        {
            get
            {
                if (_List3 == null)
                {
                    _List3 = "Axis Accident Menu"; //defaulting to the list
                }
                return _List3;
            }
            set { _List3 = value; }
        }



        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName 4")]
        [WebDescription("4th List")]
        public string List4
        {
            get
            {
                if (_List4 == null)
                {
                    _List4 = "Axis Reinsurance Menu"; //defaulting to the list
                }
                return _List4;
            }
            set { _List4 = value; }
        }


        #endregion



        protected override void Render(HtmlTextWriter writer)
        {
            
            SPList list = null;
            
            try
            {
                list = SPContext.Current.Web.Lists[List1];
            }
            catch (Exception ex1)
            {

                //do nothing
            }
                

            string imgPath = string.Empty;
            string imageUrls = string.Empty;
            bool isFirstTime = true;

            string colorCode = string.Empty;
            string flyTitle = string.Empty;
            string flyTitle2 = string.Empty;
            string pageUrl = string.Empty;
            

            if (list != null)
            {

                //Constructing a comma delimeted list of all the item attributes.
                foreach (SPListItem item in list.Items)
                {
                    // writer.Write("<img src='" + Convert.ToString(item["EncodedAbsUrl"]) + "' width='100px' height='100px' />" + "<br>");
                    //imgPath = Convert.ToString(item["EncodedAbsUrl"]);

                    if (isFirstTime)
                    {
                        imageUrls = "\"" + Convert.ToString(item["EncodedAbsUrl"]) + "\"";
                        colorCode = "\"" + Convert.ToString(item["ColorCode"]) + "\"";
                        flyTitle = "\"" + Convert.ToString(item["FlyTitle1"]) + "\"";
                        flyTitle2 = "\"" + Convert.ToString(item["FlyTitle2"]) + "\"";
                        pageUrl = "\"" + Convert.ToString(item["PageUrl"]) + "\"";
                        isFirstTime = false;
                    }
                    else
                    {

                        imageUrls = imageUrls + ",";
                        imgPath = Convert.ToString(item["EncodedAbsUrl"]); //ToDo: This won't get set if there is only 1 item in the list. Fix this edge case.
                        imageUrls = imageUrls + "\"" + Convert.ToString(item["EncodedAbsUrl"]) + "\"";
                        flyTitle = flyTitle + "," + "\"" + Convert.ToString(item["FlyTitle1"]) + "\"";
                        flyTitle2 = flyTitle2  + "," + "\"" + Convert.ToString(item["FlyTitle2"]) + "\"";
                        pageUrl = pageUrl + "," + "\"" + Convert.ToString(item["PageUrl"]) + "\"";
                        colorCode = colorCode + "," + "\"" + Convert.ToString(item["ColorCode"]) + "\"";
                       
                    }
                }
            }
            else
            {
                writer.Write("List 1 " + List1 + " missing!");
            }




            
            if (!string.IsNullOrEmpty(imageUrls))
            {


                string[] images = imageUrls.Split(',');
                
                if (images.Length != 0)
                {
                    writer.Write("<div id='lyrtop'><table  style='width:100%' ><tr style='height:32px;'><td style='width:250px'><span class='lblcaption'> The World of AXIS </span></td><td style='width:10px'></td><td style='width:150px'><a href='http://www.axiscapital.com' style=' border:0px' id='lnkinsurance'><img src='_layouts/images/AxisIntraBranding/button-axis-insurance.jpg' alt='' style='border:0px;' /></a></td><td style='width:10px'></td><td style='width:150px'><a href='http://www.axiscapital.com' style=' border:0px' id='lnkreinsurance'><img src='_layouts/images/AxisIntraBranding/button-axis-reinsurance.jpg' alt='' style='border:0px;' /></a></td>"
                    + "<td style='width:10px'></td><td style='width:150px'><a href='http://www.axiscapital.com' style=' border:0px' id='lnkhealth'><img src='/_layouts/images/AxisIntraBranding/button-axis-AH.jpg' style='border:0px;' /></a></td><td ></td></tr></table></div>");
                    writer.Write("<div id='lyrbanner'><img id='imgpreview' src='" + imgPath + "' alt='' /></div>");

                    writer.Write("<div id='lyrovertext' class='lyrover'>&nbsp;&nbsp;&nbsp; <span id='lblforlnktitle'>AXIS Reinsurance | Property Catastrophe</span> &nbsp;&nbsp;&nbsp;</div>");
                    writer.Write("<div id='lyroverurl' class='lyroverlink' style='background-image:url(images/orangebar.jpg)'> &nbsp;&nbsp;&nbsp; <a id='lnktoexteneralsite' href='http://www.axiscapital.com/' target='_blank' >Learn More</a> &nbsp;&nbsp;&nbsp;</div>");
                    //writer.Write("<img style='position:absolute;left:180px;top:250px; width:auto;height:auto' src='_layouts/images/AxisIntraBranding/clock.png'/>");
                   // writer.Write("<img style='position:absolute;left:840px;top:250px; width:auto;height:auto' src='_layouts/images/AxisIntraBranding/clock.png'/>");




                    ArrayList categories = new ArrayList();

                    //******************************************************************
                    //List 2

                    list = null;

                    try
                    {
                        list = SPContext.Current.Web.Lists[List2];
                    }
                    catch (Exception ex1)
                    {


                    }

                    if (list != null)
                    {



                        
                        //writer.Write("<div id='greenmenu' class='megamenu' style='border-color:#04ad52'><div class='column'><h3></h3>");
                        data = CreateDataSet();
                        int counter = 1;
                        foreach (SPListItem item in list.Items)
                        {
                            DataRow row = data.Tables[0].NewRow();
                            row["title"] = item.Title.Trim();
                            row["category"] = Convert.ToString(item["MenuCategory"]).Trim();
                            data.Tables[0].Rows.Add(row);

                            if (!categories.Contains(Convert.ToString(item["MenuCategory"]).Trim()))
                            {
                                categories.Add(Convert.ToString(item["MenuCategory"]).Trim());
                                counter++;
                            }

                        }


                        writer.Write("<div id='greenmenu' class='megamenu' style='border-color:#04ad52'>");

                        foreach (string str in categories)
                        {
                            writer.Write("<div class='column'><h3>" + str + "</h3><ul>");
                            foreach (DataRow row in data.Tables[0].Rows)
                            {

                                if (Convert.ToString(row["category"]) == str)
                                {
                                    writer.Write("<li><a href=''>" + Convert.ToString(row["title"]) + "</a></li>");
                                }
                            }
                            writer.Write("</ul></div>");
                        }
                        writer.Write("</div>");

                    } //list 2 null check
                    else
                    {
                        writer.Write("List 2 " + List2 + " missing!");
                    }

                    //*********************************************************************
                       //List 3 
                        list = null;

                        try
                        {
                            list = SPContext.Current.Web.Lists[List3];
                        }
                        catch (Exception ex1)
                        {

                        }

                        if (list != null)
                        {

                            categories = new ArrayList();
                            data = null;
                            data = CreateDataSet();

                            foreach (SPListItem item in list.Items)
                            {
                                DataRow row = data.Tables[0].NewRow();
                                row["title"] = item.Title.Trim();
                                row["category"] = Convert.ToString(item["MenuCategory"]).Trim();
                                data.Tables[0].Rows.Add(row);

                                if (!categories.Contains(Convert.ToString(item["MenuCategory"]).Trim()))
                                {
                                    categories.Add(Convert.ToString(item["MenuCategory"]).Trim());

                                }

                            }


                            writer.Write("<div id='bluemenu' class='megamenu' style='border-color:#0480c8'>");

                            foreach (string str in categories)
                            {
                                writer.Write("<div class='column'><h3>" + str + "</h3><ul>");
                                foreach (DataRow row in data.Tables[0].Rows)
                                {

                                    if (Convert.ToString(row["category"]) == str)
                                    {
                                        writer.Write("<li><a href=''>" + Convert.ToString(row["title"]) + "</a></li>");
                                    }
                                }
                                writer.Write("</ul></div>");
                            }
                            writer.Write("</div>");

                        } //list3
                        else
                        {
                            writer.Write("List 3 " + List3 + " missing!");
                        }


                    //*********************************************************
                         //list 4
                        //Constructing the accident menu
                        list = null;

                        try
                        {
                            list = SPContext.Current.Web.Lists[List4];
                        }
                        catch (Exception ex1)
                        {

                        }


                        if (list != null)
                        {

                            categories = new ArrayList();
                            data = null;
                            data = CreateDataSet();

                            foreach (SPListItem item in list.Items)
                            {
                                DataRow row = data.Tables[0].NewRow();
                                row["title"] = item.Title.Trim();
                                row["category"] = Convert.ToString(item["MenuCategory"]).Trim();
                                data.Tables[0].Rows.Add(row);

                                if (!categories.Contains(Convert.ToString(item["MenuCategory"]).Trim()))
                                {
                                    categories.Add(Convert.ToString(item["MenuCategory"]).Trim());

                                }

                            }


                            writer.Write("<div id='orangemenu' class='megamenu' style='border-color:#fab057'>");

                            foreach (string str in categories)
                            {
                                writer.Write("<div class='column'><h3>" + str + "</h3><ul>");
                                foreach (DataRow row in data.Tables[0].Rows)
                                {

                                    if (Convert.ToString(row["category"]) == str && Convert.ToString(row["title"]).Trim() != "Dummy")
                                    {
                                        writer.Write("<li><a href=''>" + Convert.ToString(row["title"]) + "</a></li>");
                                    }
                                }
                                writer.Write("</ul></div>");
                            }
                            writer.Write("</div>");


                            writer.Write("<script language='javascript' type='text/javascript'>var arr = new Array(" + imageUrls + "); imageCounter =0;"
                        + "var colors = new Array(" + colorCode + ");"
                       + "var titles = new Array(" + flyTitle + ");"
                       + "var titles2 = new Array(" + flyTitle2 + ");"
                       + "var urls = new Array(" + pageUrl + ");"
                       + "jkmegamenu.definemenu('lnkinsurance', 'greenmenu', 'mouseover');"
                       + "jkmegamenu.definemenu('lnkreinsurance', 'bluemenu', 'mouseover');"
                       + "jkmegamenu.definemenu('lnkhealth', 'orangemenu', 'mouseover');"
                       + "jQuery(document).ready(function() {"
                       + "document.getElementById('imgpreview').src = arr[imageCounter];"
                       + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                       + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                        + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];"
                        + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];"
                       + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];"
                       + "jQuery('#lyrovertext').animate({ left: '500px' }, 1500);"
                       + "jQuery('#lyroverurl').animate({ left: '650px' }, 1000);"
                       + "imageCounter = 1;"
                       + "setInterval('ChangeImages()', 10000);"
                       + "});"
                       + "function ChangeImages() {"
                       + "jQuery('#lyrovertext').css('left', '200px');"
                       + "jQuery('#lyroverurl').css('left', '200px');"
                       + "if(imageCounter < arr.length){"
                       + "document.getElementById('imgpreview').src = arr[imageCounter];"
                       + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                       + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                       + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];"
                       + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];"
                       + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];"
                       + "imageCounter++;"
                       + "}"
                       + "else {"
                       + "imageCounter = 0;"
                       + "document.getElementById('imgpreview').src = arr[imageCounter];"
                       + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                       + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                        + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];"
                       + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];"
                       + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];"
                       + "}"
                        + "jQuery('#lyrovertext').animate({ left: '500px' }, 1500);"
                       + "jQuery('#lyroverurl').animate({ left: '650px' }, 1000);"
                       + "}"
                       + "</script>");

                        } //list4 null check
                        else
                        {
                            writer.Write("List 4 " + List4 + " missing!");
                        }

                    /*
                    writer.Write("<script language='javascript' type='text/javascript'>"
                    +"var arr = new Array(" + imageUrls + "); imageCounter =0;"
                    + "var colors = new Array(" + colorCode + ");"
                    + "var titles = new Array(" + flyTitle + ");"
                    + "var titles2 = new Array(" + flyTitle2 + ");"
                    + "var urls = new Array(" + pageUrl + ");"
                   + "jkmegamenu.definemenu('lnkinsurance', 'greenmenu', 'mouseover');"
                   + "jkmegamenu.definemenu('lnkreinsurance', 'bluemenu', 'mouseover');"
                   + "jkmegamenu.definemenu('lnkhealth', 'orangemenu', 'mouseover');"
                   + "jQuery(document).ready(function() {"
                   + "document.getElementById('imgpreview').src = arr[imageCounter];"                   
                   + "imageCounter = 1;"
                   + "setInterval('ChangeImages()', 10000);"
                   + "});"
                   + "function ChangeImages() {"
                   + "if(imageCounter < arr.length){"
                   + "document.getElementById('imgpreview').src = arr[imageCounter];"                  
                   + "imageCounter++;"
                   + "}"
                   + "else {"
                   + "imageCounter = 0;"
                   + "document.getElementById('imgpreview').src = arr[imageCounter];"                   
                   + "}"                   
                   + "}"
                   + "</script>");


                    */


                    /*
                    writer.Write("<div id='lyrovertext' class='lyrover'>&nbsp;&nbsp;&nbsp; <span id='lblforlnktitle'>AXIS Reinsurance | Property Catastrophe</span> &nbsp;&nbsp;&nbsp;</div>");

                    writer.Write("<div id='lyroverurl' class='lyroverlink' style='background-image:url(images/orangebar.jpg)'> &nbsp;&nbsp;&nbsp; <a id='lnktoexteneralsite' href='http://www.google.co.in/' target='_blank' >Learn More</a> &nbsp;&nbsp;&nbsp;</div>");

                    writer.Write("<div id='greenmenu' class='megamenu' style='border-color:#04ad52'><div class='column'><h3>Web Development</h3><ul>"
                   + "<li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
   + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
   + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
   + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
   + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
   + "</ul></div>"

   + "<div class='column'>"
   + "<h3>Web Development</h3>"
   + "<ul><li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
   + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
   + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
   + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
   + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
   + "</ul></div></div>");


                    writer.Write("<div id='bluemenu' class='megamenu' style='border-color:#0480c8'><div class='column'><h3>Web Development</h3><ul>"
                        + "<li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
        + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
        + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
        + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
        + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
        + "</ul></div>"

        + "<div class='column'>"
        + "<h3>Web Development</h3>"
        + "<ul><li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
        + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
        + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
        + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
        + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
        + "</ul></div></div>");

                    writer.Write("<div id='orangemenu' class='megamenu' style='border-color:#fab057'><div class='column'><h3>Web Development</h3><ul>"
                                    + "<li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
                    + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
                    + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
                    + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
                    + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
                    + "</ul></div>"

                    + "<div class='column'>"
                    + "<h3>Web Development</h3>"
                    + "<ul><li><a href='http://www.javascriptkit.com'>JavaScript Kit</a></li>"
                    + "<li><a href='http://www.dynamicdrive.com/'>Dynamic Drive</a></li>"
                    + "<li><a href='http://www.cssdrive.com'>CSS Drive</a></li>"
                    + "<li><a href='http://www.codingforums.com'>Coding Forums</a></li>"
                    + "<li><a href='http://www.javascriptkit.com/domref/'>DOM Reference</a></li>"
                    + "</ul></div></div>");


                    
                    list = SPContext.Current.Web.Lists["AIXS Insurance Menus"];
                    writer.Write("<div id='greenmenu' class='megamenu' style='border-color:#04ad52'><div class='column'><h3></h3>");
                    if (list != null)
                    {
                        writer.Write("<ul>");
                        foreach(SPListItem item in list.Items)
                        {
                            writer.Write("<li> <a href='" + item["LinkUrl"]+ "'>" + item.Title  + "</a></li>");
                        }
                        writer.Write("</ul");
                    }
                    writer.Write("</div></div>");



                    writer.Write("<div id='bluemenu' class='megamenu' style='border-color:#0480c8'><div class='column'><h3></h3>");
                    list = SPContext.Current.Web.Lists["AXIS Reinsurance Menu"];
                    if(list != null)
                    {
                        writer.Write("<ul>");
                        foreach (SPListItem item in list.Items)
                        {
                            writer.Write("<li> <a href='" + item["LinkUrl"] + "'>" + item.Title + "</a></li>");
                        }
                        writer.Write("</ul");
                    }
                    writer.Write("</div></div>");

                    writer.Write("<div id='orangemenu' class='megamenu' style='border-color:#fab057'><div class='column'><h3></h3>");
                    list = SPContext.Current.Web.Lists["Axis Accident Menu"];
                    if (list != null)
                    {
                        writer.Write("<ul>");
                        foreach (SPListItem item in list.Items)
                        {
                            writer.Write("<li> <a href='" + item["LinkUrl"] + "'>" + item.Title + "</a></li>");
                        }
                        writer.Write("</ul");
                    }
                    writer.Write("</div></div>");

                     
             
                    
                    writer.Write("<script language='javascript' type='text/javascript'>var arr = new Array(" + imageUrls + "); imageCounter =0;"
                     + "var colors = new Array(" + colorCode + ");"
                    + "var titles = new Array(" + flyTitle + ");"
                    + "var titles2 = new Array(" + flyTitle2 + ");"
                    + "var urls = new Array(" + pageUrl + ");"
                    + "jkmegamenu.definemenu('lnkinsurance', 'greenmenu', 'mouseover');"
                    + "jkmegamenu.definemenu('lnkreinsurance', 'bluemenu', 'mouseover');"
                    + "jkmegamenu.definemenu('lnkhealth', 'orangemenu', 'mouseover');"
                    + "jQuery(document).ready(function() {"
                    + "document.getElementById('imgpreview').src = arr[imageCounter];"
                    + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                    + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                     + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];";
                    + "jQuery('#lyrovertext').animate({ left: '300px' }, 1500);"
                    + "jQuery('#lyroverurl').animate({ left: '650px' }, 1000);"
                    + "imageCounter = 1;"
                    + "setInterval('ChangeImages()', 10000);"
                    + "});"
                    + "function ChangeImages() {"
                    + "jQuery('#lyrovertext').css('left', '200px');"
                    + "jQuery('#lyroverurl').css('left', '200px');"
                    + "if(imageCounter < arr.length){"
                    + "document.getElementById('imgpreview').src = arr[imageCounter];"
                    + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                    + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                    + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];";
                    + "imageCounter++;"
                    + "}"
                    + "else {"
                    + "imageCounter = 0;"
                    + "document.getElementById('imgpreview').src = arr[imageCounter];"
                    + "jQuery('#lyrovertext').css('background-color', colors[imageCounter]);"
                    + "jQuery('#lyroverurl').css('background-color', colors[imageCounter]);"
                     + "document.getElementById('lblforlnktitle').innerText = titles[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').innerText = titles2[imageCounter];";
                    + "document.getElementById('lnktoexteneralsite').href = urls[imageCounter];";
                    + "}"
                     + "jQuery('#lyrovertext').animate({ left: '300px' }, 1500);"
                    + "jQuery('#lyroverurl').animate({ left: '650px' }, 1000);"
                    + "}"
                    + "</script>");

                    */
                }
            }
            else
            {
                writer.Write("No images in the list");
            }
           

        }
        
        
        public DataSet CreateDataSet()
        {

            data = new DataSet();
            DataTable table = new DataTable();
            DataColumn sno = new DataColumn();
            sno.ColumnName = "sno";
            sno.DataType = System.Type.GetType("System.Int32");
            sno.AutoIncrement = false;
            sno.AutoIncrementSeed = 1;
            sno.AutoIncrementStep = 1;
            table.Columns.Add(sno);

            DataColumn title = new DataColumn();
            title.ColumnName = "title";
            table.Columns.Add(title);

            DataColumn category = new DataColumn();
            category.ColumnName = "category";
            table.Columns.Add(category);
            data.Tables.Add(table);
            return data;
        }
   
    } //class

} //namespace
