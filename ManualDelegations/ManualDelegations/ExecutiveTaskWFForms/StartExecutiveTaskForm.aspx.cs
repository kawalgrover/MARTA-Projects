using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using ExecutiveTaskTracking;
using Microsoft.SharePoint.Workflow;
using System.IO;
using System.Xml.Serialization;
using Microsoft.SharePoint.Utilities;
using System.Web;

namespace ExecutiveTaskTracking.Layouts.ExecutiveTaskTracking
{
    public partial class StartExecutiveTaskForm : WFPagesBase
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

            //keyPeopleList = SPContext.Current.Web.Lists["Key People"]; // TODO: Perhaps, make this configurable.


            //gvContributors.DataSource = GetContributors(keyPeopleList);
            //gvContributors.DataBind();
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
            //string initData = SerializePagetoXml();
            InitiateWorkflow();
        }

        //internal string SerializePagetoXml()
        //{
        //    //NotifyContributorsWFData data = new NotifyContributorsWFData()
        //    //{
        //    //    Contributors = string.Join(";", contributors.Select(c => c.LoginName).ToArray())
        //    //};


        //    //using (MemoryStream stream = new MemoryStream())
        //    //{
        //    //    XmlSerializer serializer = new XmlSerializer(typeof(NotifyContributorsWFData));
        //    //    serializer.Serialize(stream, data);
        //    //    stream.Position = 0;
        //    //    byte[] bytes = new byte[stream.Length];
        //    //    stream.Read(bytes, 0, bytes.Length);

        //    //    return Encoding.UTF8.GetString(bytes);
        //    //}
        //}

        private void InitiateWorkflow()
        {
            try
            {
                Web.Site.WorkflowManager.StartWorkflow(listItem, associationTemplate, null);
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
