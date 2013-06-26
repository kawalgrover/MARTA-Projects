using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using WF1;
using Microsoft.SharePoint.Workflow;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using PaperlessBoardWorkflows;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using Microsoft.SharePoint.Utilities;
using System.Web;

namespace PBWorkflows
{
    public partial class NotifiyContributorsInit : WFPagesBase
    {
        protected SPListItem listItem;
        protected string listItemName;
        protected string listItemUrl;
        protected SPWorkflowAssociation associationTemplate;
        protected SPWorkflowTemplate baseTemplate;

        SPList keyPeopleList;
        List<Contributor> contributors;
        //protected GridView gvContributors;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GetListItemInfo();
            GetAssociationInfo();

            keyPeopleList = SPContext.Current.Web.Lists["Key People"]; // TODO: Perhaps, make this configurable.


            gvContributors.DataSource = GetContributors(keyPeopleList);
            gvContributors.DataBind();
        }

        private List<Contributor> GetContributors(SPList keyPeopleList)
        {
            SPQuery query = new SPQuery()
               {
                   Query = @"<Query>
                          <Where>
                            <Eq>
                              <FieldRef Name='IsContributor' />
                              <Value Type='Boolean'>1</Value>
                            </Eq>
                          </Where>
                        </Query>"
               };

            contributors = new List<Contributor>();

            foreach (SPListItem item in keyPeopleList.GetItems(query))
            {
                if ((item["KeyPerson"] != null) && (item["IsContributor"] != null))
                {
                    if (item["IsContributor"].ToString() == "True")
                    {
                        string contributorName = item["KeyPerson"].ToString();

                        Contributor contributor = GetSPUser(item, "Key Person");
                        if (contributor != null)
                        {
                            contributors.Add(contributor);
                        };
                    }
                }
                
            }

            return contributors;
        }

        private Contributor GetSPUser(SPListItem item, string fieldName)
        {
            SPFieldUser field = item.Fields[fieldName] as SPFieldUser;
            if (field != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[fieldName].ToString()) as SPFieldUserValue;

                if (fieldValue != null)
                {
                    Contributor contributor = new Contributor()
                    {
                        ContributorName = fieldValue.User.Name,
                        LoginName = fieldValue.User.LoginName
                    };
                    return contributor;
                }
            }
            return null;
        }

        public class Contributor
        {
            public string ContributorName { get; set; }
            public string LoginName { get; set; }
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
            NotifyContributorsWFData data = new NotifyContributorsWFData()
            {
                Contributors = string.Join(";", contributors.Select(c => c.LoginName).ToArray())
            };

            
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(NotifyContributorsWFData));
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
