using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using FluentDateTime;

namespace ExecutiveTaskTracking.Layouts.ExecutiveTaskTracking
{
    public partial class ExecTaskNewForm : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                SPWeb currentWeb = SPContext.Current.Web;
                SPList configurationList = currentWeb.Lists["ExecutiveTaskConfigurationList"]; //TODO: Make list name configurable.
                //Get the very first item.
                if (configurationList.Items.Count > 0)
                {
                    SPListItem configurationListItem = configurationList.Items[0];
                    lblExecutiveTaskSource.Text = configurationListItem.Title;
                    lblExeutiveTaskCoordinator.Text = Utils.GetSPUserValue(configurationListItem, "Task Coordinator").User.Name;

                    int daysToAdd = Convert.ToInt16(configurationListItem["DefautDueDays"]);

                    field_DelegateDueDate.Value = DateTime.Today.AddBusinessDays(daysToAdd);
                }
                else
                {
                    lblExecutiveTaskSource.Text = "Could not find configuration information.";
                }
            }
        }

        
    }
}
