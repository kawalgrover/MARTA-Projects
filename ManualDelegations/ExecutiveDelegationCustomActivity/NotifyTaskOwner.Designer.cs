using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CustomActivities
{
    public partial class NotifyTaskOwner
    {
        #region Activity Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("", "")]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            this.onTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.completeExecutiveTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.executiveTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            // 
            // onTaskChanged
            // 
            activitybind1.Name = "NotifyTaskOwner";
            activitybind1.Path = "onTaskChanged_AfterProperties";
            activitybind2.Name = "NotifyTaskOwner";
            activitybind2.Path = "onTaskChanged_BeforeProperties";
            correlationtoken1.Name = "executiveTask";
            correlationtoken1.OwnerActivityName = "NotifyTaskOwner";
            this.onTaskChanged.CorrelationToken = correlationtoken1;
            this.onTaskChanged.Executor = null;
            this.onTaskChanged.Name = "onTaskChanged";
            activitybind3.Name = "NotifyTaskOwner";
            activitybind3.Path = "executiveTask_TaskId";
            this.onTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onExecutiveTaskChanged_Invoked);
            this.onTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.onTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.onTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // completeExecutiveTask
            // 
            this.completeExecutiveTask.CorrelationToken = correlationtoken1;
            this.completeExecutiveTask.Name = "completeExecutiveTask";
            activitybind4.Name = "NotifyTaskOwner";
            activitybind4.Path = "executiveTask_TaskId";
            activitybind5.Name = "NotifyTaskOwner";
            activitybind5.Path = "completeExecutiveTask_TaskOutcome";
            this.completeExecutiveTask.MethodInvoking += new System.EventHandler(this.completeExecutiveTask_MethodInvoking);
            this.completeExecutiveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.completeExecutiveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // whileTaskIsNotComplete
            // 
            this.whileTaskIsNotComplete.Activities.Add(this.onTaskChanged);
            ruleconditionreference1.ConditionName = "Is Task Complete";
            this.whileTaskIsNotComplete.Condition = ruleconditionreference1;
            this.whileTaskIsNotComplete.Name = "whileTaskIsNotComplete";
            // 
            // executiveTask
            // 
            this.executiveTask.ContentTypeId = "0x01080100c55841431d2b4a00b96a229bf9b6b14d";
            this.executiveTask.CorrelationToken = correlationtoken1;
            this.executiveTask.ListItemId = -1;
            this.executiveTask.Name = "executiveTask";
            this.executiveTask.SpecialPermissions = null;
            activitybind6.Name = "NotifyTaskOwner";
            activitybind6.Path = "executiveTask_TaskId";
            activitybind7.Name = "NotifyTaskOwner";
            activitybind7.Path = "executiveTask_TaskProperties";
            this.executiveTask.MethodInvoking += new System.EventHandler(this.executiveTask_MethodInvoking);
            this.executiveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.executiveTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // NotifyTaskOwner
            // 
            this.Activities.Add(this.executiveTask);
            this.Activities.Add(this.whileTaskIsNotComplete);
            this.Activities.Add(this.completeExecutiveTask);
            this.Name = "NotifyTaskOwner";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeExecutiveTask;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType executiveTask;

        private WhileActivity whileTaskIsNotComplete;

















































    }
}
