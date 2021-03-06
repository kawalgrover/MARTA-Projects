﻿using System;
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
    public partial class NotifyAgendaContributor : SequenceActivity
    {
        public NotifyAgendaContributor()
        {
            InitializeComponent();
        }

        bool _isAgendaContributorTaskComplete = false;
        public Guid contentContributorTask_TaskId = default(System.Guid);
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties contentContributorTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid statusFieldID = new Guid("c15b34c3-ce7d-490a-b133-3f4de8801b76");

        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskAssignedTo { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string Source { get; set; }
        public string Action { get; set; }

        private void contentContributorTask_MethodInvoking(object sender, EventArgs e)
        {
            contentContributorTask_TaskId = Guid.NewGuid();
            contentContributorTask.TaskProperties.Title = TaskTitle;
            contentContributorTask.TaskProperties.Description = TaskDescription;
            contentContributorTask.TaskProperties.AssignedTo = TaskAssignedTo;
            contentContributorTask.TaskProperties.PercentComplete = 0;
            contentContributorTask.TaskProperties.StartDate = DateTime.Today;
            contentContributorTask.TaskProperties.DueDate = TaskDueDate;
            contentContributorTask.TaskProperties.ExtendedProperties["TaskSource"] = Source;
            contentContributorTask.TaskProperties.ExtendedProperties["ActionOwed"] = Action;
        }

        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties onContentContributorTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties onContentContributorTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onContentContributorTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            if (onContentContributorTaskChanged.AfterProperties.ExtendedProperties[statusFieldID] != null)
            {
                string taskStatus = onContentContributorTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

                if (taskStatus != null)
                {
                    if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                    {
                        this._isAgendaContributorTaskComplete = true;
                    }
                }
            }
        }

        public String completeContentContributorTask_TaskOutcome = default(System.String);

        private void completeContentContributorTask_MethodInvoking(object sender, EventArgs e)
        {
            completeContentContributorTask_TaskOutcome = "Task Complete";
        }








        //private void onContributorTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        //{
        //    createContributorTask_TaskId = Guid.NewGuid();
        //    createContributorTask.TaskProperties.Title = "Contribute Content for Agenda";
        //    createContributorTask.TaskProperties.Description = "This task is for contributing content for the Board Agenda";
        //    createContributorTask.TaskProperties.AssignedTo = "MARTA\kgrover";
        //    createContributorTask.TaskProperties.PercentComplete = 0;
        //    createContributorTask.TaskProperties.StartDate = 
        //}
    }
}
