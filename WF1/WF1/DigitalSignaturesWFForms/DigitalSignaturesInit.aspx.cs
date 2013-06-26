using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.WebPartPages;
using WF1;
using Microsoft.SharePoint.Workflow;
using System.Collections.Generic;
using BoardAgendaWorkflows;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using Microsoft.SharePoint.Utilities;
using System.Web;

namespace PBWorkflows
{
    public partial class DigitalSignaturesInit : WFPagesBase
    {
        protected SPListItem listItem;
        protected string listItemName;
        protected string listItemUrl;
        protected SPWorkflowAssociation associationTemplate;
        protected SPWorkflowTemplate baseTemplate;

        SPList boardAgendas;
        SPList executives;

        List<Signatory> signatories;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GetListItemInfo();
            GetAssociationInfo();

            //Get the Agenda Type
            string agendaID = listItem["AgendaID"].ToString();
            string agendaType = string.Empty;
            string originatingAGMOffice = string.Empty;

            boardAgendas = SPContext.Current.Web.Site.RootWeb.Lists["Board Agenda"];
            executives = SPContext.Current.Web.Site.RootWeb.Lists["Executives"];

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

            signatories = new List<Signatory>();

            if ((agendaType == "Procurement Resolution") || (agendaType == "Non-Procurement Resolution")
                || (agendaType == "Briefing"))
            {
                // Get the Officer of the originating AGM office
                signatories.Add(GetAGMOfficer(originatingAGMOffice));
                // Get his boss based on if its CBSS or DGM
                signatories.Add(GetAGMOfficeSupervisor(originatingAGMOffice));
                //Also get the GM
                signatories.Add(GetAGMOfficer("GM"));
            }

            if ((agendaType == "Procurement Resolution") || (agendaType == "Non-Procurement Resolution"))
            {
                if (originatingAGMOffice != "AGM-Legal Services")
                    signatories.Add(GetAGMOfficer("AGM-Legal Services"));
            }
            gvContributors.DataSource = signatories;
            gvContributors.DataBind();
        }

        private Signatory GetAGMOfficer(string AGMOffice)
        {
            foreach (SPListItem li in executives.Items)
            {
                if (li["Executive Position"].ToString() == AGMOffice)
                {
                    SPUser spUser = GetSPUser(li, "Executive");
                    if (spUser != null)
                    {
                        Signatory signatory = new Signatory()
                        {
                            signatoryLoginName = spUser.LoginName,
                            SignatoryName = spUser.Name
                        };
                        return signatory;
                    }
                }
            }
            // If you got here, then the AGM Office was not in the list
            return null;
        }

        private Signatory GetAGMOfficeSupervisor(string AGMOffice)
        {
            string supervisor = null;

            foreach (SPListItem li in executives.Items)
            {
                if (li["Executive Position"].ToString() == AGMOffice)
                {
                    supervisor = li["AGM Office Supervisor"].ToString();
                    break;
                }
            }

            if (supervisor != null)
            {
                return GetAGMOfficer(supervisor);
            }
            // If you got here, then the AGM Office was not in the list
            return null;
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
            DigitalSignaturesWFData data = new DigitalSignaturesWFData()
            {
                DigitalSignatories = string.Join(";", signatories.Select(c => c.signatoryLoginName).ToArray())
            };


            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DigitalSignaturesWFData));
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

    public class Signatory
    {
        public string SignatoryName { get; set; }
        public string signatoryLoginName { get; set; }
    }
}
