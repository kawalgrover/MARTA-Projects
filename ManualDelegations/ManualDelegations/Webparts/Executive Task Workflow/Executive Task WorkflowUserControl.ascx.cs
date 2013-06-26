using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using System.Linq;
using Microsoft.SharePoint.Utilities;
using System.Web;

namespace ExecutiveTaskTracking.Webparts.Executive_Task_Workflow
{
    public partial class Executive_Task_WorkflowUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SPListItem li = SPContext.Current.ListItem;
                foreach (SPWorkflow worfklow in li.Workflows)
                {
                    if (worfklow.InternalState == SPWorkflowState.NotStarted)
                    {
                        btnExecutiveTaskWorkflow.Enabled = true;
                    }
                    else
                    {
                        string status = Convert.ToString(li["TaskStatus"]);
                        btnExecutiveTaskWorkflow.Enabled = false;
                        btnExecutiveTaskWorkflow.Text = status;
                    }
                }

                if (Convert.ToBoolean(li["HighPriority"]))
                {
                    lblHighPriority.Text = "High Priority!";
                }
                else
                    lblHighPriority.Text = string.Empty;
            }
        }

        protected void btnExecutiveTaskWorkflow_Click(object sender, EventArgs e)
        {
            SPListItem li = SPContext.Current.ListItem;

            SPWeb web = SPContext.Current.Web;

            SPWorkflowAssociationCollection wfAssociations = li.ParentList.WorkflowAssociations;

            foreach(SPWorkflowAssociation wfAssociation in wfAssociations)
            {
                if (wfAssociation.Name == "Executive Task Tracking Workflow")
                {
                    try
                    {
                        //string responseURL = string.Format("{0}/{1}", web.Url, wfAssociation.InstantiationUrl);

                        web.Site.WorkflowManager.StartWorkflow(li, wfAssociation, string.Empty);
                        btnExecutiveTaskWorkflow.Enabled = false;
                        btnExecutiveTaskWorkflow.Text = "Submitted";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error starting the workflow for the executive task", ex);
                    }
                    break;
                }
            }
            
        }
    }
}
