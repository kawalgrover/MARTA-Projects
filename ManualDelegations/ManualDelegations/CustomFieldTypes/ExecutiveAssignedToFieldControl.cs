using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
using Microsoft.SharePoint;

namespace ExecutiveTaskTracking.Fields
{
    public class ExecutiveAssignedToFieldControl : BaseFieldControl
    {
        CheckBoxList chkListExecutiveRoles;
        PeopleEditor userPicker;
        protected override string DefaultTemplateName
        {
            get
            {
                return "ExecutiveRoleRenderingTemplate";
            }
        }

        protected override void CreateChildControls()
        {
            if (base.Field == null)
            {
                return;
            }
            base.CreateChildControls();

            chkListExecutiveRoles = (CheckBoxList)TemplateContainer.FindControl("chkListExecutiveRoles");
            userPicker = (PeopleEditor)TemplateContainer.FindControl("userPicker");

            if (ControlMode == SPControlMode.New || ControlMode == SPControlMode.Edit)
            {
                SPWeb currentWeb = SPContext.Current.Web;
                SPList actionRequiredList = currentWeb.Lists["ExecutiveTasksRoleList"];

                foreach (SPListItem item in actionRequiredList.Items)
                {
                    SPFieldUserValue userValue = Utils.GetSPUserValue(item, "Assigned Person");
                    ListItem li = new ListItem(string.Format("{0} ({1})", item.Title, userValue.User.Name), string.Format("{0} ({1})", item.Title, userValue.User.LoginName));
                    chkListExecutiveRoles.Items.Add(li);
                }
            }

        }

        public override object Value
        {
            get
            {
                EnsureChildControls();
                List<string> selectedValues = new List<string>();
                foreach (ListItem executiveRoleItem in chkListExecutiveRoles.Items)
                {
                    if (executiveRoleItem.Selected)
                        selectedValues.Add(executiveRoleItem.Value);
                }
                
                //List<string> userNamesList = new List<string>();
                int adHocUsers = 0;
                foreach (PickerEntity pe in userPicker.Entities)
                {
                    adHocUsers++;
                    selectedValues.Add(pe.Description);
                    if (adHocUsers == 3)
                        break;
                }
                string selectedRoles = string.Join(";", selectedValues.ToArray());
                return selectedRoles;
            }
            set
            {
                this.EnsureChildControls();
                string[] selectedValues = ((string)ItemFieldValue).Split(new char[]{';'});
                List<string> adhocUsers = new List<string>();

                foreach (string selectedValue in selectedValues)
                {
                    if (chkListExecutiveRoles.Items.FindByValue(selectedValue) != null)
                    {
                        chkListExecutiveRoles.Items.FindByValue(selectedValue).Selected = true;
                    }
                    else
                    {
                        adhocUsers.Add(selectedValue);
                    }
                }

                if (adhocUsers.Count > 0)
                {
                    userPicker.CommaSeparatedAccounts = string.Join(",", adhocUsers.ToArray());
                }
            }
        }
    }
}
