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
    public sealed partial class Digital_Signatures
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
            this.AcquireDigitalSignatureActivity = new CustomActivities.NotifyAgendaContributor();
            this.codeSetStatus = new System.Workflow.Activities.CodeActivity();
            this.replicatorActivity1 = new System.Workflow.Activities.ReplicatorActivity();
            this.codeSetStatusGettingDS = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // AcquireDigitalSignatureActivity
            // 
            this.AcquireDigitalSignatureActivity.Name = "AcquireDigitalSignatureActivity";
            this.AcquireDigitalSignatureActivity.TaskAssignedTo = null;
            this.AcquireDigitalSignatureActivity.TaskDescription = null;
            this.AcquireDigitalSignatureActivity.TaskDueDate = new System.DateTime(((long)(0)));
            this.AcquireDigitalSignatureActivity.TaskTitle = null;
            // 
            // codeSetStatus
            // 
            this.codeSetStatus.Name = "codeSetStatus";
            this.codeSetStatus.ExecuteCode += new System.EventHandler(this.codeSetStatus_ExecuteCode);
            activitybind1.Name = "Digital_Signatures";
            activitybind1.Path = "signatories";
            // 
            // replicatorActivity1
            // 
            this.replicatorActivity1.Activities.Add(this.AcquireDigitalSignatureActivity);
            this.replicatorActivity1.ExecutionType = System.Workflow.Activities.ExecutionType.Parallel;
            this.replicatorActivity1.Name = "replicatorActivity1";
            this.replicatorActivity1.ChildInitialized += new System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs>(this.replicatorActivity1_ChildInitialized);
            this.replicatorActivity1.Initialized += new System.EventHandler(this.replicatorActivity1_Initialized);
            this.replicatorActivity1.SetBinding(System.Workflow.Activities.ReplicatorActivity.InitialChildDataProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // codeSetStatusGettingDS
            // 
            this.codeSetStatusGettingDS.Name = "codeSetStatusGettingDS";
            this.codeSetStatusGettingDS.ExecuteCode += new System.EventHandler(this.codeSetStatusGettingDS_ExecuteCode);
            activitybind3.Name = "Digital_Signatures";
            activitybind3.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "Digital_Signatures";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind2.Name = "Digital_Signatures";
            activitybind2.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // Digital_Signatures
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.codeSetStatusGettingDS);
            this.Activities.Add(this.replicatorActivity1);
            this.Activities.Add(this.codeSetStatus);
            this.Name = "Digital_Signatures";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity codeSetStatus;

        private CustomActivities.NotifyAgendaContributor AcquireDigitalSignatureActivity;

        private ReplicatorActivity replicatorActivity1;

        private CodeActivity codeSetStatusGettingDS;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;














    }
}
