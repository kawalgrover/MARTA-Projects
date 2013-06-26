using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Text;
using System.Collections;
using System.Web.UI.HtmlControls;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint;
using System.Data;
using System.Web.UI.WebControls;

namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("ed01395f-a5d4-4f83-bac3-4b4ff3ec3115")]
    public class WeatherReportWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private DropDownList drpwmeasurement = new DropDownList();
        protected DropDownList drpweatherlocations = new DropDownList();
        HtmlGenericControl gc;

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
                    _myProperty = "Locations"; //defaulting to the list
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }

        public WeatherReportWebPart()
        {
            this.ExportMode = WebPartExportMode.All;
        }

        protected override void OnInit(EventArgs e)
        {
            try
            {


                ArrayList arr = new ArrayList();
                arr.Add("F");
                arr.Add("C");
                foreach (string st in arr)
                {
                    ListItem item = new ListItem();
                    item.Text = st;
                    item.Value = st.ToLower();
                    drpwmeasurement.Items.Add(item);
                }

                drpwmeasurement.SelectedIndexChanged += new EventHandler(drpwmeasurement_SelectedIndexChanged);
                drpwmeasurement.AutoPostBack = true;
                drpwmeasurement.ID = "drpwmeasurement";



                SPList list = SPContext.Current.Web.Lists[this.MyProperty];
                if (list != null)
                {
                    foreach (SPListItem im in list.Items)
                    {
                        ListItem item = new ListItem();
                        item.Text = Convert.ToString(im["locname"]);
                        item.Value = Convert.ToString(im["zipcode"]);
                        drpweatherlocations.Items.Add(item);
                    }
                }
                drpweatherlocations.ID = "drpweatherlocations";
                drpweatherlocations.Attributes["class"] = "clsgeocodes";
                drpweatherlocations.AutoPostBack = true;
                drpweatherlocations.SelectedIndexChanged += new EventHandler(drpweatherlocations_SelectedIndexChanged);
            }
            catch (Exception exc)
            {
               
            }
        }

       
        protected override void OnLoad(EventArgs e)
        {
            try
            {

                base.OnLoad(e);
                this.EnsureChildControls();

                gc = new HtmlGenericControl("hr");
                gc.Attributes["class"] = "hrdbar";
                this.Controls.Add(gc);


                HtmlTable tblhead = new HtmlTable();
                tblhead.Width = "100%";
                tblhead.Height = "24px";
                tblhead.CellPadding = 0;
                tblhead.CellSpacing = 0;
                tblhead.Border = 0;


                HtmlTableRow hrw = new HtmlTableRow();

                HtmlTableCell hc1 = new HtmlTableCell();
                hc1.Width = "100%";
                hc1.Align = "left";
                hc1.VAlign = "middle";

                Label wchtitle = new Label();
                wchtitle.ID = "wchtitle";
                wchtitle.Text = "Weather";
                wchtitle.Attributes["class"] = "mywebparttitle";

                hc1.Controls.Add(wchtitle);
                hrw.Cells.Add(hc1);

                tblhead.Rows.Add(hrw);
                this.Controls.Add(tblhead);


                HtmlTable tbl = new HtmlTable();
                tbl.Width = "100%";
                tbl.CellPadding = 0;
                tbl.CellSpacing = 0;
                HtmlTableRow rw = new HtmlTableRow();
                HtmlTableCell cel1 = new HtmlTableCell();
                cel1.Align = "center";
                cel1.VAlign = "middle";
                cel1.Height = "41px";

                Label lbl = new Label();
                lbl.Text = "Location";
                lbl.Attributes["class"] = "clsgeocodeslbl";
                lbl.ID = "lblwfd";
                cel1.Controls.Add(lbl);
                cel1.Controls.Add(drpweatherlocations);
                cel1.Controls.Add(drpwmeasurement);
                rw.Cells.Add(cel1);
                tbl.Rows.Add(rw);
                this.Controls.Add(tbl);


            }
            catch (Exception exc)
            {

            }




            if (!Page.IsPostBack)
            {
                GenerateWeatherForeCast();
            }
            else
            {
                if (Page.Request.Form["__EVENTTARGET"] == drpweatherlocations.UniqueID || Page.Request.Form["__EVENTTARGET"] == drpwmeasurement.UniqueID)
                {
                    
                }
                else
                {
                    GenerateWeatherForeCast();
                }
            }
        }


        public void GenerateWeatherForeCast()
        {

            try
            {

                DataSet data = new DataSet();
                data.ReadXml("http://xml.weather.yahoo.com/forecastrss/" + drpweatherlocations.SelectedItem.Value + "_" + drpwmeasurement.SelectedItem.Value + ".xml");

                HtmlTable wtbl = new HtmlTable();
                wtbl.Width = "100%";
                wtbl.CellPadding = 0;
                wtbl.CellSpacing = 0;

                HtmlTableRow firstrw = new HtmlTableRow();
                HtmlTableRow secondrw = new HtmlTableRow();
                HtmlTableRow thirdrw = new HtmlTableRow();
                HtmlTableCell frc;
                Label lbldy;
                HtmlTableCell src;
                Image imgsmall;
                HtmlTableCell trc;
                Label lblh;
                bool isFirst = true;
                int counter = 1;

                foreach (DataRow row in data.Tables["forecast"].Rows)
                {
                    if (isFirst)
                    {
                        isFirst = false;

                        HtmlTable tbl2 = new HtmlTable();
                        tbl2.Width = "90%";
                        tbl2.CellSpacing = 0;
                        tbl2.CellPadding = 0;
                        HtmlTableRow rw2 = new HtmlTableRow();

                        HtmlTableCell cl1 = new HtmlTableCell();
                        cl1.Width = "50%";
                        cl1.Align = "right";
                        cl1.Attributes["style"] = "padding-right:5px";
                        cl1.Attributes["class"] = "todayweathertext";

                        Label lblwfdfc = new Label();
                        
                        lblwfdfc.Text = Convert.ToString(row["high"]);
                        cl1.Controls.Add(lblwfdfc);

                        HtmlTableCell cl2 = new HtmlTableCell();
                        cl2.Width = "50%";
                        cl2.Align = "right";
                        cl2.Attributes["style"] = "padding-right:20px";

                        Image imgbigimage = new Image();                        
                        imgbigimage.ImageUrl = "_layouts/images/AxisIntraBranding/sun.jpg";
                        imgbigimage.Width = new Unit("88px");
                        imgbigimage.Height = new Unit("97px");

                        cl2.Controls.Add(imgbigimage);

                        rw2.Cells.Add(cl1);
                        rw2.Cells.Add(cl2);
                        tbl2.Rows.Add(rw2);
                        this.Controls.Add(tbl2);


                    }
                    else
                    {


                        frc = new HtmlTableCell();
                        frc.Height = "45px";
                        frc.Align = "center";

                        lbldy = new Label();
                        lbldy.Text = Convert.ToString(row["day"]);
                        lbldy.Attributes["class"] = "dyshead";
                        frc.Controls.Add(lbldy);
                        firstrw.Cells.Add(frc);



                        src = new HtmlTableCell();
                        src.Height = "45px";
                        src.Align = "center";

                        imgsmall = new Image();
                        imgsmall.ImageUrl = "_layouts/images/AxisIntraBranding/weather" + Convert.ToString(counter) + ".jpg";
                        imgsmall.Width = new Unit("43px");
                        imgsmall.Height = new Unit("39px");
                        src.Controls.Add(imgsmall);
                        secondrw.Cells.Add(src);

                        trc = new HtmlTableCell();
                        trc.Align = "center";

                        lblh = new Label();
                        lblh.Text = Convert.ToString(row["high"]);
                        lblh.Attributes["class"] = "dyshead";

                        trc.Controls.Add(lblh);
                        thirdrw.Cells.Add(trc);
                        counter++;
                    }
                }


                wtbl.Rows.Add(firstrw);
                wtbl.Rows.Add(secondrw);
                wtbl.Rows.Add(thirdrw);
                this.Controls.Add(wtbl);

               // Label lblwel = new Label();
                //lblwel.Text = "http://xml.weather.yahoo.com/forecastrss/10001_" + drpmeasurement.SelectedItem.Value + ".xml";
                //this.Controls.Add(lblwel);
            }
            catch (Exception exc)
            {


            }

        }
        protected void drpwmeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateWeatherForeCast();
        }
        protected void drpweatherlocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateWeatherForeCast();
        }

        protected override void CreateChildControls()
        {
            if (!_error)
            {
                try
                {

                    base.CreateChildControls();

                    // Your code here...
                   
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }

        private void HandleException(Exception ex)
        {
            this._error = true;
            this.Controls.Clear();
            this.Controls.Add(new LiteralControl(ex.Message));
        }
    }
}
