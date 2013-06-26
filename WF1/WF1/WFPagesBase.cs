using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Security;
using System.Security.Permissions;
using Microsoft.SharePoint;
using System.Web.UI.WebControls;

namespace WF1
{
    public class WFPagesBase : LayoutsPageBase
    {
        protected SPList list;
        protected SPContentType contentType;
        protected string workflowName;
        protected HyperLink hlReturn;
        protected string requestQueryString;
        protected bool useContentTypeTemplate = false;


        [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            string customMasterUrl = SPControl.GetContextWeb(this.Context).MasterUrl; //~masterurl/default.master
            this.MasterPageFile = customMasterUrl;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            EnsureRequestParamsParsed();
            /*
            SPBasePermissions perms = SPBasePermissions.Open | SPBasePermissions.ViewPages = SPBasePermissions.;
            if (useContentTypeTemplate)
                perms |= SPBasePermissions.AddAndCustomizePages;
            else
                perms |= SPBasePermissions.ManageLists;

            Web.CheckPermissions(perms);
             * */
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

        
    }
}
