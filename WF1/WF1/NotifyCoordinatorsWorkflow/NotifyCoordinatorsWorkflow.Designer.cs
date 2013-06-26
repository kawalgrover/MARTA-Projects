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
    public sealed partial class NotifyCoordinatorsWorkflow
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
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            this.notifyAgendaContributor1 = new CustomActivities.NotifyAgendaContributor();
            this.notifyAgendaOwner = new CustomActivities.NotifyAgendaOwner();
            this.codeSetStatusContentAdded = new System.Workflow.Activities.CodeActivity();
            this.replicatorForContributorTask = new System.Workflow.Activities.ReplicatorActivity();
            this.codeSetStatus = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // notifyAgendaContributor1
            // 
            this.notifyAgendaContributor1.Action = null;
            this.notifyAgendaContributor1.Name = "notifyAgendaContributor1";
            this.notifyAgendaContributor1.Source = null;
            this.notifyAgendaContributor1.TaskAssignedTo = null;
            this.notifyAgendaContributor1.TaskDescription = null;
            this.notifyAgendaContributor1.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyAgendaContributor1.TaskTitle = null;
            // 
            // notifyAgendaOwner
            // 
            this.notifyAgendaOwner.Action = null;
            this.notifyAgendaOwner.Name = "notifyAgendaOwner";
            this.notifyAgendaOwner.Source = null;
            this.notifyAgendaOwner.TaskAssignedTo = null;
            this.notifyAgendaOwner.TaskDescription = null;
            this.notifyAgendaOwner.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyAgendaOwner.TaskTitle = null;
            // 
            // codeSetStatusContentAdded
            // 
            this.codeSetStatusContentAdded.Name = "codeSetStatusContentAdded";
            this.codeSetStatusContentAdded.ExecuteCode += new System.EventHandler(this.codeSetStatusContentAdded_ExecuteCode);
            activitybind1.Name = "NotifyCoordinatorsWorkflow";
            activitybind1.Path = "assignees";
            // 
            // replicatorForContributorTask
            // 
            this.replicatorForContributorTask.Activities.Add(this.notifyAgendaContributor1);
            this.replicatorForContributorTask.ExecutionType = System.Workflow.Activities.ExecutionType.Parallel;
            this.replicatorForContributorTask.Name = "replicatorForContributorTask";
            this.replicatorForContributorTask.ChildInitialized += new System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs>(this.replicatorForContributorTask_ChildInitialized);
            this.replicatorForContributorTask.Initialized += new System.EventHandler(this.replicatorForContributorTask_Initialized);
            this.replicatorForContributorTask.SetBinding(System.Workflow.Activities.ReplicatorActivity.InitialChildDataProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // codeSetStatus
            // 
            this.codeSetStatus.Name = "codeSetStatus";
            this.codeSetStatus.ExecuteCode += new System.EventHandler(this.codeSetStatus_ExecuteCode);
            activitybind3.Name = "NotifyCoordinatorsWorkflow";
            activitybind3.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "NotifyCoordinatorsWorkflow";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind2.Name = "NotifyCoordinatorsWorkflow";
            activitybind2.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // NotifyCoordinatorsWorkflow
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.codeSetStatus);
            this.Activities.Add(this.replicatorForContributorTask);
            this.Activities.Add(this.codeSetStatusContentAdded);
            this.Activities.Add(this.notifyAgendaOwner);
            this.Name = "NotifyCoordinatorsWorkflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private CustomActivities.NotifyAgendaOwner notifyAgendaOwner;

        private CodeActivity codeSetStatusContentAdded;

        private CustomActivities.NotifyAgendaContributor notifyAgendaContributor1;

        private ReplicatorActivity replicatorForContributorTask;

        private CodeActivity codeSetStatus;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;















    }
}
