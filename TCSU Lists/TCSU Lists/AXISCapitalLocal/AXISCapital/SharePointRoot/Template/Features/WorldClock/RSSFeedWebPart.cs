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
    [Guid("eef88389-3400-419e-a9bb-7b0441609769")]
    public class RSSFeedWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        DataSet data;     

        private bool _error = false;
        private string _myProperty = null;
        HtmlGenericControl gc;
        DropDownList drpclocklocations = new DropDownList();
        Label lblclockdate;
        Label lblclocktime;
        Label lblclocklocation;
        ScriptManager smanager = new ScriptManager();
        UpdatePanel upanel = new UpdatePanel();
        Timer atimer = new Timer();
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
                    _myProperty = "Locations";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public RSSFeedWebPart()
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
                    EnsurePanelFix();
                    if (ScriptManager.GetCurrent(this.Page) == null)
                    {
                        smanager.ID = "myScriptManager1";
                        smanager.EnablePartialRendering = true;

                        this.Controls.Add(smanager);
                    }


                    upanel.ID = "myUpdatePanel1";
                    upanel.UpdateMode = UpdatePanelUpdateMode.Conditional;
                    upanel.ChildrenAsTriggers = true;

                    atimer.ID = "myTimer1";
                    atimer.Enabled = true;
                    atimer.Interval = 10000;
                    atimer.Tick += new EventHandler<EventArgs>(atimer_Tick);
                    upanel.ContentTemplateContainer.Controls.Add(atimer);


                    gc = new HtmlGenericControl("hr");
                    gc.Attributes["class"] = "hrdbar";
                    upanel.ContentTemplateContainer.Controls.Add(gc);

                    HtmlTable tblhead = new HtmlTable();//Table
                    tblhead.Width = "100%";
                    tblhead.Height = "24px";
                    tblhead.CellPadding = 0;
                    tblhead.CellSpacing = 0;
                    tblhead.Border = 0;


                    HtmlTableRow hrw = new HtmlTableRow();//row
                    HtmlTableCell rc = new HtmlTableCell();
                    rc.Align = "left";
                    rc.VAlign = "middle";

                    Label wchclocktitle = new Label();// Web Part Title
                    wchclocktitle.Text = "World Clock";
                    wchclocktitle.ID = "wchclocktitle";
                    wchclocktitle.Attributes["class"] = "mywebparttitle";
                    rc.Controls.Add(wchclocktitle);
                    hrw.Cells.Add(rc);

                    tblhead.Rows.Add(hrw);
                    upanel.ContentTemplateContainer.Controls.Add(tblhead);

                    HtmlTable tbl = new HtmlTable();
                    tbl.Width = "100%";
                    tbl.CellPadding = 0;
                    tbl.CellSpacing = 0;
                    HtmlTableRow rw = new HtmlTableRow();
                    HtmlTableCell cel1 = new HtmlTableCell();
                    cel1.Align = "center";
                    cel1.VAlign = "middle";
                    cel1.Height = "41px";

                    lblclocklocation = new Label();
                    lblclocklocation.Text = "Location";
                    lblclocklocation.Attributes["class"] = "clsgeocodeslbl";
                    lblclocklocation.ID = "lblclocklocation";
                    cel1.Controls.Add(lblclocklocation);
                    cel1.Controls.Add(drpclocklocations);
                    rw.Cells.Add(cel1);

                    tbl.Rows.Add(rw);
                    this.Controls.Add(tbl);
                    upanel.ContentTemplateContainer.Controls.Add(tbl);


                    DataSet data = new DataSet();
                    data.ReadXml("http://www.earthtools.org/timezone-1.1/40.71417/-74.00639");


                    HtmlTable tblclock = new HtmlTable();
                    tblclock.Width = "100%";
                    tblclock.CellPadding = 0;
                    tblclock.CellSpacing = 0;
                    tblclock.Border = 0;


                    HtmlTableRow rw1 = new HtmlTableRow();
                    HtmlTableCell cl1 = new HtmlTableCell();
                    cl1.Align = "center";
                    cl1.VAlign = "middle";
                    cl1.Height = "60px";

                    lblclockdate = new Label();
                    lblclockdate.Text = DateTime.Parse(Convert.ToString(data.Tables["timezone"].Rows[0]["localtime"])).ToString("MM/dd/yyyy");
                    lblclockdate.ID = "lblclockdate";

                    cl1.Controls.Add(lblclockdate);
                    rw1.Cells.Add(cl1);
                    tblclock.Rows.Add(rw1);

                    HtmlTableRow rw2 = new HtmlTableRow();
                    HtmlTableCell cl2 = new HtmlTableCell();
                    cl2.Align = "center";
                    cl2.VAlign = "middle";
                    cl2.Height = "30px";


                    lblclocktime = new Label();
                    lblclocktime.ID = "lblclocktime";
                    lblclocktime.Text = DateTime.Parse(Convert.ToString(data.Tables["timezone"].Rows[0]["localtime"])).ToString("hh:mm tt");
                    lblclocktime.Attributes["class"] = "clsworldtitle";
                    cl2.Controls.Add(lblclocktime);
                    rw2.Cells.Add(cl2);


                    tblclock.Rows.Add(rw2);
                    upanel.ContentTemplateContainer.Controls.Add(tblclock);

                    this.Controls.Add(upanel);

                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }

        private void EnsurePanelFix()
        {
            if (this.Page.Form != null)
            {
                String fixupScript = @"_spBodyOnLoadFunctionNames.push(""_initFormActionAjax"");
     function _initFormActionAjax()
     {
       if (_spEscapedFormAction == document.forms[0].action)
       {
         document.forms[0]._initialAction = 
         document.forms[0].action;
       }
     }
     var RestoreToOriginalFormActionCore = 
       RestoreToOriginalFormAction;
     RestoreToOriginalFormAction = function()
     {
       if (_spOriginalFormAction != null)
       {
         RestoreToOriginalFormActionCore();
         document.forms[0]._initialAction = 
         document.forms[0].action;
       }
     }";
                ScriptManager.RegisterStartupScript(this,
                  typeof(RSSFeedWebPart), "UpdatePanelFixup",
                  fixupScript, true);
            }
        }
        protected void atimer_Tick(object sender, EventArgs e)
        {

            if (lblclockdate != null && lblclocktime != null)
            {
                 data = new DataSet();
                data.ReadXml("http://www.earthtools.org/timezone-1.1/40.71417/-74.00639");
                lblclockdate.Text = DateTime.Parse(Convert.ToString(data.Tables["timezone"].Rows[0]["localtime"])).ToString("MM/dd/yyyy");
                lblclocktime.Text = DateTime.Parse(Convert.ToString(data.Tables["timezone"].Rows[0]["localtime"])).ToString("hh:mm tt");

                //lblclockdate.Text = System.DateTime.Now.ToString("dd/MMM/yyyy");
                //lblclocktime.Text = DateTime.Now.ToString("hh:mm tt");
            }
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            SPList list = SPContext.Current.Web.Lists[this.MyProperty];
            drpclocklocations.ID = "drpclocklocations";
            if (list != null)
            {
                foreach (SPListItem im in list.Items)
                {
                    ListItem item = new ListItem();
                    item.Text = Convert.ToString(im["locname"]);
                    drpclocklocations.Items.Add(item);
                }
            }
            drpclocklocations.Attributes["class"] = "clsgeocodes";



        }

        protected void drpclocklocations_SelectedIndexChanged(object sender, EventArgs e)
        {

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

       
    }
}
