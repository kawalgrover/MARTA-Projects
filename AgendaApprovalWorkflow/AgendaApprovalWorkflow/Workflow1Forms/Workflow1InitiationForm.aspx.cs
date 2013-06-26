using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Utilities;
using System.Web;
using Microsoft.SharePoint.Workflow;

namespace AgendaApprovalWorkflow
{
    public partial class Workflow1InitiationForm : Workflow1DataPages
    {
        protected SPListItem listItem;
        protected string listItemName;
        protected string listItemUrl;
        protected SPWorkflowAssociation associationTemplate;
        protected SPWorkflowTemplate baseTemplate;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GetListItemInfo();
            GetAssociationInfo();

            if (!IsPostBack)
            {
                PopulatePageFromXml((string)associationTemplate.AssociationData, FormType.Initiation);
            }
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

        public void BtnOK_Click(object sender, EventArgs e)
        {
            string InitData = base.SerializePagetoXml(FormType.Initiation);
            InitiateWorkflow(InitData);
        }

        private void InitiateWorkflow(string InitData)
        {
            try
            {
                Web.Site.WorkflowManager.StartWorkflow(listItem, associationTemplate, InitData);
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
