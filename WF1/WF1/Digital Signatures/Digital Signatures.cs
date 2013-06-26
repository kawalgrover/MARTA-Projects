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
using BoardAgendaWorkflows;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using Microsoft.SharePoint.Administration;

namespace BoardAgendaWorkflows
{
    public sealed partial class Digital_Signatures : SequentialWorkflowActivity
    {
        public Digital_Signatures()
        {
            InitializeComponent();
        }

        public Guid workflowId = new Guid("312f29e7-57e1-4186-8cac-438fdafb7975");
        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        public static readonly DependencyProperty WorkflowDataProperty =
            DependencyProperty.Register("WorkflowData", typeof(DigitalSignaturesWFData), typeof(BoardAgendaWorkflows.Digital_Signatures));

        public string AgendaTitle { get; set; }


        public DigitalSignaturesWFData WorkflowData
        {
            get
            {
                return (DigitalSignaturesWFData)GetValue(WorkflowDataProperty);
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
                    XmlSerializer serializer = new XmlSerializer(typeof(DigitalSignaturesWFData));
                    WorkflowData = (DigitalSignaturesWFData)serializer.Deserialize(reader);
                }
            }
            SetAgendaTitle();
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

        private string defaultDocumentsLibraryName = null;
        private string libraryNameInDocumentWorkspace = null;
        private string boardSiteURL = null;
        private string boardMeetingListName = null;
        private string lookAheadListName = null;
        private string emisSiteURL = null;
        private string emisSiteRelativeURL = null;
        private string lookAheadListNameInEmis = null;
        private string wfDueDateContext = null;

        public List<string> signatories;

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


        private void codeSetStatusGettingDS_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Getting Digital Signatures");
        }

        private void replicatorActivity1_ChildInitialized(object sender, ReplicatorChildEventArgs e)
        {
            AcquireDigitalSignatureActivity.TaskAssignedTo = e.InstanceData.ToString();
            AcquireDigitalSignatureActivity.TaskTitle = string.Format("Confirm that resolution was digitally signed (for {0})", AgendaTitle);
            AcquireDigitalSignatureActivity.TaskDescription = string.Format("This task is for confirming that the resolution document was digitally signed by the owner of this task. The agenda for which this task was created is titled {0}.", AgendaTitle);
            AcquireDigitalSignatureActivity.TaskDueDate = DateTime.Today.AddDays(3);
            AcquireDigitalSignatureActivity.Source = "Paperless Board";
            AcquireDigitalSignatureActivity.Action = "Sign";
        }

        private void replicatorActivity1_Initialized(object sender, EventArgs e)
        {
            signatories = new List<string>();
            string[] splitCharacters = new string[] { ";" };
            string[] contributors = WorkflowData.DigitalSignatories.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries);
            signatories = contributors.ToList();
            // Add the first task.
            int lastContributorIndex = contributors.Count() - 1;
            AcquireDigitalSignatureActivity.TaskAssignedTo = contributors[lastContributorIndex];
            AcquireDigitalSignatureActivity.TaskTitle = string.Format("Confirm that resolution was digitally signed (for {0})", AgendaTitle);
            AcquireDigitalSignatureActivity.TaskDescription = "This task is for confirming that the resolution document was digitally signed by the owner of this task.";
            AcquireDigitalSignatureActivity.TaskDueDate = DateTime.Today.AddDays(3);
            AcquireDigitalSignatureActivity.Source = "Paperless Board";
            AcquireDigitalSignatureActivity.Action = "Sign";

        }

        private void codeSetStatus_ExecuteCode(object sender, EventArgs e)
        {
            SetAgendaStatus("Ready to Publish");
        }





    }
}
