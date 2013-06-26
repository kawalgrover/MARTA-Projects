using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CustomActivities
{
    public partial class NotifyAgendaOwner : SequenceActivity
    {
        public NotifyAgendaOwner()
        {
            InitializeComponent();
        }

        bool _isAgendaOwnerTaskComplete = false;
        public Guid statusFieldID = new Guid("c15b34c3-ce7d-490a-b133-3f4de8801b76");

        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskAssignedTo { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string Source { get; set; }
        public string Action { get; set; }

        private void notifyAgendaOwnerTask_MethodInvoking(object sender, EventArgs e)
        {
            notifyAgendaOwnerTask_TaskId = Guid.NewGuid();
            notifyAgendaOwnerTask.TaskProperties.Title = TaskTitle;
            notifyAgendaOwnerTask.TaskProperties.Description = TaskDescription;
            notifyAgendaOwnerTask.TaskProperties.AssignedTo = TaskAssignedTo;
            notifyAgendaOwnerTask.TaskProperties.PercentComplete = 0;
            notifyAgendaOwnerTask.TaskProperties.StartDate = DateTime.Today;
            notifyAgendaOwnerTask.TaskProperties.DueDate = TaskDueDate;
            notifyAgendaOwnerTask.TaskProperties.ExtendedProperties["TaskSource"] = Source;
            notifyAgendaOwnerTask.TaskProperties.ExtendedProperties["ActionOwed"] = Action;
        }

        public Guid notifyAgendaOwnerTask_TaskId = default(System.Guid);
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties notifyAgendaOwnerTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties onNotifyOwnerTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties onNotifyOwnerTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onNotifyOwnerTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            if (onNotifyOwnerTaskChanged.AfterProperties.ExtendedProperties[statusFieldID] != null)
            {
                string taskStatus = onNotifyOwnerTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

                if (taskStatus != null)
                {
                    if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                    {
                        this._isAgendaOwnerTaskComplete = true;
                    }
                }
            }
        }

        public Guid onNotifyOwnerTaskChanged_TaskId = default(System.Guid);



        public String completeAgendaOwnerTask_TaskOutcome = default(System.String);

        private void completeAgendaOwnerTask_MethodInvoking(object sender, EventArgs e)
        {
            completeAgendaOwnerTask_TaskOutcome = "Task Complete";
        }








    }
}
