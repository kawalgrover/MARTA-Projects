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

namespace ExecutiveTaskTracking.Executive_Task_Tracking_Workflow
{
    public sealed partial class Executive_Task_Tracking_Workflow
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
            this.notifyTaskOwner = new CustomActivities.NotifyTaskOwner();
            this.setExecutiveTaskStatus3 = new System.Workflow.Activities.CodeActivity();
            this.notifyTaskCoordinator = new CustomActivities.NotifyTaskOwner();
            this.setExecutiveTaskStatus2 = new System.Workflow.Activities.CodeActivity();
            this.replicatorForExecutiveTasks = new System.Workflow.Activities.ReplicatorActivity();
            this.setExecutiveTaskStatus1 = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // notifyTaskOwner
            // 
            this.notifyTaskOwner.Action = null;
            this.notifyTaskOwner.Name = "notifyTaskOwner";
            this.notifyTaskOwner.Source = null;
            this.notifyTaskOwner.TaskAssignedTo = null;
            this.notifyTaskOwner.TaskDescription = null;
            this.notifyTaskOwner.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyTaskOwner.TaskTitle = null;
            // 
            // setExecutiveTaskStatus3
            // 
            this.setExecutiveTaskStatus3.Name = "setExecutiveTaskStatus3";
            this.setExecutiveTaskStatus3.ExecuteCode += new System.EventHandler(this.setExecutiveTaskStatus3_ExecuteCode);
            // 
            // notifyTaskCoordinator
            // 
            this.notifyTaskCoordinator.Action = null;
            this.notifyTaskCoordinator.Name = "notifyTaskCoordinator";
            this.notifyTaskCoordinator.Source = null;
            this.notifyTaskCoordinator.TaskAssignedTo = null;
            this.notifyTaskCoordinator.TaskDescription = null;
            this.notifyTaskCoordinator.TaskDueDate = new System.DateTime(((long)(0)));
            this.notifyTaskCoordinator.TaskTitle = null;
            // 
            // setExecutiveTaskStatus2
            // 
            this.setExecutiveTaskStatus2.Name = "setExecutiveTaskStatus2";
            this.setExecutiveTaskStatus2.ExecuteCode += new System.EventHandler(this.setExecutiveTaskStatus2_ExecuteCode);
            activitybind1.Name = "Executive_Task_Tracking_Workflow";
            activitybind1.Path = "assignees";
            // 
            // replicatorForExecutiveTasks
            // 
            this.replicatorForExecutiveTasks.Activities.Add(this.notifyTaskOwner);
            this.replicatorForExecutiveTasks.ExecutionType = System.Workflow.Activities.ExecutionType.Parallel;
            this.replicatorForExecutiveTasks.Name = "replicatorForExecutiveTasks";
            this.replicatorForExecutiveTasks.ChildInitialized += new System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs>(this.replicatorForExecutiveTasks_ChildInitialized);
            this.replicatorForExecutiveTasks.Initialized += new System.EventHandler(this.replicatorForExecutiveTasks_Initialized);
            this.replicatorForExecutiveTasks.SetBinding(System.Workflow.Activities.ReplicatorActivity.InitialChildDataProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            // 
            // setExecutiveTaskStatus1
            // 
            this.setExecutiveTaskStatus1.Name = "setExecutiveTaskStatus1";
            this.setExecutiveTaskStatus1.ExecuteCode += new System.EventHandler(this.setExecutiveTaskStatus1_ExecuteCode);
            activitybind3.Name = "Executive_Task_Tracking_Workflow";
            activitybind3.Path = "workflowId";
            // 
            // onWorkflowActivated1
            // 
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "Executive_Task_Tracking_Workflow";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind2.Name = "Executive_Task_Tracking_Workflow";
            activitybind2.Path = "workflowProperties";
            this.onWorkflowActivated1.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // Executive_Task_Tracking_Workflow
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.setExecutiveTaskStatus1);
            this.Activities.Add(this.replicatorForExecutiveTasks);
            this.Activities.Add(this.setExecutiveTaskStatus2);
            this.Activities.Add(this.notifyTaskCoordinator);
            this.Activities.Add(this.setExecutiveTaskStatus3);
            this.Name = "Executive_Task_Tracking_Workflow";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity setExecutiveTaskStatus3;

        private CustomActivities.NotifyTaskOwner notifyTaskCoordinator;

        private CodeActivity setExecutiveTaskStatus2;

        private CustomActivities.NotifyTaskOwner notifyTaskOwner;

        private ReplicatorActivity replicatorForExecutiveTasks;

        private CodeActivity setExecutiveTaskStatus1;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;










    }
}
