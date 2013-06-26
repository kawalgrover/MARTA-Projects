using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace WF1.Workflow1
{
    public sealed partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            this.onTaskChanged1 = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.completeTask1 = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileActivity1 = new System.Workflow.Activities.WhileActivity();
            this.createTaskWithContentType1 = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail1 = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // onTaskChanged1
            // 
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "Task1Changed1_AfterProperties";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "Task1Changed1_BeforeProperties1";
            correlationtoken1.Name = "task1";
            correlationtoken1.OwnerActivityName = "Workflow1";
            this.onTaskChanged1.CorrelationToken = correlationtoken1;
            this.onTaskChanged1.Executor = null;
            this.onTaskChanged1.Name = "onTaskChanged1";
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "task1Guid";
            this.onTaskChanged1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.task1Changed1Invoke);
            this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.onTaskChanged1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.onTaskChanged1);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // completeTask1
            // 
            this.completeTask1.CorrelationToken = correlationtoken1;
            this.completeTask1.Name = "completeTask1";
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "task1Guid";
            activitybind5.Name = "Workflow1";
            activitybind5.Path = "Task1Outcome1";
            this.completeTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.completeTask1.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // whileActivity1
            // 
            this.whileActivity1.Activities.Add(this.sequenceActivity1);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.while1Invoke);
            this.whileActivity1.Condition = codecondition1;
            this.whileActivity1.Name = "whileActivity1";
            // 
            // createTaskWithContentType1
            // 
            activitybind6.Name = "Workflow1";
            activitybind6.Path = "task1ContentTypeId1";
            this.createTaskWithContentType1.CorrelationToken = correlationtoken1;
            this.createTaskWithContentType1.ListItemId = -1;
            this.createTaskWithContentType1.Name = "createTaskWithContentType1";
            this.createTaskWithContentType1.SpecialPermissions = null;
            activitybind7.Name = "Workflow1";
            activitybind7.Path = "task1Guid";
            activitybind8.Name = "Workflow1";
            activitybind8.Path = "task1Properties";
            this.createTaskWithContentType1.MethodInvoking += new System.EventHandler(this.createTask1Invoke);
            this.createTaskWithContentType1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.ContentTypeIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.createTaskWithContentType1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.createTaskWithContentType1.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            // 
            // logToHistoryListActivity1
            // 
            this.logToHistoryListActivity1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind9.Name = "Workflow1";
            activitybind9.Path = "WorkflowData.TechnologyManager";
            this.logToHistoryListActivity1.HistoryOutcome = "";
            this.logToHistoryListActivity1.Name = "logToHistoryListActivity1";
            this.logToHistoryListActivity1.OtherData = "";
            this.logToHistoryListActivity1.UserId = -1;
            this.logToHistoryListActivity1.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            // 
            // sendEmail1
            // 
            this.sendEmail1.BCC = null;
            this.sendEmail1.Body = "TEST from WF1";
            this.sendEmail1.CC = null;
            correlationtoken2.Name = "workflowToken";
            correlationtoken2.OwnerActivityName = "Workflow1";
            this.sendEmail1.CorrelationToken = correlationtoken2;
            this.sendEmail1.From = null;
            this.sendEmail1.Headers = null;
            this.sendEmail1.IncludeStatus = false;
            this.sendEmail1.Name = "sendEmail1";
            this.sendEmail1.Subject = null;
            this.sendEmail1.To = "kgrover@itsmarta.com";
            this.sendEmail1.MethodInvoking += new System.EventHandler(this.sendEmail1_MethodInvoking);
            activitybind11.Name = "Workflow1";
            activitybind11.Path = "workflowId";
            activitybind12.Name = "Workflow1";
            activitybind12.Path = "onWorkflowActivated1_Roles1";
            // 
            // onWorkflowActivated1
            // 
            this.onWorkflowActivated1.CorrelationToken = correlationtoken2;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind10.Name = "Workflow1";
            activitybind10.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            this.onWorkflowActivated1.SetBinding(System.Workflow.Activities.HandleExternalEventActivity.RolesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            // 
            // Workflow1
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.sendEmail1);
            this.Activities.Add(this.logToHistoryListActivity1);
            this.Activities.Add(this.createTaskWithContentType1);
            this.Activities.Add(this.whileActivity1);
            this.Activities.Add(this.completeTask1);
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeTask1;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged1;

        private SequenceActivity sequenceActivity1;

        private WhileActivity whileActivity1;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createTaskWithContentType1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity1;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail1;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;


































    }
}
