using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace TCSU.Layouts.TCSU
{
    public partial class TCSUDocEditForm : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                SPWeb currentWeb = SPContext.Current.Web;
                SPList documentNumbersList = null;
                SPList disciplinesList = null;

                try
                {
                    documentNumbersList = currentWeb.Lists["DocumentNumbers"];
                    disciplinesList = currentWeb.Lists["Disciplines"];

                    ddlAlstomDocumentNumbers.Items.Add(new ListItem("", "0"));

                    foreach (SPListItem documentNumber in documentNumbersList.Items)
                    {
                        ListItem li = new ListItem(documentNumber["AlstomDocumentDescription"].ToString(), documentNumber["AlstomDocumentDescription"].ToString());
                        ddlAlstomDocumentNumbers.Items.Add(li);
                    }

                }
                catch (Exception ex)
                {
                    Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception – {0} – {1} – {2}", "Error loading lists perhaps", ex.Message, ex.StackTrace);
                }
                
                SPList currentList = SPContext.Current.List;
                SPListItem currentItem = currentList.GetItemById(SPContext.Current.ItemId);

                //Populate the ListBox based on the Discipline value
                if (currentItem["Discipline"] != null)
                {
                    string discipline = currentItem["Discipline"].ToString();
                    SPQuery query = new SPQuery();
                    query.Query = string.Format(@"<Where>
                            <Eq><FieldRef Name='Discipline'/><Value Type='Choice'>{0}</Value></Eq>
                        </Where>", discipline);

                    SPListItemCollection locationVehicles = disciplinesList.GetItems(query);

                    foreach (SPListItem locationVehicle in locationVehicles)
                    {
                        string lv = string.Format("{0} - {1}", locationVehicle["Title"].ToString(), locationVehicle["Code"].ToString());

                        lbLocationVehicles.Items.Add(new ListItem(lv, lv));
                    }

                    if (currentItem["Location/Vehicle"] != null)
                    {
                        lbLocationVehicles.SelectedValue = currentItem["Location/Vehicle"].ToString();
                    }
                }


                if (currentItem["AlstomDocumentNumber"] != null)
                {
                    ddlAlstomDocumentNumbers.SelectedValue = currentItem["AlstomDocumentNumber"].ToString();
                }

                
                lnkDocumentNumbers.NavigateUrl = documentNumbersList.DefaultViewUrl;
            }
        }

        private static Control FindControlRecursive(Control Root, string Id)
        {
            if ((Root.ID != null) && (Root.ID.Contains(Id)))
                return Root;

            foreach (Control Ctl in Root.Controls)
            {
                Control FoundCtl = FindControlRecursive(Ctl, Id);

                if (FoundCtl != null)
                    return FoundCtl;
            }

            return null;
        }
    }
}
