using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;

namespace TCSU.Layouts
{
    public partial class TCSUDocNewForm : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                
                SPWeb currentWeb = SPContext.Current.Web;

                SPList documentNumbersList = currentWeb.Lists["DocumentNumbers"];
                SPList disciplinesList = currentWeb.Lists["Disciplines"];

                ddlAlstomDocumentNumbers.Items.Add(new ListItem("Select Document Number", "0"));
               

                foreach (SPListItem documentNumber in documentNumbersList.Items)
                {
                    ListItem li = new ListItem(documentNumber["AlstomDocumentDescription"].ToString(), documentNumber["AlstomDocumentDescription"].ToString());
                    ddlAlstomDocumentNumbers.Items.Add(li);
                }
                
                lnkDocumentNumbers.NavigateUrl = documentNumbersList.DefaultViewUrl;
            }
        }
    }
}
