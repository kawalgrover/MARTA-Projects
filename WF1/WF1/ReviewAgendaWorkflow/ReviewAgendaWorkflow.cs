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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using BoardAgendaWorkflows;
using System.Collections.Generic;
using Microsoft.SharePoint.Administration;

namespace BoardAgendaWorkflows
{
    public sealed partial class ReviewAgendaWorkflow : SequentialWorkflowActivity
    {
        public ReviewAgendaWorkflow()
        {
            InitializeComponent();
        }

        public Guid workflowId = new Guid("70a3c7b2-5a1b-4ade-b25e-d2147a46a090");
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public static readonly DependencyProperty WorkflowDataProperty =
           DependencyProperty.Register("WorkflowData", typeof(ReviewWFData), typeof(BoardAgendaWorkflows.ReviewAgendaWorkflow));


        public List<string> Reviewers;

        private const string FINANCE_OFFICE_NAME = "AGM-Finance";
        private const string IT_OFFICE_NAME = "AGM-Technology";
        private const string PLANNING_OFFICE_NAME = "AGM-Planning";
        private const string HUMANRESOURCES_OFFICE_NAME = "AGM-Human Resources";
        private const string SAFETY_OFFICE_NAME = "AGM-Safety and QA";
        private const string LEGAL_OFFICE_NAME = "AGM-Legal Services";
        private const string CONTRACTS_OFFICE_NAME = "AGM-Contracts and Procurement";
        private const string AUDIT_OFFICE_NAME = "AGM-Audit";
        private const string BUSOPERATIONS_OFFICE_NAME = "AGM-Bus Operations";
        private const string RAILOPERATIONS_OFFICE_NAME = "AGM-Rail Operations";
        private const string COMMUNICATIONS_OFFICE_NAME = "AGM-Communications and External Affairs";
        private const string POLICE_OFFICE_NAME = "AGM-Police";
        private const string EXECUTIVE_DIRECTOR = "Executive Director-DEO";

        private const string DGM = "DGM";
        private const string SPSS = "CBSS";
        private const string GM = "GM";

        public ReviewWFData WorkflowData
        {
            get
            {
                return (ReviewWFData)GetValue(WorkflowDataProperty);
            }
            set
            {
                SetValue(WorkflowDataProperty, value);
            }
        }

        private string defaultDocumentsLibraryName = null;
        private string libraryNameInDocumentWorkspace = null;
        private string boardSiteURL = null;
        private string boardMeetingListName = null;
        private string emisSiteURL = null;
        private string emisSiteRelativeURL = null;
        private string wfDueDateContext = null;

        public string AgendaTitle { get; set; }

        private void InitializeWebAppProperties()
        {
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = workflowProperties.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                if (webApplication.Properties.ContainsKey("DefaultDocumentsLibrary"))
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

        }

        private void codeSetStatusReviewStarted_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Review Started");
        }

        private void replicatorForReviewTasks_Initialized(object sender, EventArgs e)
        {
            SetReviewers();
            // Add the first task.
            int lastReviewerIndex = Reviewers.Count() - 1;
            notifyReviewersOfAgenda.TaskAssignedTo = Reviewers[lastReviewerIndex];
            notifyReviewersOfAgenda.TaskTitle = string.Format("Review content for Board Agenda - {0}", AgendaTitle);
            notifyReviewersOfAgenda.TaskDescription = string.Format("This task is for reviewing the content for a board agenda titled - {0}", AgendaTitle);
            notifyReviewersOfAgenda.TaskDueDate = DateTime.Today.AddDays(3);
            notifyReviewersOfAgenda.Source = "Paperless Board";
            notifyReviewersOfAgenda.Action = "Review";

        }

        private void replicatorForReviewTasks_ChildInitialized(object sender, ReplicatorChildEventArgs e)
        {
            notifyReviewersOfAgenda.TaskAssignedTo = e.InstanceData.ToString();
            notifyReviewersOfAgenda.TaskTitle = string.Format("Review content for Board Agenda - {0}", AgendaTitle);
            notifyReviewersOfAgenda.TaskDescription = string.Format("This task is for reviewing the content for a board agenda titled - {0}", AgendaTitle);
            notifyReviewersOfAgenda.TaskDueDate = DateTime.Today.AddDays(3);
            notifyReviewersOfAgenda.Source = "Paperless Board";
            notifyReviewersOfAgenda.Action = "Review";
        }

        private void codeSetStatusReviewCompleted_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Review Completed");
        }

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {
            using (StringReader stringReader = new StringReader(workflowProperties.InitiationData))
            {
                using (XmlReader reader = XmlReader.Create(stringReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ReviewWFData));
                    WorkflowData = (ReviewWFData)serializer.Deserialize(reader);
                }
            }

            SetReviewers();
            SetAgendaTitle();

            notifyAgendaOwner.Action = "Complete";
            notifyAgendaOwner.Source = "Paperless Board";
            notifyAgendaOwner.TaskTitle = string.Format("Edit documents for '{0}', and then start the Board Agenda Workflow.", AgendaTitle);
            notifyAgendaOwner.TaskDescription = string.Format("All the reviewers have finished reviewing content for this agenda. The Review Agenda workflow has been completed for Agenda {0}. The owner/sponsor of this agenda item now needs to start the Board Agenda workflow for this agenda.", AgendaTitle);
            notifyAgendaOwner.TaskDueDate = DateTime.Today.AddDays(1);

            SPUser originator = GetSPUser(this.workflowProperties.Item, "Sponsor");
            notifyAgendaOwner.TaskAssignedTo = originator.LoginName;
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

        private void SetReviewers()
        {
            Reviewers = new List<string>();
            if (bool.Parse(this.WorkflowData.AGM_Finance) == true)
            {
                Reviewers.Add(GetAGMOfficer(FINANCE_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Audit) == true)
            {
                Reviewers.Add(GetAGMOfficer(AUDIT_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_BusOperations) == true)
            {
                Reviewers.Add(GetAGMOfficer(BUSOPERATIONS_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Communications) == true)
            {
                Reviewers.Add(GetAGMOfficer(COMMUNICATIONS_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Contracts) == true)
            {
                Reviewers.Add(GetAGMOfficer(CONTRACTS_OFFICE_NAME));
            }

            if (bool.Parse(this.WorkflowData.AGM_HumanResource) == true)
            {
                Reviewers.Add(GetAGMOfficer(HUMANRESOURCES_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_IT) == true)
            {
                Reviewers.Add(GetAGMOfficer(IT_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Legal) == true)
            {
                Reviewers.Add(GetAGMOfficer(LEGAL_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Planning) == true)
            {
                Reviewers.Add(GetAGMOfficer(PLANNING_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Police) == true)
            {
                Reviewers.Add(GetAGMOfficer(POLICE_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_RaiOperations) == true)
            {
                Reviewers.Add(GetAGMOfficer(RAILOPERATIONS_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.AGM_Safety) == true)
            {
                Reviewers.Add(GetAGMOfficer(SAFETY_OFFICE_NAME));
            }
            if (bool.Parse(this.WorkflowData.Executive_Director) == true)
            {
                Reviewers.Add(GetAGMOfficer(EXECUTIVE_DIRECTOR));
            }
            if (bool.Parse(this.WorkflowData.CBSSSelected) == true)
            {
                Reviewers.Add(GetAGMOfficer(SPSS));
            }
            if (bool.Parse(this.WorkflowData.DGMSelected) == true)
            {
                Reviewers.Add(GetAGMOfficer(DGM));
            }
            if (bool.Parse(this.WorkflowData.GMSelected) == true)
            {
                Reviewers.Add(GetAGMOfficer(GM));
            }
            if (bool.Parse(this.WorkflowData.AdHocUser1Selected) == true)
            {
                Reviewers.Add(this.WorkflowData.AdHocUser1);
            }
            if (bool.Parse(this.WorkflowData.AdHocUser2Selected) == true)
            {
                Reviewers.Add(this.WorkflowData.AdHocUser2);
            }
            if (bool.Parse(this.WorkflowData.AdHocUser3Selected) == true)
            {
                Reviewers.Add(this.WorkflowData.AdHocUser3);
            }
            if (bool.Parse(this.WorkflowData.AdHocUser4Selected) == true)
            {
                Reviewers.Add(this.WorkflowData.AdHocUser4);
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

        private string GetAGMOfficerForAgenda()
        {
            string originatingAGMOffice;
            string originatingAGMOfficeExecutive = string.Empty;


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
                        originatingAGMOffice = item["AGM Office"].ToString();
                        originatingAGMOfficeExecutive = GetAGMOfficer(originatingAGMOffice);
                        break;
                    }
                }
            }

            return originatingAGMOfficeExecutive;

        }

        private string GetAGMOfficer(string AGMOffice)
        {
            SPSite site = workflowProperties.Site;
            this.InitializeWebAppProperties();
            using (SPWeb emisWebSite = site.OpenWeb(emisSiteRelativeURL))
            {
                SPList agmList = emisWebSite.Lists["Executives"]; //TODO: Should also come from configuration

                foreach (SPListItem li in agmList.Items)
                {
                    if (li["Executive Position"].ToString() == AGMOffice)
                    {
                        SPUser spUser = GetSPUser(li, "Executive");
                        return (spUser != null) ? spUser.LoginName : null;
                    }
                }

                // If you got here, then the AGM Office was not in the list
                return null;
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

        bool _isAGMReviewTaskComplete = false;

        public Guid statusFieldID = new Guid("c15b34c3-ce7d-490a-b133-3f4de8801b76");

        public Guid createTaskforAGMReview_TaskId = default(System.Guid);

        public SPWorkflowTaskProperties createTaskforAGMReview_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void createTaskforAGMReview_MethodInvoking(object sender, EventArgs e)
        {
            createTaskforAGMReview_TaskId = Guid.NewGuid();
            createTaskforAGMReview.TaskProperties.Title = string.Format("Initial Review by sponsoring AGM for '{0}'", AgendaTitle);
            createTaskforAGMReview.TaskProperties.Description = "This task is for the originating AGM for the Agenda to review the content before it is sent out for an initial Review to other members";
            createTaskforAGMReview.TaskProperties.AssignedTo = GetAGMOfficerForAgenda();
            createTaskforAGMReview.TaskProperties.PercentComplete = 0;
            createTaskforAGMReview.TaskProperties.StartDate = DateTime.Today;
            createTaskforAGMReview.TaskProperties.DueDate = DateTime.Today.AddDays(3);
            createTaskforAGMReview.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            createTaskforAGMReview.TaskProperties.ExtendedProperties["ActionOwed"] = "Review";
        }

        public SPWorkflowTaskProperties onAGMReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            if (onAGMReviewTaskChanged.AfterProperties.ExtendedProperties[statusFieldID] != null)
            {
                string taskStatus = onAGMReviewTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

                if (taskStatus != null)
                {
                    if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                    {
                        this._isAGMReviewTaskComplete = true;
                    }
                }
            }
        }

    }
}
