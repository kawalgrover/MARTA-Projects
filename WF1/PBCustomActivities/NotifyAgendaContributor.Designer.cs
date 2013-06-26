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
    public partial class NotifyAgendaContributor
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
            this.onContentContributorTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.completeContentContributorTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.whileContributorTaskIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.contentContributorTask = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            // 
            // onContentContributorTaskChanged
            // 
            activitybind1.Name = "NotifyAgendaContributor";
            activitybind1.Path = "onContentContributorTaskChanged_AfterProperties";
            activitybind2.Name = "NotifyAgendaContributor";
            activitybind2.Path = "onContentContributorTaskChanged_BeforeProperties";
            correlationtoken1.Name = "contentContributorTask";
            correlationtoken1.OwnerActivityName = "NotifyAgendaContributor";
            this.onContentContributorTaskChanged.CorrelationToken = correlationtoken1;
            this.onContentContributorTaskChanged.Executor = null;
            this.onContentContributorTaskChanged.Name = "onContentContributorTaskChanged";
            activitybind3.Name = "NotifyAgendaContributor";
            activitybind3.Path = "contentContributorTask_TaskId";
            this.onContentContributorTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onContentContributorTaskChanged_Invoked);
            this.onContentContributorTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.onContentContributorTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.onContentContributorTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // completeContentContributorTask
            // 
            this.completeContentContributorTask.CorrelationToken = correlationtoken1;
            this.completeContentContributorTask.Name = "completeContentContributorTask";
            activitybind4.Name = "NotifyAgendaContributor";
            activitybind4.Path = "contentContributorTask_TaskId";
            activitybind5.Name = "NotifyAgendaContributor";
            activitybind5.Path = "completeContentContributorTask_TaskOutcome";
            this.completeContentContributorTask.MethodInvoking += new System.EventHandler(this.completeContentContributorTask_MethodInvoking);
            this.completeContentContributorTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.completeContentContributorTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // whileContributorTaskIsNotComplete
            // 
            this.whileContributorTaskIsNotComplete.Activities.Add(this.onContentContributorTaskChanged);
            ruleconditionreference1.ConditionName = "Is Contributor Task Complete";
            this.whileContributorTaskIsNotComplete.Condition = ruleconditionreference1;
            this.whileContributorTaskIsNotComplete.Name = "whileContributorTaskIsNotComplete";
            // 
            // contentContributorTask
            // 
            this.contentContributorTask.ContentTypeId = "0x010801009ff2e2613a954fa5acf0cb96152cea6c";
            this.contentContributorTask.CorrelationToken = correlationtoken1;
            this.contentContributorTask.ListItemId = -1;
            this.contentContributorTask.Name = "contentContributorTask";
            this.contentContributorTask.SpecialPermissions = null;
            activitybind6.Name = "NotifyAgendaContributor";
            activitybind6.Path = "contentContributorTask_TaskId";
            activitybind7.Name = "NotifyAgendaContributor";
            activitybind7.Path = "contentContributorTask_TaskProperties";
            this.contentContributorTask.MethodInvoking += new System.EventHandler(this.contentContributorTask_MethodInvoking);
            this.contentContributorTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.contentContributorTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // NotifyAgendaContributor
            // 
            this.Activities.Add(this.contentContributorTask);
            this.Activities.Add(this.whileContributorTaskIsNotComplete);
            this.Activities.Add(this.completeContentContributorTask);
            this.Name = "NotifyAgendaContributor";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeContentContributorTask;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onContentContributorTaskChanged;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType contentContributorTask;

        private WhileActivity whileContributorTaskIsNotComplete;






























    }
}
