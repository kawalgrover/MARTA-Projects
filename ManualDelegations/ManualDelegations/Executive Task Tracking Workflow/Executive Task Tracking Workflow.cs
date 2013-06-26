using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;
using System.Collections.Generic;
using System.Text;
using FluentDateTime;
using Microsoft.SharePoint.Administration.Claims;

namespace ExecutiveTaskTracking.Executive_Task_Tracking_Workflow
{
    public sealed partial class Executive_Task_Tracking_Workflow : SequentialWorkflowActivity
    {
        public List<string> assignees;
        private string taskCoordinator;
        private string taskSource;
        private int dueDays;
        string[] actionsOwed;

        public Executive_Task_Tracking_Workflow()
        {
            InitializeComponent();
        }

        public Guid workflowId = default(System.Guid);
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private void setExecutiveTaskStatus1_ExecuteCode(object sender, EventArgs e)
        {
            SetExecutiveTaskStatus("Delegated");
        }

        private void SetOtherVariablesForTask()
        {
            SPList configurationList = this.workflowProperties.Web.Lists["ExecutiveTaskConfigurationList"];
            SPListItem configurationListItem = configurationList.Items[0];

            taskCoordinator = GetSPUser(configurationListItem, "Task Coordinator").LoginName;
            taskSource = Convert.ToString(configurationListItem.Title);
            dueDays = Convert.ToInt16(configurationListItem["DefautDueDays"]);
        }

        private void SetExecutiveTaskStatus(string newStatus)
        {
            SPListItem executiveTask = this.workflowProperties.Item;
            executiveTask["TaskStatus"] = newStatus;
            executiveTask.Update();
        }

        private string GetAssigneeName(string assignee)
        {
            string assigneeLogin;
            //string claimsLogin;
            SPUser user;
            int indexOfOpenParen = assignee.IndexOf("(");
            int indexOfCloseParen = assignee.IndexOf(")");
            
            if (indexOfOpenParen > 0)
            {
                assigneeLogin = assignee.Substring(indexOfOpenParen + 1, indexOfCloseParen - (indexOfOpenParen + 1));
            }
            else
                assigneeLogin = assignee;

            //if (SPClaimProviderManager.IsEncodedClaim(assigneeLogin))
            //    claimsLogin = string.Format("i:0#.w|{0}", assigneeLogin);
            //else
            //    claimsLogin = assigneeLogin;


            this.workflowProperties.Web.Site.RootWeb.EnsureUser(assigneeLogin);
            user = this.workflowProperties.Web.Site.RootWeb.AllUsers[assigneeLogin];

            return user.LoginName;

        }

        private void replicatorForExecutiveTasks_Initialized(object sender, EventArgs e)
        {
            SetOtherVariablesForTask();

            assignees = new List<string>();
            char[] splitCharacters = new char[] { ';' };
            string contributors = Convert.ToString(this.workflowProperties.Item["DelegateTo"]); // WorkflowData.Contributors.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries);

            string[] contributorsArray = contributors.Split(splitCharacters);
            foreach(string contributor in contributorsArray)
            {
                assignees.Add(GetAssigneeName(contributor));
            }
            
            // Add the first task.
            int lastContributorIndex = contributors.Count() - 1;
            
            notifyTaskOwner.TaskAssignedTo = assignees.Last();; //contributors[lastContributorIndex];

            StringBuilder sb = new StringBuilder();
            actionsOwed = Convert.ToString(this.workflowProperties.Item["ActionRequired"]).Split(splitCharacters);

            if (actionsOwed.Count() > 1)
            {
                notifyTaskOwner.TaskTitle = string.Format("{0} - Action(s) required", taskSource);
                notifyTaskOwner.Action = "Mulitple Actions in task";
            }
            else if (actionsOwed.Count() == 1)
            {
                notifyTaskOwner.TaskTitle = string.Format("{0} - {1}", taskSource, actionsOwed[0]);
                notifyTaskOwner.Action = GetTaskAction(actionsOwed[0]);
            }

            sb.Append("You are required to take the following actions.");

            foreach (string actionOwed in actionsOwed)
            {
                sb.Append(actionOwed);
                sb.Append(Environment.NewLine);
            }
            notifyTaskOwner.TaskDescription = sb.ToString();

            if (this.workflowProperties.Item["DelegateDueDate"] != null)
            {
                notifyTaskOwner.TaskDueDate = Convert.ToDateTime(this.workflowProperties.Item["DelegateDueDate"]);
            }
            else
            {
                notifyTaskOwner.TaskDueDate = DateTime.Today.AddBusinessDays(dueDays);
            }
            notifyTaskOwner.Source = string.Format("Executive Task ({0})", taskSource);
        }

        private string GetTaskAction(string executiveTask)
        {
            SPList actionsRequiredList = this.workflowProperties.Web.Lists["ActionsRequired"];

            SPQuery query = new SPQuery()
            {
                Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='Title' />
                                                  <Value Type='Text'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", executiveTask)
            };

            foreach (SPListItem item in actionsRequiredList.GetItems(query))
            {
                if (item.Title == executiveTask)
                {
                    return Convert.ToString(item["Action"]);
                }
            }
            // If you get to this point, that means the specific Executive task was not found in the ActionsRequired configuration list.
            return null;
        }

        private void replicatorForExecutiveTasks_ChildInitialized(object sender, ReplicatorChildEventArgs e)
        {

            notifyTaskOwner.TaskAssignedTo = e.InstanceData.ToString();

            StringBuilder sb = new StringBuilder();

            if (actionsOwed.Count() > 1)
            {
                notifyTaskOwner.TaskTitle = string.Format("{0} - Action(s) required", taskSource);
                notifyTaskOwner.Action = "Mulitple Actions in task";
            }
            else if (actionsOwed.Count() == 1)
            {
                notifyTaskOwner.TaskTitle = string.Format("{0} - {1}", taskSource, actionsOwed[0]);
                notifyTaskOwner.Action = GetTaskAction(actionsOwed[0]);
            }

            sb.Append("You are required to take the following actions.");

            foreach (string actionOwed in actionsOwed)
            {
                sb.Append(actionOwed);
                sb.Append(Environment.NewLine);
            }
            notifyTaskOwner.TaskDescription = sb.ToString();

            notifyTaskOwner.TaskDueDate = (this.workflowProperties.Item["DelegateDueDate"] != null) ? Convert.ToDateTime(this.workflowProperties.Item["DelegateDueDate"]) : DateTime.Today.AddBusinessDays(dueDays);
            notifyTaskOwner.Source = string.Format("Executive Task ({0})", taskSource);

        }

        private SPUser GetSPUser(SPListItem item, string fieldName)
        {
            SPFieldUser field = item.Fields[fieldName] as SPFieldUser;
            if (field != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[fieldName].ToString()) as SPFieldUserValue;

                if (fieldValue != null)
                    return fieldValue.User;
            }
            return null;
        }

        private void setExecutiveTaskStatus2_ExecuteCode(object sender, EventArgs e)
        {
            SetExecutiveTaskStatus("Completed");

            //Set the properties for the Notify Task Coordinator activity.
            notifyTaskCoordinator.TaskAssignedTo = taskCoordinator;
            notifyTaskCoordinator.TaskTitle = "Action(s) completed for Executive task. Confirm completion.";
            notifyTaskCoordinator.TaskDescription = "Please confirm that all actions required for this executive task have been completed. Once you mark this task complete. It will update the status to 'Confirmed Completion' and close out this executive task.";
            
            notifyTaskCoordinator.TaskDueDate = (this.workflowProperties.Item["DelegateDueDate"] != null) ? Convert.ToDateTime(this.workflowProperties.Item["DelegateDueDate"]) : DateTime.Today.AddBusinessDays(dueDays);
            notifyTaskCoordinator.Source = string.Format("Executive Task ({0})", taskSource);
            notifyTaskCoordinator.Action = "Confirm";
        }

        private void setExecutiveTaskStatus3_ExecuteCode(object sender, EventArgs e)
        {
            SetExecutiveTaskStatus("Confirmed Completion");
        }

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {

        }
    }
}
