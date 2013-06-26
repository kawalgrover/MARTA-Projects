using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;
using Microsoft.SharePoint.Administration;
using System.Text;
using PaperlessBoardWorkflows;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BoardAgendaWorkflows
{
    public sealed partial class NotifyCoordinatorsWorkflow : SequentialWorkflowActivity
    {
        public NotifyCoordinatorsWorkflow()
        {
            InitializeComponent();
        }

        public Guid workflowId = new Guid("d51bcc13-a86b-40db-b280-6d64464e8e4b");

        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public static readonly DependencyProperty WorkflowDataProperty =
            DependencyProperty.Register("WorkflowData", typeof(NotifyContributorsWFData), typeof(BoardAgendaWorkflows.NotifyCoordinatorsWorkflow));


        public NotifyContributorsWFData WorkflowData
        {
            get
            {
                return (NotifyContributorsWFData)GetValue(WorkflowDataProperty);
            }
            set
            {
                SetValue(WorkflowDataProperty, value);
            }
        }

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {
            using (StringReader stringReader = new StringReader(workflowProperties.InitiationData))
            {
                using (XmlReader reader = XmlReader.Create(stringReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(NotifyContributorsWFData));
                    WorkflowData = (NotifyContributorsWFData)serializer.Deserialize(reader);
                }
            }
            SetAgendaTitle();
            
            notifyAgendaOwner.Action = "Complete";
            notifyAgendaOwner.Source = "Paperless Board";
            notifyAgendaOwner.TaskTitle = string.Format("Edit documents for '{0}', and then start the Initial Review Workflow.", AgendaTitle);
            notifyAgendaOwner.TaskDescription = string.Format("The Content Contributor workflow has been completed for Agenda {0}. The owner/sponsor of this agenda item now needs to start the Review Agenda workflow for this agenda.", AgendaTitle);
            notifyAgendaOwner.TaskDueDate = DateTime.Today.AddDays(1);

            SPUser originator = GetSPUser(this.workflowProperties.Item, "Sponsor");
            notifyAgendaOwner.TaskAssignedTo = originator.LoginName;

                
        }

        private string defaultDocumentsLibraryName = null;
        private string libraryNameInDocumentWorkspace = null;
        private string boardSiteURL = null;
        private string boardMeetingListName = null;
        private string emisSiteURL = null;
        private string emisSiteRelativeURL = null;
        private string wfDueDateContext = null;

        public string AgendaTitle { get; set; }

        public List<string> assignees;

        private void InitializeWebAppProperties()
        {
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = workflowProperties.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {

                defaultDocumentsLibraryName = webApplication.Properties["DefaultDocumentsLibrary"].ToString();
                libraryNameInDocumentWorkspace = webApplication.Properties["LibraryNameInDocumentWorkspace"].ToString();
                boardSiteURL = webApplication.Properties["BoardSiteURL"].ToString();
                boardMeetingListName = webApplication.Properties["BoardMeetingListName"].ToString();
                emisSiteRelativeURL = webApplication.Properties["EmisSiteRelativeURL"].ToString();
                emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
                wfDueDateContext = webApplication.Properties["WFDueDateContext"].ToString();

            }

        }

        private SPUser GetSPUser(SPListItem item, string fieldName)
        {
            SPFieldUser field = item.Fields[fieldName] as SPFieldUser;
            if (field != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[fieldName].ToString()) as SPFieldUserValue;

                if (fieldValue != null)
                    return fieldValue.User;
            }
            return null;
        }

        private void UpdateWorkflowHistoryList(SPUser coordinator)
        {
            workflowProperties.Workflow.CreateHistoryEvent(
                (int)SPWorkflowHistoryEventType.None,
                0,
                workflowProperties.OriginatorUser,
                string.Format("Email Sent to {0}", coordinator.Name),
                "An email was sent to this user to add content for the agenda.",
                null
                );

        }

        private void SetAgendaTitle()
        {
            string AgendaID = this.workflowProperties.Item["AgendaID"].ToString();
            InitializeWebAppProperties();

            SPSite emisSite = workflowProperties.Site;
            using (SPWeb emisWeb = emisSite.OpenWeb(emisSiteRelativeURL))
            {
                SPList boardAgendaList = emisWeb.Lists["Board Agenda"];
                SPQuery query = new SPQuery()
                {
                    Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='ID' />
                                                  <Value Type='Counter'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", AgendaID)
                };

                foreach (SPListItem item in boardAgendaList.GetItems(query))
                {
                    if (item["ID"].ToString() == AgendaID)
                    {
                        AgendaTitle = item["Title"].ToString();
                        break;
                    }
                }
            }
        }

        private void SetAgendaStatus(string status)
        {
            string AgendaID = this.workflowProperties.Item["AgendaID"].ToString();
            InitializeWebAppProperties();


            SPSite emisSite = workflowProperties.Site;
            using (SPWeb emisWeb = emisSite.OpenWeb(emisSiteRelativeURL))
            {
                SPList boardAgendaList = emisWeb.Lists["Board Agenda"];
                SPQuery query = new SPQuery()
                {
                    Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='ID' />
                                                  <Value Type='Counter'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", AgendaID)
                };

                foreach (SPListItem item in boardAgendaList.GetItems(query))
                {
                    if (item["ID"].ToString() == AgendaID)
                    {
                        item["Agenda Status"] = status;
                        item.Update();
                        break;
                    }
                }
            }
        }

        private void codeSetStatus_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Adding Content");
        }

        private void replicatorForContributorTask_Initialized(object sender, EventArgs e)
        {
            assignees = new List<string>();
            string[] splitCharacters = new string[] { ";" };
            string[] contributors = WorkflowData.Contributors.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries);
            assignees = contributors.ToList();
            // Add the first task.
            int lastContributorIndex = contributors.Count() - 1;
            notifyAgendaContributor1.TaskAssignedTo = contributors[lastContributorIndex];
            notifyAgendaContributor1.TaskTitle = string.Format("Add Content for Board Agenda - {0}", AgendaTitle);
            notifyAgendaContributor1.TaskDescription = string.Format("This task is for adding content for the board agenda titled: {0}", AgendaTitle);
            notifyAgendaContributor1.TaskDueDate = DateTime.Today.AddDays(3);
            notifyAgendaContributor1.Source = "Paperless Board";
            notifyAgendaContributor1.Action = "Submit";

        }

        private void replicatorForContributorTask_ChildInitialized(object sender, ReplicatorChildEventArgs e)
        {
            notifyAgendaContributor1.TaskAssignedTo = e.InstanceData.ToString();
            notifyAgendaContributor1.TaskTitle = string.Format("Add Content for Board Agenda - {0}", AgendaTitle);
            notifyAgendaContributor1.TaskDescription = string.Format("This task is for adding content for the board agenda titled: {0}", AgendaTitle);
            notifyAgendaContributor1.TaskDueDate = DateTime.Today.AddDays(3);
            notifyAgendaContributor1.Source = "Paperless Board";
            notifyAgendaContributor1.Action = "Submit";
        }

        private void codeSetStatusContentAdded_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Content Added");
        }


    }

    
}
