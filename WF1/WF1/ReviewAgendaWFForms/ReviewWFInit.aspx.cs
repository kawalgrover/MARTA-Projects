using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Security;
using System.Security.Permissions;
using System.Web.UI.WebControls;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Utilities;
using System.Web;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using WF1;

namespace BoardAgendaWorkflows
{
    public partial class ReviewWFInit : WFPagesBase
    {
        protected SPListItem listItem;
        protected string listItemName;
        protected string listItemUrl;
        protected SPWorkflowAssociation associationTemplate;
        protected SPWorkflowTemplate baseTemplate;

        protected PeopleEditor userPicker;
        protected CheckBox chk_agm_finance;
        protected CheckBox chk_agm_it;
        protected CheckBox chk_agm_planning;
        protected CheckBox chk_agm_humanresources;
        protected CheckBox chk_agm_safety;
        protected CheckBox chk_agm_legal;

        protected CheckBox chk_agm_contracts;
        protected CheckBox chk_agm_audit;
        protected CheckBox chk_agm_busoperations;
        protected CheckBox chk_agm_railoperations;
        protected CheckBox chk_agm_communications;
        protected CheckBox chk_agm_police;
     
        protected CheckBox chk_dgm;
        protected CheckBox chk_cbss;
        protected CheckBox chk_gm;
        protected CheckBox chk_executive_director;

        protected Panel pnlNormal;
        protected Panel pnlExpedited;
        SPList boardAgendas;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GetListItemInfo();
            GetAssociationInfo();

            if (!Page.IsPostBack)
            {

                string agendaID = listItem["AgendaID"].ToString();
                string agendaType = string.Empty;
                string originatingAGMOffice = string.Empty;

                boardAgendas = SPContext.Current.Web.Site.RootWeb.Lists["Board Agenda"];

                SPQuery query = new SPQuery()
                {
                    Query = string.Format(@"<Query>
                                              <Where>
                                                <Eq>
                                                  <FieldRef Name='ID' />
                                                  <Value Type='Counter'>{0}</Value>
                                                </Eq>
                                              </Where>
                                            </Query>", agendaID)
                };

                foreach (SPListItem item in boardAgendas.GetItems(query))
                {
                    if (item["ID"].ToString() == agendaID)
                    {
                        agendaType = item["Agenda Type"].ToString();
                        originatingAGMOffice = item["AGM Office"].ToString();
                        break;
                    }
                }


                if (agendaType == "Procurement Resolution")
                {
                    chk_agm_legal.Checked = true;
                    chk_agm_finance.Checked = true;
                    chk_agm_contracts.Checked = true;
                    chk_executive_director.Checked = true;


                    if (originatingAGMOffice == "AGM-Audit")
                        chk_agm_audit.Checked = true;
                    else if (originatingAGMOffice == "AGM-Bus Operations")
                        chk_agm_busoperations.Checked = true;
                    else if (originatingAGMOffice == "AGM-Communications and External Affairs")
                        chk_agm_communications.Checked = true;
                    else if (originatingAGMOffice == "AGM-Planning")
                        chk_agm_planning.Checked = true;
                    else if (originatingAGMOffice == "AGM-Police")
                        chk_agm_police.Checked = true;
                    else if (originatingAGMOffice == "AGM-Rail Operations")
                        chk_agm_railoperations.Checked = true;
                    else if (originatingAGMOffice == "AGM-Safety and QA")
                        chk_agm_safety.Checked = true;
                    else if (originatingAGMOffice == "AGM-Technology")
                        chk_agm_it.Checked = true;

                }
            }
        }


        private void GetListItemInfo()
        {
             listItem = list.GetItemById(Convert.ToInt32(Request.Params["ID"]));

            if (listItem.File == null)
                listItemUrl = Web.Url + listItem.ParentList.Forms[PAGETYPE.PAGE_DISPLAYFORM].ServerRelativeUrl + "?ID=" + listItem.ID.ToString();
            else
                listItemUrl = Web.Url + "/" + listItem.File.Url;

            if (list.BaseType == SPBaseType.DocumentLibrary)
            {
                listItemName = (string)listItem["Name"];

                int i = listItemName.LastIndexOf('.');

                if (i > 0)
                    listItemName = listItemName.Substring(0, i);
            }
            else
                listItemName = (string)listItem["Title"];
        }

        private void GetAssociationInfo()
        {
            Guid associationTemplateId = new Guid(Request.Params["TemplateID"]);

            associationTemplate = list.WorkflowAssociations[associationTemplateId];

            if (associationTemplate == null)
            {
                SPContentTypeId contentTypeId = (SPContentTypeId)listItem["ContentTypeId"];
                SPContentType contentType = list.ContentTypes[contentTypeId];
                associationTemplate = contentType.WorkflowAssociations[associationTemplateId];
            }

            if (associationTemplate == null)
                throw new SPException("The requested workflow could not be found.");

            baseTemplate = Web.WorkflowTemplates[associationTemplate.BaseId];

            workflowName = associationTemplate.Name;

            string m_formData = (string)associationTemplate.AssociationData;
        }

        public void BtnOK_Click(object sender, EventArgs e)
        {
            string initData = SerializePagetoXml();
            InitiateWorkflow(initData);
        }

        

        internal string SerializePagetoXml()
        {
            List<string> userNamesList = new List<string>();
            int adHocUsers = 0;
            foreach(PickerEntity pe in userPicker.Entities)
            {
                adHocUsers++;
                userNamesList.Add(string.Format("i:0#.w|{0}", pe.Description));
            }

            ReviewWFData data = new ReviewWFData()
            {
                AdHocUserNames = string.Join(";", userNamesList.ToArray()),
                AGM_Audit = chk_agm_audit.Checked.ToString(),
                AGM_BusOperations = chk_agm_busoperations.Checked.ToString(),
                AGM_Communications = chk_agm_communications.Checked.ToString(),
                AGM_Contracts = chk_agm_contracts.Checked.ToString(),
                AGM_Finance = chk_agm_finance.Checked.ToString(),
                AGM_HumanResource = chk_agm_humanresources.Checked.ToString(),
                AGM_IT = chk_agm_it.Checked.ToString(),
                AGM_Legal = chk_agm_legal.Checked.ToString(),
                AGM_Planning = chk_agm_planning.Checked.ToString(),
                AGM_Police = chk_agm_police.Checked.ToString(),
                AGM_RaiOperations = chk_agm_railoperations.Checked.ToString(),
                AGM_Safety = chk_agm_safety.Checked.ToString(),
                CBSSSelected = chk_cbss.Checked.ToString(),
                DGMSelected = chk_dgm.Checked.ToString(),
                Executive_Director = chk_executive_director.Checked.ToString(),
                GMSelected = chk_gm.Checked.ToString()
            };

            data.AdHocUser1Selected = "false";
            data.AdHocUser2Selected = "false";
            data.AdHocUser3Selected = "false";
            data.AdHocUser4Selected = "false";

            if (userNamesList.Count == 1)
            {
                data.AdHocUser1 = userNamesList[0];
                data.AdHocUser1Selected = "true";
            }
            if (userNamesList.Count == 2)
            {
                data.AdHocUser1 = userNamesList[0];
                data.AdHocUser2 = userNamesList[1];
                data.AdHocUser1Selected = "true";
                data.AdHocUser2Selected = "true";
            }
            if (userNamesList.Count == 3)
            {
                data.AdHocUser1 = userNamesList[0];
                data.AdHocUser2 = userNamesList[1];
                data.AdHocUser3 = userNamesList[2];
                data.AdHocUser1Selected = "true";
                data.AdHocUser2Selected = "true";
                data.AdHocUser3Selected = "true";
            }
            if (userNamesList.Count >= 4)
            {
                data.AdHocUser1 = userNamesList[0];
                data.AdHocUser2 = userNamesList[1];
                data.AdHocUser3 = userNamesList[2];
                data.AdHocUser4 = userNamesList[3];
                data.AdHocUser1Selected = "true";
                data.AdHocUser2Selected = "true";
                data.AdHocUser3Selected = "true";
                data.AdHocUser4Selected = "true";
            }
            
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ReviewWFData));
                serializer.Serialize(stream, data);
                stream.Position = 0;
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);

                return Encoding.UTF8.GetString(bytes);
            }
        }


        private void InitiateWorkflow(string initData)
        {
            try
            {
                Web.Site.WorkflowManager.StartWorkflow(listItem, associationTemplate, initData);
            }
            catch (Exception ex)
            {
                SPException spEx = ex as SPException;

                string errorString;

                if (spEx != null && spEx.ErrorCode == -2130575205 /* SPErrorCode.TP_E_WORKFLOW_ALREADY_RUNNING */)
                    errorString = SPResource.GetString(Strings.WorkflowFailedAlreadyRunningMessage);
                else if (spEx != null && spEx.ErrorCode == -2130575339 /* SPErrorCode.TP_E_VERSIONCONFLICT */)
                    errorString = SPResource.GetString(Strings.ListVersionMismatch);
                else if (spEx != null && spEx.ErrorCode == -2130575338 /* SPErrorCode.TP_E_LISTITEMDELETED */)
                    errorString = spEx.Message;
                else
                    errorString = SPResource.GetString(Strings.WorkflowFailedStartMessage);

                SPUtility.Redirect("Error.aspx", SPRedirectFlags.RelativeToLayoutsPage, HttpContext.Current,
                    "ErrorText=" + SPHttpUtility.UrlKeyValueEncode(errorString));
            }

            SPUtility.Redirect(list.DefaultViewUrl, SPRedirectFlags.UseSource, HttpContext.Current);
        }

    }
}
