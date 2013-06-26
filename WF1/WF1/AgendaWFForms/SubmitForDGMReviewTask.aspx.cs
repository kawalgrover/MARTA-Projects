using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using Microsoft.SharePoint.Utilities;
using System.Web.UI.WebControls;

namespace WF1
{
    public partial class SubmitForDGMReviewTask : WebPartPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSubmitForApproval.Click += new EventHandler(btnApprove_Click);
            btnDelegateTask.Click += new EventHandler(btnDelegateTask_Click);
            btnReassignToOwner.Click += new EventHandler(btnReassignToOwner_Click);
            //btnTaskCompleted.Click += new EventHandler(btnTaskCompleted_Click);
            chkDelegateTask.CheckedChanged += new EventHandler(chkDelegateTask_CheckedChanged);

            if (!Page.IsPostBack)
            {
                SPList l = SPContext.Current.List;
                SPListItem li = SPContext.Current.ListItem;
                SPFieldBoolean isDelegatedField = li.Fields["Is Delegated"] as SPFieldBoolean;
                bool isDelegated;
                if (li["Is Delegated"] != null)
                {
                    isDelegated = (bool)isDelegatedField.GetFieldValue(li["Is Delegated"].ToString());
                }
                else
                    isDelegated = false;

                if (isDelegated)
                {
                    lblDelegateTask.Text = "Re-assign back to original owner of Task";
                    chkDelegateTask.Visible = false;
                    btnReassignToOwner.Visible = true;
                }
                else
                {
                    lblDelegateTask.Text = "Delegate Task";
                    chkDelegateTask.Visible = true;
                    btnReassignToOwner.Visible = false;
                }
            }
        }

        void btnApprove_Click(object sender, EventArgs e)
        {
            SPList l = SPContext.Current.List;
            SPListItem li = SPContext.Current.ListItem;
            li[SPBuiltInFieldId.TaskStatus] = "Completed";
            li[SPBuiltInFieldId.PercentComplete] = 1;

            SaveButton.SaveItem(SPContext.Current, false, "");
            CloseForm();
        }

        private void CloseForm()
        {
            if ((SPContext.Current != null) && SPContext.Current.IsPopUI)
            {
                this.Context.Response.Write("<script type='text/javascript'>window.frameElement.commitPopup();</script>");
                this.Context.Response.Flush();
                this.Context.Response.End();
            }
            else
            {
                string str = this.Page.Request.QueryString["Source"];
                if ((str != null) && (str.Length > 0))
                {
                    SPUtility.Redirect(string.Empty, SPRedirectFlags.UseSource, this.Context);
                }
                else
                {
                    SPUtility.Redirect(SPContext.Current.Web.Url, SPRedirectFlags.UseSource, this.Context);
                }
            }
        }

        void chkDelegateTask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelegateTask.Checked)
                pnlDelegateTask.Visible = true;
            else
                pnlDelegateTask.Visible = false;
        }

        protected void DueDateValidation(object sender, ServerValidateEventArgs args)
        {
            SPList l = SPContext.Current.List;
            SPListItem li = SPContext.Current.ListItem;
            SPFieldUserValue originalOwnerOfTask = GetSPUserValue(li, "Assigned To");

            DateTime delegateDueDateValue = delegateDueDate.SelectedDate;
            DateTime taskDueDate = DateTime.Parse(li["DueDate"].ToString());

            if (delegateDueDateValue > taskDueDate)
                args.IsValid = false;
            else
                args.IsValid = true;
        }


        void btnDelegateTask_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SPList l = SPContext.Current.List;
                SPListItem li = SPContext.Current.ListItem;
                SPFieldUserValue originalOwnerOfTask = GetSPUserValue(li, "Assigned To");


                li["Is Delegated"] = true;
                li["OriginalAssignee"] = originalAssignee.Value;

                li["Assigned To"] = delegateTo.Value;
                li["DelegateDueDate"] = delegateDueDate.SelectedDate;
                li.Update();
                CloseForm();
            }
        }

        void btnReassignToOwner_Click(object sender, EventArgs e)
        {
            SPList l = SPContext.Current.List;
            SPListItem li = SPContext.Current.ListItem;
            SPFieldUserValue originalOwnerOfTask = GetSPUserValue(li, "Original Assignee");

            li["Is Delegated"] = false;

            li["OriginalAssignee"] = null;

            li["Assigned To"] = originalOwnerOfTask;
            li["DelegateDueDate"] = null;
            li.Update();
            CloseForm();
        }

        protected void chkDelegate_Checked(object sender, EventArgs e)
        {
            pnlDelegateTask.Visible = true;
        }

        private SPUser GetSPUser(SPListItem item, string key)
        {
            SPFieldUser field = item.Fields[key] as SPFieldUser;

            if (field != null && item[key] != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[key].ToString()) as SPFieldUserValue;
                if (fieldValue != null)
                {
                    return fieldValue.User;
                }
            }
            return null;
        }

        private SPFieldUserValue GetSPUserValue(SPListItem item, string key)
        {
            SPFieldUser field = item.Fields[key] as SPFieldUser;

            if (field != null && item[key] != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[key].ToString()) as SPFieldUserValue;
                return fieldValue;
            }
            return null;
        }
    }
}
