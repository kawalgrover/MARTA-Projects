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

namespace BoardAgendaWorkflows
{
    public sealed partial class ReviewAgendaWorkflow
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
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            this.onAGMReviewTaskChanged = new Microsoft.SharePoint.WorkflowActions.OnTaskChanged();
            this.notifyReviewersOfAgenda = new CustomActivities.NotifyAgendaContributor();
            this.whileAGMReviewIsNotComplete = new System.Workflow.Activities.WhileActivity();
            this.createTaskforAGMReview = new Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType();
            this.notifyAgendaOwner = new CustomActivities.NotifyAgendaOwner();
            this.codeSetStatusReviewCompleted = new System.Workflow.Activities.CodeActivity();
            this.replicatorForReviewTasks = new System.Workflow.Activities.ReplicatorActivity();
            this.completeAGMReviewTask = new Microsoft.SharePoint.WorkflowActions.CompleteTask();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.codeSetStatusReviewStarted = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // onAGMReviewTaskChanged
            // 
            activitybind1.Name = "ReviewAgendaWorkflow";
            activitybind1.Path = "onAGMReviewTaskChanged_AfterProperties";
            activitybind2.Name = "ReviewAgendaWorkflow";
            activitybind2.Path = "onAGMReviewTaskChanged_BeforeProperties";
            correlationtoken1.Name = "AGMReviewTask";
            correlationtoken1.OwnerActivityName = "ReviewAgendaWorkflow";
            this.onAGMReviewTaskChanged.CorrelationToken = correlationtoken1;
            this.onAGMReviewTaskChanged.Executor = null;
            this.onAGMReviewTaskChanged.Name = "onAGMReviewTaskChanged";
            activitybind3.Name = "ReviewAgendaWorkflow";
            activitybind3.Path = "createTaskforAGMReview_TaskId";
            this.onAGMReviewTaskChanged.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onAGMReviewTaskChanged_Invoked);
            this.onAGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.onAGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.onAGMReviewTaskChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.BeforePropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // notifyReviewersOfAgenda
            // 
            this.notifyReviewersOfAgenda.Action = null;
            this.notifyReviewersOfAgenda.Name = "notifyReviewersOfAgenda";
            this.notifyReviewersOfAgenda.Source = null;
            this.notifyReviewersOfAgenda.TaskAssignedTo = null;
            this.notifyReviewersOfAgenda.TaskDescription = null;
            this.notifyReviewersOfAgenda.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyReviewersOfAgenda.TaskTitle = null;
            // 
            // whileAGMReviewIsNotComplete
            // 
            this.whileAGMReviewIsNotComplete.Activities.Add(this.onAGMReviewTaskChanged);
            ruleconditionreference1.ConditionName = "While AGMReviewTask is NOT complete";
            this.whileAGMReviewIsNotComplete.Condition = ruleconditionreference1;
            this.whileAGMReviewIsNotComplete.Name = "whileAGMReviewIsNotComplete";
            // 
            // createTaskforAGMReview
            // 
            this.createTaskforAGMReview.ContentTypeId = "0x010801009ff2e2613a954fa5acf0cb96152cea6c";
            this.createTaskforAGMReview.CorrelationToken = correlationtoken1;
            this.createTaskforAGMReview.ListItemId = -1;
            this.createTaskforAGMReview.Name = "createTaskforAGMReview";
            this.createTaskforAGMReview.SpecialPermissions = null;
            activitybind4.Name = "ReviewAgendaWorkflow";
            activitybind4.Path = "createTaskforAGMReview_TaskId";
            activitybind5.Name = "ReviewAgendaWorkflow";
            activitybind5.Path = "createTaskforAGMReview_TaskProperties";
            this.createTaskforAGMReview.MethodInvoking += new System.EventHandler(this.createTaskforAGMReview_MethodInvoking);
            this.createTaskforAGMReview.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.createTaskforAGMReview.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType.TaskPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            // 
            // notifyAgendaOwner
            // 
            this.notifyAgendaOwner.Action = "Complete";
            this.notifyAgendaOwner.Name = "notifyAgendaOwner";
            this.notifyAgendaOwner.Source = "Paperless Board";
            this.notifyAgendaOwner.TaskAssignedTo = null;
            this.notifyAgendaOwner.TaskDescription = null;
            this.notifyAgendaOwner.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyAgendaOwner.TaskTitle = null;
            // 
            // codeSetStatusReviewCompleted
            // 
            this.codeSetStatusReviewCompleted.Name = "codeSetStatusReviewCompleted";
            this.codeSetStatusReviewCompleted.ExecuteCode += new System.EventHandler(this.codeSetStatusReviewCompleted_ExecuteCode);
            activitybind6.Name = "ReviewAgendaWorkflow";
            activitybind6.Path = "Reviewers";
            // 
            // replicatorForReviewTasks
            // 
            this.replicatorForReviewTasks.Activities.Add(this.notifyReviewersOfAgenda);
            this.replicatorForReviewTasks.ExecutionType = System.Workflow.Activities.ExecutionType.Parallel;
            this.replicatorForReviewTasks.Name = "replicatorForReviewTasks";
            this.replicatorForReviewTasks.ChildInitialized += new System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs>(this.replicatorForReviewTasks_ChildInitialized);
            this.replicatorForReviewTasks.Initialized += new System.EventHandler(this.replicatorForReviewTasks_Initialized);
            this.replicatorForReviewTasks.SetBinding(System.Workflow.Activities.ReplicatorActivity.InitialChildDataProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            // 
            // completeAGMReviewTask
            // 
            this.completeAGMReviewTask.CorrelationToken = correlationtoken1;
            this.completeAGMReviewTask.Name = "completeAGMReviewTask";
            activitybind7.Name = "ReviewAgendaWorkflow";
            activitybind7.Path = "createTaskforAGMReview_TaskId";
            this.completeAGMReviewTask.TaskOutcome = null;
            this.completeAGMReviewTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CompleteTask.TaskIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.createTaskforAGMReview);
            this.sequenceActivity1.Activities.Add(this.whileAGMReviewIsNotComplete);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // codeSetStatusReviewStarted
            // 
            this.codeSetStatusReviewStarted.Name = "codeSetStatusReviewStarted";
            this.codeSetStatusReviewStarted.ExecuteCode += new System.EventHandler(this.codeSetStatusReviewStarted_ExecuteCode);
            activitybind9.Name = "ReviewAgendaWorkflow";
            activitybind9.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            correlationtoken2.Name = "workflowToken";
            correlationtoken2.OwnerActivityName = "ReviewAgendaWorkflow";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken2;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind8.Name = "ReviewAgendaWorkflow";
            activitybind8.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            // 
            // ReviewAgendaWorkflow
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.codeSetStatusReviewStarted);
            this.Activities.Add(this.sequenceActivity1);
            this.Activities.Add(this.completeAGMReviewTask);
            this.Activities.Add(this.replicatorForReviewTasks);
            this.Activities.Add(this.codeSetStatusReviewCompleted);
            this.Activities.Add(this.notifyAgendaOwner);
            this.Name = "ReviewAgendaWorkflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private CustomActivities.NotifyAgendaOwner notifyAgendaOwner;

        private Microsoft.SharePoint.WorkflowActions.CompleteTask completeAGMReviewTask;

        private Microsoft.SharePoint.WorkflowActions.OnTaskChanged onAGMReviewTaskChanged;

        private WhileActivity whileAGMReviewIsNotComplete;

        private Microsoft.SharePoint.WorkflowActions.CreateTaskWithContentType createTaskforAGMReview;

        private SequenceActivity sequenceActivity1;

        private ReplicatorActivity replicatorForReviewTasks;

        private CodeActivity codeSetStatusReviewStarted;

        private CustomActivities.NotifyAgendaContributor notifyReviewersOfAgenda;

        private CodeActivity codeSetStatusReviewCompleted;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;





















    }
}
