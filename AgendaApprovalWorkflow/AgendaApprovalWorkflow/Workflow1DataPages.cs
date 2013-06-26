using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Xml.Serialization;

using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Security;
using System.Security.Permissions;

namespace AgendaApprovalWorkflow
{
    public class Workflow1DataPages : LayoutsPageBase
    {
        public enum FormType
        {
            Association,
            Initiation
        }

        protected SPList list;
        protected SPContentType contentType;
        protected string workflowName;
        protected HyperLink hlReturn;
        protected string requestQueryString;
        protected bool useContentTypeTemplate = false;

        protected CheckBox checkBox1;
        protected CheckBox checkBox2;
        protected CheckBox checkBox3;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            EnsureRequestParamsParsed();

            SPBasePermissions perms = SPBasePermissions.Open | SPBasePermissions.ViewPages;
            if (useContentTypeTemplate)
                perms |= SPBasePermissions.AddAndCustomizePages;
            else
                perms |= SPBasePermissions.ManageLists;

            Web.CheckPermissions(perms);
        }

        protected void EnsureRequestParamsParsed()
        {
            workflowName = Request.Params["WorkflowName"];

            string strListID = Request.QueryString["List"];
            string strCTID = Request.QueryString["ctype"];

            if (strListID != null)
                list = Web.Lists[new Guid(strListID)];

            if (strCTID != null)
            {
                requestQueryString = "ctype=" + strCTID;

                if (list != null)
                {
                    requestQueryString += "&List=" + strListID;
                    contentType = list.ContentTypes[new SPContentTypeId(strCTID)];
                }
                else
                {
                    contentType = Web.ContentTypes[new SPContentTypeId(strCTID)];
                    useContentTypeTemplate = true;
                }
            }
            else
                requestQueryString = "List=" + strListID;
        }

        internal void PopulatePageFromXml(string associationXml, FormType type)
        {
            Workflow1Data workflow1Data = new Workflow1Data();
            if (!string.IsNullOrEmpty(associationXml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Workflow1Data));
                XmlTextReader reader = new XmlTextReader(new System.IO.StringReader(associationXml));
                workflow1Data = (Workflow1Data)serializer.Deserialize(reader);
            }
            
                checkBox1.Checked = workflow1Data.FinanceManager;
                checkBox2.Checked = workflow1Data.TechnologyManager;
                checkBox3.Checked = workflow1Data.Superviser;
            
        }

        internal string SerializePagetoXml(FormType type)
        {
            Workflow1Data data = new Workflow1Data();
            /* ikarstein: Start your modifications here */
            
                data.FinanceManager = checkBox1.Checked;
                data.TechnologyManager = checkBox1.Checked;
                data.Superviser = checkBox3.Checked;
            
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Workflow1Data));
                serializer.Serialize(stream, data);
                stream.Position = 0;
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return Encoding.UTF8.GetString(bytes);
            }
        }

        [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            string customMasterUrl = SPControl.GetContextWeb(this.Context).MasterUrl; //~masterurl/default.master
            this.MasterPageFile = customMasterUrl;
        }



 
        
    }
}
