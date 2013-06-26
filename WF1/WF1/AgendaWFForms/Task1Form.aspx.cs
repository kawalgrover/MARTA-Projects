using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using Microsoft.SharePoint.Utilities;

namespace WF1
{
    public partial class Task1Form : WebPartPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSaveAsDraft.Click += new EventHandler(btnSaveAsDraft_Click);
            btnComplete.Click += new EventHandler(btnComplete_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        void btnComplete_Click(object sender, EventArgs e)
        {
            SPList l = SPContext.Current.List;
            SPListItem li = SPContext.Current.ListItem;
            li[SPBuiltInFieldId.TaskStatus] = "Tasks_Completed";
            li[SPBuiltInFieldId.PercentComplete] = 1;

            SaveButton.SaveItem(SPContext.Current, false, "");
            CloseForm();
        }

        void btnSaveAsDraft_Click(object sender, EventArgs e)
        {
            SaveButton.SaveItem(SPContext.Current, false, "");
            CloseForm();
        }

        private void CloseForm()
        {
            if ((SPContext.Current != null) && SPContext.Current.IsPopUI)
            {
                this.Context.Response.Write("<script'>window.frameElement.commitPopup();</script>");
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
            }
        }
    }
}
