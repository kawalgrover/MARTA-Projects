using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebPartPages;
using System.Collections;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI.HtmlControls;
using System.DirectoryServices;
using Microsoft.Office.Server;
using Microsoft.Office.Server.UserProfiles;



namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("d9dbdd59-ade0-4868-b894-505aeff68b01")]
    public class MyQuickLinksWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        private bool _error = false;
        private string _myProperty = null;
        Panel pnlmylinks;
        TextBox txttitle;
        TextBox txturl;
        ListBox lstmyquicklinks;
        Button btnmylinksok;
        Button btnmylinkscancel;
        Label lblmylinksheader;
        HtmlGenericControl gcbr;
        Button btndeletemylinks;
        ScriptManager smanager2 = new ScriptManager();
        UpdatePanel upanel2 = new UpdatePanel();
        AsyncPostBackTrigger astrigger;
        LinkButton linkManage = new LinkButton();
        [Personalizable(PersonalizationScope.Shared)]
        [WebBrowsable(true)]
        [System.ComponentModel.Category("Custom Properties")]
        [WebDisplayName("ListName")]
        [WebDescription("Meaningless Property")]
        public string MyProperty
        {
            get
            {
                if (_myProperty == null)
                {
                    _myProperty = "MyQuickLinks";
                }
                return _myProperty;
            }
            set { _myProperty = value; }
        }


        public MyQuickLinksWebPart()
        {
            this.ExportMode = WebPartExportMode.All;
        }

        /// <summary>
        /// Create all your controls here for rendering.
        /// Try to avoid using the RenderWebPart() method.
        /// </summary>
        /// 
        protected override void OnInit(EventArgs e)
        {

              try
                {
                    base.OnInit(e);
                    base.EnsureChildControls();

                    if (ScriptManager.GetCurrent(this.Page) == null)
                    {
                        smanager2.ID = "myScriptManager2";
                        smanager2.EnablePartialRendering = true;

                        this.Controls.Add(smanager2);
                    }
                    upanel2.ID = "myUpdatePanel2";
                    upanel2.UpdateMode = UpdatePanelUpdateMode.Conditional;
                    upanel2.ChildrenAsTriggers = true;

                    this.Controls.Add(upanel2);


                    HtmlGenericControl gc = new HtmlGenericControl("hr");
                    gc.Attributes["class"] = "hrdbar";
                    //this.Controls.Add(gc);

                    upanel2.ContentTemplateContainer.Controls.Add(gc);

                    HtmlTable tbl = new HtmlTable();
                    tbl.Width = "100%";
                    tbl.Height = "15px";
                    tbl.CellPadding = 0;
                    tbl.CellSpacing = 0;

                    HtmlTableRow rw = new HtmlTableRow();
                    HtmlTableCell td = new HtmlTableCell();
                    td.Align = "left";
                    td.Width = "85%";

                    gc = new HtmlGenericControl("span");
                    gc.Attributes["class"] = "mywebparttitle";
                    gc.InnerText = "My Quick Links";
                    td.Controls.Add(gc);
                    rw.Cells.Add(td);

                    HtmlTableCell td2 = new HtmlTableCell();
                    td.Attributes["style"] = "padding-right:10px";
                   // gc = new HtmlGenericControl("a");
                    //gc.Attributes["href"] = "javascript:showMyLinksPopup()";
                    //gc.InnerText = "Manage";
                    //td2.Controls.Add(gc);

                    
                    linkManage.ID = "linkManage";
                    linkManage.Text = "Manage";
                    td2.Controls.Add(linkManage);
                    rw.Cells.Add(td2);
                    tbl.Rows.Add(rw);
                    // this.Controls.Add(tbl);

                    astrigger = new AsyncPostBackTrigger();
                    astrigger.ControlID = linkManage.ID;
                    astrigger.EventName = "Click";
                    upanel2.Triggers.Add(astrigger);
                    upanel2.ContentTemplateContainer.Controls.Add(tbl);
                    
                }
                catch (Exception exc)
                {
                    HandleException(exc);
                }
            
        }
        protected override void CreateChildControls()
        {
            if (!_error)
            {
                try
                {

                    base.CreateChildControls();
                    EnsurePanelFix();
                    // Your code here...
                    // this.Controls.Add(new LiteralControl(this.MyProperty));


                    

                    pnlmylinks = new Panel();
                    pnlmylinks.ID = "pnlmylinks";
                    pnlmylinks.Attributes["class"] = "lyrpnlmylinks";
                    pnlmylinks.HorizontalAlign = System.Web.UI.WebControls.HorizontalAlign.Left;
                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);

                    lblmylinksheader = new Label();
                    lblmylinksheader.ID = "lblmylinksheader";
                    lblmylinksheader.Text = "<center>Manage My Quick Links</center>";
                    lblmylinksheader.Font.Size = new FontUnit("14px");
                    lblmylinksheader.Font.Bold = true;
                    pnlmylinks.Controls.Add(lblmylinksheader);
                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);


                    HtmlGenericControl  gc = new HtmlGenericControl("span");
                    gc.InnerText = "Title";
                    pnlmylinks.Controls.Add(gc);

                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);


                    txttitle = new TextBox();
                    txttitle.ID = "txttitle";
                    pnlmylinks.Controls.Add(txttitle);

                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);


                    gc = new HtmlGenericControl("span");
                    gc.InnerText = "Url";
                    pnlmylinks.Controls.Add(gc);

                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);

                    txturl = new TextBox();
                    txturl.ID = "txturl";
                    pnlmylinks.Controls.Add(txturl);

                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);
                    btnmylinksok = new Button();
                    btnmylinksok.ID = "btnmylinksok";
                    btnmylinksok.Text = "Ok";
                    pnlmylinks.Controls.Add(btnmylinksok);

                    btnmylinksok.Click += new EventHandler(btnmylinksok_Click);

                    btnmylinkscancel = new Button();
                    btnmylinkscancel.ID = "btnmylinkscancel";
                    btnmylinkscancel.Text = "Cancel";

                    btnmylinkscancel.Click += new EventHandler(btnmylinkscancel_Click);
                    pnlmylinks.Controls.Add(btnmylinkscancel);
                    pnlmylinks.Visible = false;


                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);



                    lstmyquicklinks = new ListBox();
                    lstmyquicklinks.ID = "lstmyquicklinks";
                    lstmyquicklinks.Width = new Unit("250px");
                    lstmyquicklinks.Rows = 10;
                    lstmyquicklinks.SelectionMode = ListSelectionMode.Multiple;
                    

                    ServerContext _serviceContext = ServerContext.Current;
                    UserProfileManager profilmanager = new UserProfileManager(_serviceContext);

                    UserProfile _userProfile = profilmanager.GetUserProfile(true);

                    if (_userProfile.PersonalSite != null)
                    {

                        QuickLinkManager qlmanager = new QuickLinkManager(_userProfile);
                        QuickLink[] ql = qlmanager.GetItems();                        
                        
                        if (ql.Length != 0)
                        {
                            foreach (QuickLink objql in ql)
                            {
                                ListItem litem = new ListItem();
                                litem.Text = objql.Title;
                                lstmyquicklinks.Items.Add(litem);
                            }
                        }                        
                    }

                    pnlmylinks.Controls.Add(lstmyquicklinks);
                    gcbr = new HtmlGenericControl("br");
                    pnlmylinks.Controls.Add(gcbr);
                    btndeletemylinks = new Button();
                    btndeletemylinks.ID = "btndeletemylinks";
                    btndeletemylinks.Text = "Delete";
                    btndeletemylinks.Click += new EventHandler(btndeletemylinks_Click);
                    pnlmylinks.Controls.Add(btndeletemylinks);

                    //this.Controls.Add(pnlmylinks);

                    astrigger = new AsyncPostBackTrigger();
                    astrigger.ControlID = btnmylinksok.ID;
                    astrigger.EventName = "Click";
                    upanel2.Triggers.Add(astrigger);



                    astrigger = new AsyncPostBackTrigger();
                    astrigger.ControlID = btnmylinkscancel.ID;
                    astrigger.EventName = "Click";
                    upanel2.Triggers.Add(astrigger);


                    astrigger = new AsyncPostBackTrigger();
                    astrigger.ControlID = btndeletemylinks.ID;
                    astrigger.EventName = "Click";
                    upanel2.Triggers.Add(astrigger);
                    upanel2.ContentTemplateContainer.Controls.Add(pnlmylinks);


                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }

                //IsDisplayed
            }
        }

        protected  void btndeletemylinks_Click(object sender, EventArgs e)
        {
            pnlmylinks = this.FindControl("pnlmylinks") as Panel;
            lstmyquicklinks = this.FindControl("lstmyquicklinks") as ListBox;

            if (pnlmylinks != null && lstmyquicklinks != null)
            {
                try
                {

                    foreach (ListItem item in lstmyquicklinks.Items)
                    {
                        if (item.Selected)
                        {
                            ServerContext _serviceContext = ServerContext.Current;
                            UserProfileManager profilmanager = new UserProfileManager(_serviceContext);

                            UserProfile _userProfile = profilmanager.GetUserProfile(true);

                            if (_userProfile.PersonalSite != null)
                            {

                                QuickLinkManager qlmanager = new QuickLinkManager(_userProfile);
                                QuickLink[] ql = qlmanager.GetItems();

                                if (ql.Length != 0)
                                {
                                    foreach (QuickLink objql in ql)
                                    {

                                        if (objql.Title == item.Text)
                                        {
                                            objql.Delete();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    GenerateMyQuickLinks();
                    pnlmylinks.Visible = false;

                }
                catch (Exception exc)
                {

                }
            }
        }
        /// <summary>
        /// Ensures that the CreateChildControls() is called before events.
        /// Use CreateChildControls() to create your controls.
        /// </summary>
        /// <param name="e"></param> 
        /// 
        protected void btnmylinksok_Click(object sender, EventArgs e)
        {
            pnlmylinks = this.FindControl("pnlmylinks") as Panel;
            txttitle = this.FindControl("txttitle") as TextBox;
            txturl = this.FindControl("txturl") as TextBox;
            if (pnlmylinks != null && txttitle != null && txturl != null)
            {

                    ServerContext _serviceContext = ServerContext.Current;
                    UserProfileManager profilmanager = new UserProfileManager(_serviceContext);

                    UserProfile _userProfile = profilmanager.GetUserProfile(true);

                    if (_userProfile.PersonalSite != null)
                    {

                        QuickLinkManager qlmanager = new QuickLinkManager(_userProfile);
                        qlmanager.Create(txttitle.Text, txturl.Text, QuickLinkGroupType.UserSpecified, "Best SharePoint Components Sites", Privacy.Public);
                        
                    }

                    GenerateMyQuickLinks();
                txttitle.Text = "";
                txturl.Text = "";
                pnlmylinks.Visible = false;
            }
        }

        protected void btnmylinkscancel_Click(object sender, EventArgs e)
        {
            pnlmylinks = this.FindControl("pnlmylinks") as Panel;
            if (pnlmylinks != null)
            {
                GenerateMyQuickLinks();
                pnlmylinks.Visible = false;
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
        protected override void OnLoad(EventArgs e)
        {
            if (!_error)
            {
                try
                {
                    base.OnLoad(e);
                    this.EnsureChildControls();



                    pnlmylinks = this.FindControl("pnlmylinks") as Panel;


                    if (!this.Page.IsPostBack)
                    {
                        GenerateMyQuickLinks();
                    }
                    else
                    {

                        if (Page.Request.Form["__EVENTTARGET"] == linkManage.UniqueID)
                        {
                            if (pnlmylinks != null)
                            {
                                pnlmylinks.Visible = true;
                            }

                        }
                        else
                        {

                        }

                    }

                    // Your code here...
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
            }
        }
        public void GenerateMyQuickLinks()
        {
            ServerContext _serviceContext = ServerContext.Current;
            UserProfileManager profilmanager = new UserProfileManager(_serviceContext);

            UserProfile _userProfile = profilmanager.GetUserProfile(true);

            if (_userProfile.PersonalSite != null)
            {
                
                QuickLinkManager qlmanager = new QuickLinkManager(_userProfile);
                QuickLink[] ql = qlmanager.GetItems();

                if (ql.Length != 0)
                {
                    HtmlGenericControl ul = new HtmlGenericControl("ul");
                    ul.Attributes["class"] = "rightsideul";
                    foreach (QuickLink objql in ql)
                    {
                        HtmlGenericControl li = new HtmlGenericControl("li");
                        li.Attributes["class"] = "rightsideli";

                        HtmlGenericControl a = new HtmlGenericControl("a");
                        a.Attributes["href"] = objql.Url;
                        a.InnerText = objql.Title;
                        li.Controls.Add(a);
                        ul.Controls.Add(li);
                    }

                    //this.Controls.Add(ul);
                    upanel2.ContentTemplateContainer.Controls.Add(ul);
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

        /*
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("<hr  class='hrdbar' />");
            SPList list = SPContext.Current.Web.Lists[MyProperty];

            if (list != null)
            {
                writer.Write("<table width='100%' height='15px' cellpadding='0' cellspacing='0'><tr><td align='left'  width='85%'><span class='mywebparttitle'> My Quick Links</span></td><td style='padding-right:10px'><a href='javascript:showMyLinksPopup()' style='color:#000000'>Manage</a></td></tr></table><ul class='rightsideul'>");
                
                foreach (SPListItem item in list.Items)
                {

                    writer.Write("<li class='rightsideli'><a href='" + Convert.ToString(item["PageLink"]) + "' target='_blank'>" + item.Title + "</a></li>");
                }
                writer.Write("</ul>");

                
            }
            else
            {
                writer.Write("List " + MyProperty + " doesn't exists");
            }
        }
         */
    }
}
