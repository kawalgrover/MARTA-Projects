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
using Microsoft.Office.DocumentManagement.DocumentSets;
using Microsoft.Office.Server.Utilities;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Meetings;
using System.Text;

namespace WF1
{
    public sealed partial class BoardAgendaWorkflow : SequentialWorkflowActivity
    {
        public BoardAgendaWorkflow()
        {
            InitializeComponent();
            //InitializeWebAppProperties();
        }

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

        private string defaultDocumentsLibraryName = null;
        private string libraryNameInDocumentWorkspace = null;
        private string boardSiteURL = null;
        private string boardMeetingListName = null;
        private string lookAheadListName = null;
        private string emisSiteURL = null;
        private string emisSiteRelativeURL = null;
        private string lookAheadListNameInEmis = null;
        private string wfDueDateContext = null;

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
                    lookAheadListName = webApplication.Properties["LookAheadListName"].ToString();
                    emisSiteRelativeURL = webApplication.Properties["EmisSiteRelativeURL"].ToString();
                    emisSiteURL = webApplication.Properties["EmisSiteURL"].ToString();
                    lookAheadListNameInEmis = webApplication.Properties["LookAheadListNameInEmis"].ToString();
                    wfDueDateContext = webApplication.Properties["WFDueDateContext"].ToString();
                }
            }

        }

        //public Guid workflowId = default(System.Guid);
        public Guid workflowId = new Guid("6187bbfa-fe27-4d3e-8a1b-b3ef3ab4922c");
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        #region Task related variables

        bool _isWorkflowComplete = false;

        bool _isAGMFinanceTaskCreated = false;
        bool _isAGMFinanceTaskComplete = false;
        bool _AGMFinanceApproved = false;

        bool _isAGMITTaskCreated = false;
        bool _isAGMITTaskComplete = false;
        bool _isAGMITTaskApproved = false;

        bool _isAGMPlanningTaskCreated = false;
        bool _isAGMPlanningTaskComplete = false;
        bool _isAGMPlanningTasApproved = false;

        bool _isAGMHumanResourcesTaskCreated = false;
        bool _isAGMHumanResourcesTaskComplete = false;
        bool _isAGMHumanResourcesTaskApproved = false;

        bool _isAGMSafetyTaskCreated = false;
        bool _isAGMSafetyTaskComplete = false;
        bool _isAGMSafetyTaskApproved = false;

        bool _isAGMLegalTaskCreated = false;
        bool _isAGMLegalTaskComplete = false;
        bool _isAGMLegalTaskApproved = false;

        bool _isAGMContractsTaskCreated = false;
        bool _isAGMContractsTaskComplete = false;
        bool _isAGMContractsTaskApproved = false;

        bool _isAGMAuditTaskCreated = false;
        bool _isAGMAuditTaskComplete = false;
        bool _isAGMAuditTaskApproved = false;

        bool _isAGMBusOperationsTaskCreated = false;
        bool _isAGMBusOperationsTaskComplete = false;
        bool _isAGMBusOperationsTaskApproved = false;

        bool _isAGMRailOperationsTaskCreated = false;
        bool _isAGMRailOperationsTaskComplete = false;
        bool _isAGMRailOperationsTaskApproved = false;

        bool _isAGMCommunicationsTaskCreated = false;
        bool _isAGMCommunicationsTaskComplete = false;
        bool _isAGMCommunicationsTaskApproved = false;

        bool _isAGMPoliceTaskCreated = false;
        bool _isAGMPoliceTaskComplete = false;
        bool _isAGMPoliceTaskApproved = false;

        bool _isAdhocUser1TaskCreated = false;
        bool _isAdhocUser1TaskComplete = false;
        bool _isAdhocUser1TaskApproved = false;

        bool _isAdhocUser2TaskCreated = false;
        bool _isAdhocUser2TaskComplete = false;
        bool _isAdhocUser2TaskApproved = false;

        bool _isAdhocUser3TaskCreated = false;
        bool _isAdhocUser3TaskComplete = false;
        bool _isAdhocUser3TaskApproved = false;

        bool _isAdhocUser4TaskCreated = false;
        bool _isAdhocUser4TaskComplete = false;
        bool _isAdhocUser4TaskApproved = false;


        bool _isSubmitForDGMApprovalTaskComplete = false;

        bool _isDGMReviewTaskComplete = false;
        bool _isSPSSReviewTaskComplete = false;
        bool _isDGMReviewTaskCreated = false;
        bool _isSPSSReviewTaskCreated = false;

        bool _isGMApproveTaskComplete = false;

        bool _isSubmtForGMApprovalTaskComplete = false;
        bool _isGMApproveTaskCreated = false;

        bool _isExpeditedDGMReviewTaskComplete = false;
        bool _isExpeditedCBSSReviewTaskComplete = false;

        bool _isExecutiveDirectorReviewTaskComplete = false;
        bool _isExecutiveDirectorReviewTaskCreated = false;

        bool _isDGMReReviewTaskComplete = false;
        bool _isCBSSReReviewTaskComplete = false;
        bool _isGMTaskApproved = false;

        bool _isGMReApproveTaskComplete = false;

        #endregion

        public AgendaWFData WorkflowData
        {
            get
            {
                return (AgendaWFData)GetValue(WorkflowDataProperty);
            }
            set
            {
                SetValue(WorkflowDataProperty, value);
            }
        }

        public string AgendaTitle { get; set; }

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
        public static readonly DependencyProperty WorkflowDataProperty =
            DependencyProperty.Register("WorkflowData", typeof(AgendaWFData), typeof(WF1.BoardAgendaWorkflow));


        private void OnWorkflowActivated_Invoked(object sender, ExternalDataEventArgs e)
        {
            using (StringReader stringReader = new StringReader(workflowProperties.InitiationData))
            {
                using (XmlReader reader = XmlReader.Create(stringReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AgendaWFData));
                    WorkflowData = (AgendaWFData)serializer.Deserialize(reader);
                }
            }
            SetAgendaTitle();

            notifyAgendaOwner.Action = "Complete";
            notifyAgendaOwner.Source = "Paperless Board";
            notifyAgendaOwner.TaskTitle = string.Format("Clean document(s) for '{0}' and start the Collect-Digital-Signatures workflow.", AgendaTitle);
            notifyAgendaOwner.TaskDescription = string.Format("The Board Agenda workflow has been completed for Agenda {0}. The owner/sponsor of this agenda item now needs to start the Collect Digital Signatures workflow for this agenda.", AgendaTitle);
            notifyAgendaOwner.TaskDueDate = DateTime.Today.AddDays(1);

            SPUser originator = GetSPUser(this.workflowProperties.Item, "Sponsor");
            notifyAgendaOwner.TaskAssignedTo = originator.LoginName;

            notifyAgendaOwnerAboutComments.Action = "Complete";
            notifyAgendaOwnerAboutComments.Source = "Paperless Board";
            notifyAgendaOwnerAboutComments.TaskTitle = string.Format("Edit documents with GM Comments '{0}' and resubmit to GM.", AgendaTitle);
            notifyAgendaOwnerAboutComments.TaskDescription = string.Format("The GM has added comments for this agenda which need to be incorporated into the documents before resubmitting to the DGM and CBSS.", AgendaTitle);
            notifyAgendaOwnerAboutComments.TaskDueDate = DateTime.Today.AddDays(1);

            notifyAgendaOwnerAboutComments.TaskAssignedTo = originator.LoginName;
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

        private string GetAdministratorEmail(string AGMOffice)
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
                        SPUser spUser = GetSPUser(li, "Administrator");
                        return (spUser != null) ? spUser.Email : null;
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

        public SPWorkflowTaskProperties agmFinanceReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmFinanceReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMFinanceTaskComplete = true;
        }

        private void codeSetAgendaStatus_Invoke(object sender, EventArgs e)
        {
            SetAgendaStatus("Published for Stakeholder Review");
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

        public SPWorkflowTaskProperties createTask1_TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void testTask_Invoke(object sender, EventArgs e)
        {
            createTask1_TaskProperties1.Title = "AGM-Finance Review";
            createTask1_TaskProperties1.DueDate = DateTime.Now.AddMinutes(15);
            createTask1_TaskProperties1.AssignedTo = GetAGMOfficer(FINANCE_OFFICE_NAME);
            createTask1_TaskProperties1.PercentComplete = 0F;
            createTask1_TaskProperties1.SendEmailNotification = false;
        }




        public SPWorkflowTaskProperties onTaskChanged1_AfterProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onTaskChanged1_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();



        public Guid agmFinanceReviewTask_TaskId = default(System.Guid);

        private void agmFinanceReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmFinanceReviewTask_TaskId = Guid.NewGuid();
            agmFinanceReviewTask.TaskProperties.Title = string.Format("AGM-Finance Approval for {0}", AgendaTitle);
            agmFinanceReviewTask.TaskProperties.Description = "Please review and approve this Agenda Item.";
            agmFinanceReviewTask.TaskProperties.DueDate = GetDueDate();
            agmFinanceReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(FINANCE_OFFICE_NAME);
            agmFinanceReviewTask.TaskProperties.PercentComplete = 0F;
            agmFinanceReviewTask.TaskProperties.SendEmailNotification = true;
            agmFinanceReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmFinanceReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties agmFinanceReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMFinanceReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMFinanceReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMFinanceReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMFinanceReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();


            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMFinanceTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties onAGMFinanceReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMFinanceReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMFinanceTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMFinanceReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMFinanceReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties agmFinanceReviewTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void IsAGMITReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmITReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsAGMPlanningReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmPlanningReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsAGMHumanResourcesReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmHumanResourcesReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAGMFinanceReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmFinanceReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMFinanceTaskComplete = true;

        }

        private void codeSetAgendaStatusToStakeHolderReviewsComplete_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Stakeholder Review Complete");
        }

        private void SubmitForDGMandSPSSReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            SubmitForDGMandSPSSReviewTask_TaskId = Guid.NewGuid();
            SubmitForDGMandSPSSReviewTask.TaskProperties.Title = string.Format("Edit Documents and Submit '{0}' for CBSS/DGM Approval", AgendaTitle);
            SubmitForDGMandSPSSReviewTask.TaskProperties.Description = "Please submit this agenda for approval by the CBSS and DGM";
            SubmitForDGMandSPSSReviewTask.TaskProperties.DueDate = GetDueDate();

            //Get the user who created the document set.
            SPUser originator = GetSPUser(this.workflowProperties.Item, "Sponsor");
            SubmitForDGMandSPSSReviewTask.TaskProperties.AssignedTo = originator.LoginName;
            SubmitForDGMandSPSSReviewTask.TaskProperties.PercentComplete = 0F;
            SubmitForDGMandSPSSReviewTask.TaskProperties.SendEmailNotification = true;
            SubmitForDGMandSPSSReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            SubmitForDGMandSPSSReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Submit";
        }

        public Guid SubmitForDGMandSPSSReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties SubmitForDGMandSPSSReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSubmitForDGMApprovalTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSubmitForDGMApprovalTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onSubmitForDGMApprovalTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onSubmitForDGMApprovalTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if (taskStatus == "Completed")
                {
                    this._isSubmitForDGMApprovalTaskComplete = true;
                }
            }
        }

        public Guid DGMApproveTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties DGMApproveTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid SPSSReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties SPSSReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onDGMReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        public SPWorkflowTaskProperties onSPSSReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onSPSSReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isSPSSReviewTaskCreated = true;
        }

        public SPWorkflowTaskProperties onDGMReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onDGMReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onDGMReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onDGMReviewTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isDGMReviewTaskComplete = true;
                }
            }

        }

        public SPWorkflowTaskProperties onSPSSReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSPSSReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onSPSSReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onSPSSReviewTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isSPSSReviewTaskComplete = true;
                }
            }
        }


        private void IsDGMReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.DGMApproveTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsSPSSReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.SPSSReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsGMReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.GMApproveTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        public SPWorkflowTaskProperties updateDGMReviewTaskToExpired_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties updateSPSSReviewTaskToExpired_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void updateDGMReviewTaskToExpired_MethodInvoking(object sender, EventArgs e)
        {
            DGMApproveTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isDGMReviewTaskComplete = true;
        }

        private void updateSPSSReviewTaskToExpired_MethodInvoking(object sender, EventArgs e)
        {
            SPSSReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isSPSSReviewTaskCreated = true;
        }

        public SPWorkflowTaskProperties onDGMReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onDGMReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSPSSReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSPSSReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onDGMReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            DGMApproveTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void onSPSSReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            SPSSReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void codeSetAgendaStatusToDGMApproved_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("DGM/CBSS Reviews completed");
        }

        public Guid SubmitForGMApprovalTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties SubmitForGMApprovalTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void SubmitForGMApprovalTask_MethodInvoking(object sender, EventArgs e)
        {

            SubmitForGMApprovalTask_TaskId = Guid.NewGuid();

            SubmitForGMApprovalTask.TaskProperties.Title = string.Format("Edit documents and submit '{0}' for GM Approval", AgendaTitle);
            SubmitForGMApprovalTask.TaskProperties.Description = "Please submit this agenda for GM Approval";
            SubmitForGMApprovalTask.TaskProperties.DueDate = GetDueDate();

            //Get the user who created the document set.
            SPUser originator = GetSPUser(this.workflowProperties.Item, "Sponsor");
            SubmitForGMApprovalTask.TaskProperties.AssignedTo = originator.LoginName;
            SubmitForGMApprovalTask.TaskProperties.PercentComplete = 0F;
            SubmitForGMApprovalTask.TaskProperties.SendEmailNotification = true;
            SubmitForGMApprovalTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            SubmitForGMApprovalTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Submit";
        }

        public SPWorkflowTaskProperties onSubmitForGMApprovalTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onSubmitForGMApprovalTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onSubmitForGMApprovalTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onSubmitForGMApprovalTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if (taskStatus == "Completed")
                {
                    this._isSubmtForGMApprovalTaskComplete = true;
                }
            }
        }

        private void codeSetAgendaStatusToSubmittedForGMApproval_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Submitted for GM Approval");
        }

        public Guid GMApproveTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties GMApproveTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void GMApproveTask_MethodInvoking(object sender, EventArgs e)
        {
            GMApproveTask_TaskId = Guid.NewGuid();
            GMApproveTask.TaskProperties.Title = string.Format("Please review and approve agenda '{0}'", AgendaTitle);
            GMApproveTask.TaskProperties.DueDate = GetDueDate();
            GMApproveTask.TaskProperties.AssignedTo = GetAGMOfficer(GM);
            GMApproveTask.TaskProperties.PercentComplete = 0F;
            GMApproveTask.TaskProperties.SendEmailNotification = true;
            GMApproveTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            GMApproveTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void DGMApproveTask_MethodInvoking(object sender, EventArgs e)
        {
            DGMApproveTask_TaskId = Guid.NewGuid();
            DGMApproveTask.TaskProperties.Title = string.Format("DGM Approval for - {0}", AgendaTitle);
            DGMApproveTask.TaskProperties.Description = "Please review and approve this agenda";
            DGMApproveTask.TaskProperties.DueDate = GetDueDate();
            DGMApproveTask.TaskProperties.AssignedTo = GetAGMOfficer(DGM);
            DGMApproveTask.TaskProperties.PercentComplete = 0F;
            DGMApproveTask.TaskProperties.SendEmailNotification = true;
            DGMApproveTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            DGMApproveTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void SPSSReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            SPSSReviewTask_TaskId = Guid.NewGuid();
            SPSSReviewTask.TaskProperties.Title = string.Format("CBSS Approval for - {0}", AgendaTitle);
            SPSSReviewTask.TaskProperties.Description = "Please review and approve this agenda";
            SPSSReviewTask.TaskProperties.DueDate = GetDueDate();
            SPSSReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(SPSS);
            SPSSReviewTask.TaskProperties.PercentComplete = 0F;
            SPSSReviewTask.TaskProperties.SendEmailNotification = true;
            SPSSReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            SPSSReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onGMApproveTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onGMApproveTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isGMApproveTaskCreated = true;
        }

        public SPWorkflowTaskProperties onGMApproveTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onGMApproveTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onGMApproveTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onGMApproveTaskChanged.AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Comments Added"))
                {
                    this._isGMApproveTaskComplete = true;
                    if (taskStatus == "Comments Added")
                    {
                        this._isGMTaskApproved = false;
                    }
                    else
                        this._isGMTaskApproved = true;
                }

            }
        }

        public SPWorkflowTaskProperties updateGMApproveTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onGMApproveTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onGMApproveTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void updateGMApproveTask_MethodInvoking(object sender, EventArgs e)
        {
            GMApproveTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isGMApproveTaskComplete = true;
        }

        private void onGMApproveTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            GMApproveTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void codeCopyDocSetToBoard_ExecuteCode(object sender, EventArgs e)
        {
            this.workflowProperties.Item["PublishToBoard"] = true;
            this.workflowProperties.Item.Update();

        }

        private DocumentSet CreateDocumentSet(SPList list, string documentSetName)
        {
            SPContentType docsetCT = list.ContentTypes["Document Set"];
            Hashtable properties = new Hashtable();
            properties.Add("DocumentSetDescription", string.Format("Document Set for Agenda: {0}", documentSetName));

            SPFolder parentFolder = list.RootFolder;

            DocumentSet docSet = DocumentSet.Create(parentFolder, documentSetName, docsetCT.Id, properties, true);

            return docSet;
        }

        private void CopyFile(SPFile file, DocumentSet docSet)
        {
            string destinationFolderUrl = docSet.Item.ParentList.RootFolder.Url;

            destinationFolderUrl = (!destinationFolderUrl.EndsWith("/")) ? destinationFolderUrl + "/" : destinationFolderUrl;
            file.CopyTo(destinationFolderUrl + file.Name, true);
            //web.Update();

            //return web.GetFile(web.Url + "/" + destinationFolderUrl + file.Name);
        }

        private void codeSetAgendaStatusToPublished_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Ready for Digital Signatures");
        }

        private void onDGMReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isDGMReviewTaskCreated = true;
        }

        public Guid agmITReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmITReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmITReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmITReviewTask_TaskId = Guid.NewGuid();
            agmITReviewTask.TaskProperties.Title = string.Format("AGM-Information Technology Approval for {0}", AgendaTitle);
            agmITReviewTask.TaskProperties.DueDate = GetDueDate();
            agmITReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(IT_OFFICE_NAME);
            agmITReviewTask.TaskProperties.PercentComplete = 0F;
            agmITReviewTask.TaskProperties.SendEmailNotification = true;
            agmITReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmITReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void onAGMITReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMITTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMITReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMITReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMITReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMITReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMITReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();


            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMITTaskComplete = true;
                }
            }
        }

        private void codeAGMITReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmITReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMITTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmITReviewTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMITReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMITReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMITReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmITReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void delayActivity1_InitializeTimeoutDuration(object sender, EventArgs e)
        {

        }

        public Guid agmPlanningReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmPlanningReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmPlanningReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmPlanningReviewTask_TaskId = Guid.NewGuid();
            agmPlanningReviewTask.TaskProperties.Title = string.Format("AGM-Planning Approval for {0}", AgendaTitle);
            agmPlanningReviewTask.TaskProperties.DueDate = GetDueDate();
            agmPlanningReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(PLANNING_OFFICE_NAME);
            agmPlanningReviewTask.TaskProperties.PercentComplete = 0F;
            agmPlanningReviewTask.TaskProperties.SendEmailNotification = true;
            agmPlanningReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmPlanningReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public Guid agmHumanResourcesReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmHumanResourcesReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmHumanResourcesReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmHumanResourcesReviewTask_TaskId = Guid.NewGuid();
            agmHumanResourcesReviewTask.TaskProperties.Title = string.Format("AGM-Human Resources Approval for {0}", AgendaTitle);
            agmHumanResourcesReviewTask.TaskProperties.DueDate = GetDueDate();
            agmHumanResourcesReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(HUMANRESOURCES_OFFICE_NAME);
            agmHumanResourcesReviewTask.TaskProperties.PercentComplete = 0F;
            agmHumanResourcesReviewTask.TaskProperties.SendEmailNotification = true;
            agmHumanResourcesReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmHumanResourcesReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void onAGMPlanningReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMPlanningTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMHumanResourcesReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMPlanningReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMPlanningReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMPlanningTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();


            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMPlanningTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties onAGMPlanningTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMPlanningTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMHumanResourcesReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMHumanResourcesReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMHumanResourcesReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMHumanResourcesReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();


            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMHumanResourcesTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties agmPlanningReviewTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onagmPlanningReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onagmPlanningReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMPlanningReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmPlanningReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public SPWorkflowTaskProperties agmHumanResourcesTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMHumanResourcesTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMHumanResourcesTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMHumanResourcesReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmHumanResourcesReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid onAGMHumanResourcesTaskUpdated_TaskId = default(System.Guid);

        private void codeAGMPlanningReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmPlanningReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMPlanningTaskComplete = true;
        }

        private void codeAGMHumanResourcesReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmHumanResourcesReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMHumanResourcesTaskComplete = true;
        }

        private void onAGMHumanResourcesReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMHumanResourcesTaskCreated = true;
        }

        private void agmSafetyReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmSafetyReviewTask_TaskId = Guid.NewGuid();
            agmSafetyReviewTask.TaskProperties.Title = string.Format("AGM-Safety Approval for {0}", AgendaTitle);
            agmSafetyReviewTask.TaskProperties.DueDate = GetDueDate();
            agmSafetyReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(SAFETY_OFFICE_NAME);
            agmSafetyReviewTask.TaskProperties.PercentComplete = 0F;
            agmSafetyReviewTask.TaskProperties.SendEmailNotification = true;
            agmSafetyReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmSafetyReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public Guid agmSafetyReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmSafetyReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid agmLegalReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmLegalReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmLegalReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmLegalReviewTask_TaskId = Guid.NewGuid();
            agmLegalReviewTask.TaskProperties.Title = string.Format("AGM-Legal Approval for {0}", AgendaTitle);
            agmLegalReviewTask.TaskProperties.DueDate = GetDueDate();
            agmLegalReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(LEGAL_OFFICE_NAME);
            agmLegalReviewTask.TaskProperties.PercentComplete = 0F;
            agmLegalReviewTask.TaskProperties.SendEmailNotification = true;
            agmLegalReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmLegalReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void onAGMSafetyReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMSafetyTaskCreated = true;
        }

        private void onAGMLegalReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMLegalTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMLegalReviewTaskCompleted_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMSafetyReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMSafetyReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMSafetyReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();


            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMSafetyTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties onAGMSafetyReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMSafetyReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMLegalReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMLegalReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMLegalReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMLegalReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMLegalTaskComplete = true;
                }
            }
        }
        private void IsAGMFinanceReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmFinanceReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsAGMSafetyReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmSafetyReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsAGMLegalReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmLegalReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAGMSafetyReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmSafetyReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMSafetyTaskComplete = true;
        }

        private void codeAGMLegalReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmLegalReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMLegalTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmSafetyReviewTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMSafetyReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMSafetyReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMSafetyReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmSafetyReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public SPWorkflowTaskProperties onAGMLegalReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMLegalReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMLegalReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmLegalReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void agmContractsReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmContractsReviewTask_TaskId = Guid.NewGuid();
            agmContractsReviewTask.TaskProperties.Title = string.Format("AGM-Contracts Approval for {0}", AgendaTitle);
            agmContractsReviewTask.TaskProperties.DueDate = GetDueDate();
            agmContractsReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(CONTRACTS_OFFICE_NAME);
            agmContractsReviewTask.TaskProperties.PercentComplete = 0F;
            agmContractsReviewTask.TaskProperties.SendEmailNotification = true;
            agmContractsReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmContractsReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public Guid agmContractsReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmContractsReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMContractsReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMContractsReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMContractsTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMContractsReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMContractsReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMContractsReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMContractsReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMContractsTaskComplete = true;
                }
            }
        }

        private void IsAGMContractsReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmContractsReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void IsAGMAuditReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmAuditReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAGMContractsReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmContractsReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMContractsTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmContractsReviewTaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMContractsReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMContractsReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMContractsReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmContractsReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid agmAuditReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmAuditReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmAuditReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmAuditReviewTask_TaskId = Guid.NewGuid();
            agmAuditReviewTask.TaskProperties.Title = string.Format("AGM-Audit Approval for {0}", AgendaTitle);
            agmAuditReviewTask.TaskProperties.DueDate = GetDueDate();
            agmAuditReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(AUDIT_OFFICE_NAME);
            agmAuditReviewTask.TaskProperties.PercentComplete = 0F;
            agmAuditReviewTask.TaskProperties.SendEmailNotification = true;
            agmAuditReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmAuditReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAGMAuditReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMAuditReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMAuditTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMAuditReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMAuditReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMAuditReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMAuditReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMAuditTaskComplete = true;
                }
            }
        }

        private void codeAGMAuditReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmAuditReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMAuditTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmAuditReviewTaskUpdate_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMAuditReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMAuditReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMAuditReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmAuditReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid agmCommunicationsReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmCommunicationsReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMCommunicationsReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMCommunicationsReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMCommunicationsTaskCreated = true;
        }

        private void agmCommunicationsReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmCommunicationsReviewTask_TaskId = Guid.NewGuid();
            agmCommunicationsReviewTask.TaskProperties.Title = string.Format("AGM-Communications Approval for {0}", AgendaTitle);
            agmCommunicationsReviewTask.TaskProperties.DueDate = GetDueDate();
            agmCommunicationsReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(COMMUNICATIONS_OFFICE_NAME);
            agmCommunicationsReviewTask.TaskProperties.PercentComplete = 0F;
            agmCommunicationsReviewTask.TaskProperties.SendEmailNotification = true;
            agmCommunicationsReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmCommunicationsReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAGMCommunicationsReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMCommunicationsReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMCommunicationsReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMCommunicationsReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMCommunicationsTaskComplete = true;
                }
            }
        }

        private void IsAGMCommunicationsReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmCommunicationsReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAGMCommunicationsReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmCommunicationsReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMCommunicationsTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmCommunicationsReviewTaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMCommunicationsReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMCommunicationsReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMCommunicationsReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmCommunicationsReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid agmPoliceReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmPoliceReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmPoliceReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmPoliceReviewTask_TaskId = Guid.NewGuid();
            agmPoliceReviewTask.TaskProperties.Title = string.Format("AGM-Police Approval for {0}", AgendaTitle);
            agmPoliceReviewTask.TaskProperties.DueDate = GetDueDate();
            agmPoliceReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(POLICE_OFFICE_NAME);
            agmPoliceReviewTask.TaskProperties.PercentComplete = 0F;
            agmPoliceReviewTask.TaskProperties.SendEmailNotification = true;
            agmPoliceReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmPoliceReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAGMPoliceTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMPoliceReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAGMPoliceTaskCreated = true;
        }

        public SPWorkflowTaskProperties onAGMPoliceReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMPoliceReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMPoliceReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMPoliceReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMPoliceTaskComplete = true;
                }
            }
        }

        private void IsAGMPoliceReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.agmPoliceReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAGMPoliceReviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            agmPoliceReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAGMPoliceTaskComplete = true;
        }

        public SPWorkflowTaskProperties agmPoliceReviewTaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMPoliceReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMPoliceReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMPoliceReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            agmPoliceReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid adHocUser1ReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties adHocUser1ReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdhocUser1TaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser1ReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAdhocUser1TaskCreated = true;
        }

        public SPWorkflowTaskProperties onAdHocUser1ReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser1ReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser1ReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAdHocUser1ReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAdhocUser1TaskComplete = true;
                }
            }
        }

        private string GetUserLoginName(string username)
        {
            SPUser user;
            string ahUser = string.Format("i:0#.w|{0}", username);
            this.workflowProperties.Web.Site.RootWeb.EnsureUser(ahUser);
            user = this.workflowProperties.Web.Site.RootWeb.AllUsers[ahUser];
            return user.LoginName;
        }

        private void adhocUser1ReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            try
            {
                adHocUser1ReviewTask_TaskId = Guid.NewGuid();
                adHocUser1ReviewTask.TaskProperties.Title = string.Format("Approval for Agenda - {0}", AgendaTitle);
                adHocUser1ReviewTask.TaskProperties.DueDate = GetDueDate();


                //string ahUser = string.Format("i:0#.w|{0}", this.WorkflowData.AdHocUser1);
                //this.workflowProperties.Web.Site.RootWeb.EnsureUser(ahUser);
                //user = this.workflowProperties.Web.Site.RootWeb.AllUsers[ahUser];
            }
            catch (Exception ex)
            {
                Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception in Agenda Workflow while populating User object. User – {0} – {1} – {2}", this.WorkflowData.AdHocUser1, ex.Message, ex.StackTrace);
                throw ex;
            }
            try
            {
                adHocUser1ReviewTask.TaskProperties.AssignedTo = GetUserLoginName(this.WorkflowData.AdHocUser1);
                adHocUser1ReviewTask.TaskProperties.PercentComplete = 0F;
                adHocUser1ReviewTask.TaskProperties.SendEmailNotification = true;
                adHocUser1ReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
                adHocUser1ReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";

            }
            catch (Exception ex)
            {
                Microsoft.Office.Server.Diagnostics.PortalLog.LogString("Exception in Agenda Workflow while assigning user. User – {0} – {1} – {2}", this.WorkflowData.AdHocUser1, ex.Message, ex.StackTrace);
                throw ex;
            }

        }

        private void codeAdHocUser1reviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            adHocUser1ReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAdhocUser1TaskComplete = true;
        }

        public SPWorkflowTaskProperties adHocUser1TaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser1ReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser1ReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void IsAdHocUser1ReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.adHocUser1ReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        public Guid adHocUser2ReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties adHocUser2ReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void adhocUser2ReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            adHocUser2ReviewTask_TaskId = Guid.NewGuid();
            adHocUser2ReviewTask.TaskProperties.Title = string.Format("Approval for Agenda - {0}", AgendaTitle);
            adHocUser2ReviewTask.TaskProperties.DueDate = GetDueDate();

            adHocUser2ReviewTask.TaskProperties.AssignedTo = GetUserLoginName(this.WorkflowData.AdHocUser2);
            adHocUser2ReviewTask.TaskProperties.PercentComplete = 0F;
            adHocUser2ReviewTask.TaskProperties.SendEmailNotification = true;
            adHocUser2ReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            adHocUser2ReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAdHocUser2ReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser2ReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser2ReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser2ReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAdHocUser2ReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAdhocUser2TaskComplete = true;
                }
            }
        }

        private void onAdhocUser2ReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAdhocUser2TaskCreated = true;
        }

        private void IsAdHocUser2ReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.adHocUser2ReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        private void codeAdHocUser2reviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            adHocUser2ReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAdhocUser2TaskComplete = true;
        }

        public SPWorkflowTaskProperties onAdHocUser2ReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser2ReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdHocUser2ReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            adHocUser2ReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private void onAdHocUser1ReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            adHocUser1ReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid adHocUser3ReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties adHocUser3ReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void adhocUser3ReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            adHocUser3ReviewTask_TaskId = Guid.NewGuid();
            adHocUser3ReviewTask.TaskProperties.Title = string.Format("Approval for Agenda - {0}", AgendaTitle);
            adHocUser3ReviewTask.TaskProperties.DueDate = GetDueDate();
            adHocUser3ReviewTask.TaskProperties.AssignedTo = GetUserLoginName(this.WorkflowData.AdHocUser3);
            adHocUser3ReviewTask.TaskProperties.PercentComplete = 0F;
            adHocUser3ReviewTask.TaskProperties.SendEmailNotification = true;
            adHocUser3ReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            adHocUser3ReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAdHocUser3ReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser3ReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAdhocUser3TaskCreated = true;
        }

        private void IsAdHocUser3ReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.adHocUser3ReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        public SPWorkflowTaskProperties onAdHocUser3TaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser3TaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser3ReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAdHocUser3TaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAdhocUser3TaskComplete = true;
                }
            }
        }

        private void codeAdHocUser3reviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            adHocUser3ReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAdhocUser3TaskComplete = true;
        }

        public SPWorkflowTaskProperties adHocUser3TaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser3ReviewTaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser3ReviewTaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdHocUser3ReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            adHocUser3ReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        public Guid adHocUser4ReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties adHocUser4ReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void adhocUser4ReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            adHocUser4ReviewTask_TaskId = Guid.NewGuid();
            adHocUser4ReviewTask.TaskProperties.Title = string.Format("Approval for Agenda - {0}", AgendaTitle);
            adHocUser4ReviewTask.TaskProperties.DueDate = GetDueDate();
            adHocUser4ReviewTask.TaskProperties.AssignedTo = GetUserLoginName(this.WorkflowData.AdHocUser4);
            adHocUser4ReviewTask.TaskProperties.PercentComplete = 0F;
            adHocUser4ReviewTask.TaskProperties.SendEmailNotification = true;
            adHocUser4ReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            adHocUser4ReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        private void IsAdHocUser4ReviewTaskOverDue(object sender, ConditionalEventArgs e)
        {
            DateTime dueDate = this.adHocUser4ReviewTask.TaskProperties.DueDate;

            if (dueDate > DateTime.Now)
            {
                e.Result = false;
            }
            else
            {
                e.Result = true;
            }
        }

        public SPWorkflowTaskProperties onAdHocUser4ReviewTaskCreated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid onAdHocUser4ReviewTaskCreated_TaskId = default(System.Guid);

        private void onAdhocUser4ReviewTaskCreated_Invoked(object sender, ExternalDataEventArgs e)
        {
            this._isAdhocUser4TaskCreated = true;
        }

        public SPWorkflowTaskProperties onAdHocUser4TaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser4TaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdhocUser4ReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAdHocUser4TaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAdhocUser4TaskComplete = true;
                }
            }
        }

        private void codeAdHocUser4reviewTaskExpired_ExecuteCode(object sender, EventArgs e)
        {
            adHocUser3ReviewTask.TaskProperties.ExtendedProperties[SPBuiltInFieldId.TaskStatus] = "Expired";
            //set task completed
            this._isAdhocUser3TaskComplete = true;
        }

        public SPWorkflowTaskProperties adHocUser4TaskUpdated_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser4TaskUpdated_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAdHocUser4TaskUpdated_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAdHocUser4ReviewTaskUpdated_Invoked(object sender, ExternalDataEventArgs e)
        {
            adHocUser4ReviewTask.TaskProperties.ExtendedProperties["Completed"] = true;
        }

        private DateTime GetDueDate()
        {
            InitializeWebAppProperties();
            if (wfDueDateContext == "DEV")
            {
                return DateTime.Now.AddMinutes(5);
            }
            else if (wfDueDateContext == "DEBUG")
            {
                return DateTime.Now.AddMinutes(15);
            }
            else
            {
                int days = 3;
                DateTime date = DateTime.Now;

                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    date = date.AddDays(2);
                    days -= 1;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    date = date.AddDays(1);
                    days -= 1;
                }

                date = date.AddDays(days / 5 * 7);
                int extraDays = days % 5;

                if ((int)date.DayOfWeek + extraDays > 5)
                {
                    extraDays += 2;
                }

                return date.AddDays(extraDays);

            }
        }

        public Guid agmBusOperationsReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmBusOperationsReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmBusOperationsReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmBusOperationsReviewTask_TaskId = Guid.NewGuid();
            agmBusOperationsReviewTask.TaskProperties.Title = string.Format("AGM Bus Operations Approval for {0}", AgendaTitle);
            agmBusOperationsReviewTask.TaskProperties.DueDate = GetDueDate();
            agmBusOperationsReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(BUSOPERATIONS_OFFICE_NAME);
            agmBusOperationsReviewTask.TaskProperties.PercentComplete = 0F;
            agmBusOperationsReviewTask.TaskProperties.SendEmailNotification = true;
            agmBusOperationsReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmBusOperationsReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAGMBusOperationsReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMBusOperationsReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onAGMBusOperationsReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMBusOperationsReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMBusOperationsTaskComplete = true;
                }
            }
        }

        public Guid agmRailOperationsReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties agmRailOperationsReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void agmRailOperationsReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            agmRailOperationsReviewTask_TaskId = Guid.NewGuid();
            agmRailOperationsReviewTask.TaskProperties.Title = string.Format("AGM Rail Operations Approval for {0}", AgendaTitle);
            agmRailOperationsReviewTask.TaskProperties.DueDate = GetDueDate();
            agmRailOperationsReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(RAILOPERATIONS_OFFICE_NAME);
            agmRailOperationsReviewTask.TaskProperties.PercentComplete = 0F;
            agmRailOperationsReviewTask.TaskProperties.SendEmailNotification = true;
            agmRailOperationsReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            agmRailOperationsReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onAGMRailOperationsReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onAGMRailOperationsReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid onAGMRailOperationsReviewTaskChanged_TaskId = default(System.Guid);

        private void onAGMRailOperationsReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onAGMRailOperationsReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isAGMRailOperationsTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties expeditedDGMReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid expeditedDGMReviewTask_TaskId = default(System.Guid);

        private void ExpeditedDGMReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            expeditedDGMReviewTask_TaskId = Guid.NewGuid();
            expeditedDGMReviewTask.TaskProperties.Title = string.Format("[Expedited] DGM Approval for {0}", AgendaTitle);
            expeditedDGMReviewTask.TaskProperties.DueDate = GetDueDate();
            expeditedDGMReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(DGM);
            expeditedDGMReviewTask.TaskProperties.PercentComplete = 0F;
            expeditedDGMReviewTask.TaskProperties.SendEmailNotification = true;
            expeditedDGMReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            expeditedDGMReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onexpeditedDGMReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onexpeditedDGMReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onExpeditedDGMReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onexpeditedDGMReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isExpeditedDGMReviewTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties expeditedCBSSReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid expeditedCBSSReviewTask_TaskId = default(System.Guid);

        private void ExpeditedCBSSApproveTask_MethodInvoking(object sender, EventArgs e)
        {
            expeditedCBSSReviewTask_TaskId = Guid.NewGuid();
            expeditedCBSSReviewTask.TaskProperties.Title = string.Format("[Expedited] CBSS Approval for {0}", AgendaTitle);
            expeditedCBSSReviewTask.TaskProperties.DueDate = GetDueDate();
            expeditedCBSSReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(SPSS);
            expeditedCBSSReviewTask.TaskProperties.PercentComplete = 0F;
            expeditedCBSSReviewTask.TaskProperties.SendEmailNotification = true;
            expeditedCBSSReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            expeditedCBSSReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onExpeditedCBSSReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onExpeditedCBSSReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onExpeditedCBSSReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onExpeditedCBSSReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isExpeditedCBSSReviewTaskComplete = true;
                }
            }
        }

        public String sendEmailToCommitteeCoordinators_Subject = default(System.String);
        public String sendEmailToCommitteeCoordinators_To = default(System.String);
        public String sendEmailToCommitteeCoordinators_Body = default(System.String);

        private void sendEmailToCommitteeCoordinators_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailToCommitteeCoordinators_Subject = string.Format("Approval workflow initiated for documents for {0}", workflowProperties.Item.Title);
            sendEmailToCommitteeCoordinators_To = GetEmails("Committee Coordinators");
            sendEmailToCommitteeCoordinators_Body = string.Format(@"
                Hello,

                This is to inform you that the workflow for approving documents for the Board Agenda {0} has been initated.
                

            ", workflowProperties.Item.Title);
        }

        private string GetEmails(string groupName)
        {
            foreach (SPGroup group in SPContext.Current.Site.RootWeb.Groups)
            {
                if (group.Name == groupName)
                {
                    StringBuilder ret = new StringBuilder();
                    foreach (SPUser user in SPContext.Current.Site.RootWeb.Groups[groupName].Users)
                    {
                        ret.Append(user.Email + ";");
                    }
                    return ret.ToString();
                }
            }
            return String.Empty;
        }

        private void sendDGMApproveTaskEmail_MethodInvoking(object sender, EventArgs e)
        {
            sendDGMApproveTaskEmail.To = GetAdministratorEmail(DGM);
            sendDGMApproveTaskEmail.Subject = "A task has been assigned to the DGM";
            sendDGMApproveTaskEmail.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the DGM for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendCBSSApproveTaskEmail_MethodInvoking(object sender, EventArgs e)
        {
            sendCBSSApproveTaskEmail.To = GetAdministratorEmail(SPSS);
            sendCBSSApproveTaskEmail.Subject = "A task has been assigned to the CBSS";
            sendCBSSApproveTaskEmail.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the CBSS for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMFinance_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMFinanceAdmin.To = GetAdministratorEmail(FINANCE_OFFICE_NAME);
            sendEmailAGMFinanceAdmin.Subject = "A task has been assigned to the AGM-Finance";
            sendEmailAGMFinanceAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Finance for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMITAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMITAdmin.To = GetAdministratorEmail(IT_OFFICE_NAME);
            sendEmailAGMITAdmin.Subject = "A task has been assigned to the AGM-Information Technology";
            sendEmailAGMITAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Information Technology for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMPlanningAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMPlanningAdmin.To = GetAdministratorEmail(PLANNING_OFFICE_NAME);
            sendEmailAGMPlanningAdmin.Subject = "A task has been assigned to the AGM-Planning";
            sendEmailAGMPlanningAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Planning for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMLegalAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMLegalAdmin.To = GetAdministratorEmail(LEGAL_OFFICE_NAME);
            sendEmailAGMLegalAdmin.Subject = "A task has been assigned to the AGM-Legal";
            sendEmailAGMLegalAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Legal for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMAudit_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMAudit.To = GetAdministratorEmail(AUDIT_OFFICE_NAME);
            sendEmailAGMAudit.Subject = "A task has been assigned to the AGM-Legal";
            sendEmailAGMAudit.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Audit for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMCommunicationsAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMCommunicationsAdmin.To = GetAdministratorEmail(COMMUNICATIONS_OFFICE_NAME);
            sendEmailAGMCommunicationsAdmin.Subject = "A task has been assigned to the AGM-Communications";
            sendEmailAGMCommunicationsAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Communications for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);

        }

        private void sendEmailAGMPoliceAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMPoliceAdmin.To = GetAdministratorEmail(POLICE_OFFICE_NAME);
            sendEmailAGMPoliceAdmin.Subject = "A task has been assigned to the AGM-Police";
            sendEmailAGMPoliceAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Police for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMContracts_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMContracts.To = GetAdministratorEmail(CONTRACTS_OFFICE_NAME);
            sendEmailAGMContracts.Subject = "A task has been assigned to the AGM-Contracts";
            sendEmailAGMContracts.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Contracts for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);

        }

        private void sendEmailAGMSafetyAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMSafetyAdmin.To = GetAdministratorEmail(SAFETY_OFFICE_NAME);
            sendEmailAGMSafetyAdmin.Subject = "A task has been assigned to the AGM-Safety";
            sendEmailAGMSafetyAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Safety for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMHumanResources_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailHumanResourcesAdmin.To = GetAdministratorEmail(HUMANRESOURCES_OFFICE_NAME);
            sendEmailHumanResourcesAdmin.Subject = "A task has been assigned to the AGM-Human Resources";
            sendEmailHumanResourcesAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Human Resources for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        public Guid executiveDirectorReviewTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties executiveDirectorReviewTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void executiveDirectorReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            executiveDirectorReviewTask_TaskId = Guid.NewGuid();
            executiveDirectorReviewTask.TaskProperties.Title = string.Format("Executive Director-DEO Approval for {0}", AgendaTitle);
            executiveDirectorReviewTask.TaskProperties.DueDate = GetDueDate();
            executiveDirectorReviewTask.TaskProperties.AssignedTo = GetAGMOfficer(EXECUTIVE_DIRECTOR);
            executiveDirectorReviewTask.TaskProperties.PercentComplete = 0F;
            executiveDirectorReviewTask.TaskProperties.SendEmailNotification = true;
            executiveDirectorReviewTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            executiveDirectorReviewTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public SPWorkflowTaskProperties onExecutiveDirectorReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onExecutiveDirectorReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onExecutiveDirectorReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onExecutiveDirectorReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isExecutiveDirectorReviewTaskComplete = true;
                }
            }
        }

        private void sendEmailAGMBusOpsAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMBusOpsAdmin.To = GetAdministratorEmail(BUSOPERATIONS_OFFICE_NAME);
            sendEmailAGMBusOpsAdmin.Subject = "A task has been assigned to the AGM-Bus Operations";
            sendEmailAGMBusOpsAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Bus Operations for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailAGMRailOpsAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMRailOpsAdmin.To = GetAdministratorEmail(RAILOPERATIONS_OFFICE_NAME);
            sendEmailAGMRailOpsAdmin.Subject = "A task has been assigned to the AGM-Rail Operations";
            sendEmailAGMRailOpsAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the AGM-Rail Operations for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void sendEmailExecutiveDirectorAdmin_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailExecutiveDirectorAdmin.To = GetAdministratorEmail(EXECUTIVE_DIRECTOR);
            sendEmailExecutiveDirectorAdmin.Subject = "A task has been assigned to the Executive Director - DEO";
            sendEmailExecutiveDirectorAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the Executive Director - DEO for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void codeSetAgendaStatusExpedited_Invoke(object sender, EventArgs e)
        {
            SetAgendaStatus("Expedited Workflow Initiated");
        }

        private void agmFinanceReviewTaskCompleted_MethodInvoking(object sender, EventArgs e)
        {

        }

        private void ReApproveTaskForDGM_MethodInvoking(object sender, EventArgs e)
        {
            ReApproveTaskForDGM_TaskId = Guid.NewGuid();
            ReApproveTaskForDGM.TaskProperties.Title = string.Format("Re-Approve Board Agenda for {0}.", AgendaTitle);
            ReApproveTaskForDGM.TaskProperties.Description = "The GM has added more comments and wants you to review the contents of this board agenda document set again.";
            ReApproveTaskForDGM.TaskProperties.DueDate = GetDueDate();
            ReApproveTaskForDGM.TaskProperties.AssignedTo = GetAGMOfficer(DGM);
            ReApproveTaskForDGM.TaskProperties.PercentComplete = 0F;
            ReApproveTaskForDGM.TaskProperties.SendEmailNotification = true;
            ReApproveTaskForDGM.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            ReApproveTaskForDGM.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public Guid ReApproveTaskForDGM_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties ReApproveTaskForDGM_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void sendDGMReApproveTaskEmail_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMCommunicationsAdmin.To = GetAdministratorEmail(COMMUNICATIONS_OFFICE_NAME);
            sendEmailAGMCommunicationsAdmin.Subject = "A task has been assigned to the DGM";
            sendEmailAGMCommunicationsAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the DGM for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);

        }

        public SPWorkflowTaskProperties onDGMReReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onDGMReReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();


        private void onDGMReReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onDGMReReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isDGMReReviewTaskComplete = true;
                }
            }
        }

        private void sendCBSSReApproveTaskEmail_MethodInvoking(object sender, EventArgs e)
        {
            sendEmailAGMCommunicationsAdmin.To = GetAdministratorEmail(COMMUNICATIONS_OFFICE_NAME);
            sendEmailAGMCommunicationsAdmin.Subject = "A task has been assigned to the CBSS";
            sendEmailAGMCommunicationsAdmin.Body = string.Format(@"
            
            Hi,
            
            This email is to notify you that a task has been assigned to the CBSS for reviewing documents 
            for the Board Agenda - {0}.
            ", workflowProperties.Item.Title);
        }

        private void SPSSReReviewTask_MethodInvoking(object sender, EventArgs e)
        {
            ReApproveTaskForCBSS_TaskId = Guid.NewGuid();
            ReApproveTaskForCBSS.TaskProperties.Title = string.Format("Re-Approve Board Agenda for {0}.", AgendaTitle);
            ReApproveTaskForCBSS.TaskProperties.Description = "The GM has added more comments and wants you to review the contents of this board agenda document set again.";
            ReApproveTaskForCBSS.TaskProperties.DueDate = GetDueDate();
            ReApproveTaskForCBSS.TaskProperties.AssignedTo = GetAGMOfficer(SPSS);
            ReApproveTaskForCBSS.TaskProperties.PercentComplete = 0F;
            ReApproveTaskForCBSS.TaskProperties.SendEmailNotification = true;
            ReApproveTaskForCBSS.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            ReApproveTaskForCBSS.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";
        }

        public Guid ReApproveTaskForCBSS_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties ReApproveTaskForCBSS_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onSPSSReReviewTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onCBSSReReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired"))
                {
                    this._isCBSSReReviewTaskComplete = true;
                }
            }
        }

        public SPWorkflowTaskProperties onCBSSReReviewTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onCBSSReReviewTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties updateGMApproveTaskAfterReReview_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void updateGMApproveTask_MethodInvoking_1(object sender, EventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;

            onCBSSReReviewTaskChanged_AfterProperties.ExtendedProperties[statusFieldID] = "Not Started";
        }

        public Guid GMReApproveTask_TaskId = default(System.Guid);
        public SPWorkflowTaskProperties GMReApproveTask_TaskProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void GMReApproveTask_MethodInvoking(object sender, EventArgs e)
        {
            GMReApproveTask_TaskId = Guid.NewGuid();
            GMReApproveTask.TaskProperties.Title = "Approve Board Agenda Items.";
            GMReApproveTask.TaskProperties.Description = "GM's comments have been added for re-review and approval by the GM.";
            GMReApproveTask.TaskProperties.DueDate = GetDueDate();
            GMReApproveTask.TaskProperties.AssignedTo = GetAGMOfficer(GM);
            GMReApproveTask.TaskProperties.PercentComplete = 0F;
            GMReApproveTask.TaskProperties.SendEmailNotification = true;
            GMReApproveTask.TaskProperties.ExtendedProperties["TaskSource"] = "Paperless Board";
            GMReApproveTask.TaskProperties.ExtendedProperties["ActionOwed"] = "Approve";

            _isGMReApproveTaskComplete = false;

        }

        private void onGMReApproveTaskChanged_Invoked(object sender, ExternalDataEventArgs e)
        {
            Guid statusFieldID = workflowProperties.TaskList.Fields["Status"].Id;
            string taskStatus = onGMReApproveTaskChanged_AfterProperties.ExtendedProperties[statusFieldID].ToString();

            if (taskStatus != null)
            {
                if ((taskStatus == "Completed") || (taskStatus == "Expired") || (taskStatus == "Comments Added"))
                {
                    this._isGMReApproveTaskComplete = true;
                    if (taskStatus == "Comments Added")
                    {
                        this._isGMTaskApproved = false;
                    }
                    else
                    {
                        this._isGMTaskApproved = true;
                    }
                }

            }
        }

        public SPWorkflowTaskProperties onGMReApproveTaskChanged_AfterProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onGMReApproveTaskChanged_BeforeProperties = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void completeDGMReReviewTask_MethodInvoking(object sender, EventArgs e)
        {

        }

        private void codeInitializeAgendaOwnerTask_ExecuteCode(object sender, EventArgs e)
        {


        }
    }
}
