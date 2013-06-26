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
    public partial class NotifyAgendaOwner
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
            this.onNotifyOwnerTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.completeAgendaOwnerTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileNotifyOwnerTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.notifyAgendaOwnerTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            // 
            // onNotifyOwnerTaskChanged
            // 
            activitybind1.Name = "NotifyAgendaOwner";
            activitybind1.Path = "onNotifyOwnerTaskChanged_AfterProperties";
            activitybind2.Name = "NotifyAgendaOwner";
            activitybind2.Path = "onNotifyOwnerTaskChanged_BeforeProperties";
            correlationtoken1.Name = "notifyAgendaOwnerTask";
            correlationtoken1.OwnerActivityName = "NotifyAgendaOwner";
            this.onNotifyOwnerTaskChanged.CorrelationToken = correlationtoken1;
            this.onNotifyOwnerTaskChanged.Executor = null;
            this.onNotifyOwnerTaskChanged.Name = "onNotifyOwnerTaskChanged";
            activitybind3.Name = "NotifyAgendaOwner";
            activitybind3.Path = "notifyAgendaOwnerTask_TaskId";
            this.onNotifyOwnerTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onNotifyOwnerTaskChanged_Invoked);
            this.onNotifyOwnerTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.onNotifyOwnerTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.onNotifyOwnerTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // completeAgendaOwnerTask
            // 
            this.completeAgendaOwnerTask.CorrelationToken = correlationtoken1;
            this.completeAgendaOwnerTask.Name = "completeAgendaOwnerTask";
            activitybind4.Name = "NotifyAgendaOwner";
            activitybind4.Path = "notifyAgendaOwnerTask_TaskId";
            activitybind5.Name = "NotifyAgendaOwner";
            activitybind5.Path = "completeAgendaOwnerTask_TaskOutcome";
            this.completeAgendaOwnerTask.MethodInvoking += new System.EventHandler(this.completeAgendaOwnerTask_MethodInvoking);
            this.completeAgendaOwnerTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.completeAgendaOwnerTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // whileNotifyOwnerTaskIsNotComplete
            // 
            this.whileNotifyOwnerTaskIsNotComplete.Activities.Add(this.onNotifyOwnerTaskChanged);
            ruleconditionreference1.ConditionName = "While Owner Task is NOT complete";
            this.whileNotifyOwnerTaskIsNotComplete.Condition = ruleconditionreference1;
            this.whileNotifyOwnerTaskIsNotComplete.Name = "whileNotifyOwnerTaskIsNotComplete";
            // 
            // notifyAgendaOwnerTask
            // 
            this.notifyAgendaOwnerTask.ContentTypeId = "0x010801009ff2e2613a954fa5acf0cb96152cea6c";
            this.notifyAgendaOwnerTask.CorrelationToken = correlationtoken1;
            this.notifyAgendaOwnerTask.ListItemId = -1;
            this.notifyAgendaOwnerTask.Name = "notifyAgendaOwnerTask";
            this.notifyAgendaOwnerTask.SpecialPermissions = null;
            activitybind6.Name = "NotifyAgendaOwner";
            activitybind6.Path = "notifyAgendaOwnerTask_TaskId";
            activitybind7.Name = "NotifyAgendaOwner";
            activitybind7.Path = "notifyAgendaOwnerTask_TaskProperties";
            this.notifyAgendaOwnerTask.MethodInvoking += new System.EventHandler(this.notifyAgendaOwnerTask_MethodInvoking);
            this.notifyAgendaOwnerTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.notifyAgendaOwnerTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // NotifyAgendaOwner
            // 
            this.Activities.Add(this.notifyAgendaOwnerTask);
            this.Activities.Add(this.whileNotifyOwnerTaskIsNotComplete);
            this.Activities.Add(this.completeAgendaOwnerTask);
            this.Name = "NotifyAgendaOwner";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeAgendaOwnerTask;

        private WhileActivity whileNotifyOwnerTaskIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onNotifyOwnerTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType notifyAgendaOwnerTask;









































































    }
}
