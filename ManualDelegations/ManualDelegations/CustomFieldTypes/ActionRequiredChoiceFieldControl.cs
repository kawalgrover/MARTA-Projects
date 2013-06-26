using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
using Microsoft.SharePoint;

namespace ExecutiveTaskTracking.Fields
{
    public class ActionRequiredChoiceFieldControl : BaseFieldControl
    {
        CheckBoxList chkListActionsRequired;

        protected override string DefaultTemplateName
        {
            get
            {
                return "DropDownRenderingTemplate";
            }
        }

        protected override void CreateChildControls()
        {
            if (base.Field == null)
            {
                return;
            }
            base.CreateChildControls();

            chkListActionsRequired = (CheckBoxList)TemplateContainer.FindControl("chkListActionsRequired");

            if (ControlMode == SPControlMode.New || ControlMode == SPControlMode.Edit)
            {
                SPWeb currentWeb = SPContext.Current.Web;
                SPList actionRequiredList = currentWeb.Lists["ActionsRequired"];
                
                foreach (SPListItem item in actionRequiredList.Items)
                {
                    chkListActionsRequired.Items.Add(item.Title); 
                }
            }

        }

        public override object Value
        {
            get
            {
                EnsureChildControls();

                List<string> selectedValues = new List<string>();
                foreach (ListItem actionRequired in chkListActionsRequired.Items)
                {
                    if (actionRequired.Selected)
                        selectedValues.Add(actionRequired.Value);
                }
                string actionsRequired = string.Join(";", selectedValues.ToArray());

                return actionsRequired;

            }
            set
            {
                this.EnsureChildControls();
                
                string[] selectedValues = ((string)ItemFieldValue).Split(new char[] { ';' });

                foreach (string selectedValue in selectedValues)
                {
                    chkListActionsRequired.Items.FindByValue(selectedValue).Selected = true;
                }
            }
        }
    }
}
