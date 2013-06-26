using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Web.UI.WebControls;
using Microsoft.SharePoint.Security;
using System.Security.Permissions;
using System.Web;

namespace AgendaApprovalWorkflow
{
    public partial class Workflow1AssociationForm : Workflow1DataPages
    {
        protected struct WorkflowOptions
        {
            public string taskListName;
            public string historyListName;
            public Guid taskListId;
            public Guid historyListId;

            public bool allowManual;
            public bool autoStartCreate;
            public bool autoStartChange;

            public bool setDefault;
            public bool updateLists;
            public bool lockItem;
        }

        protected WorkflowOptions workflowOptions = new WorkflowOptions();

        protected SPWorkflowTemplate baseTemplate;
        protected SPWorkflowAssociation associationTemplate;
        //protected HyperLink hlReturn;

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (associationTemplate != null)
                PopulatePageFromXml((string)associationTemplate.AssociationData, FormType.Association);
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            //Get the Workflow Name.
            FetchAssociationInfo();
            GetTaskAndHistoryList();
        }

        private void FetchAssociationInfo()
        {
            SPWorkflowAssociationCollection wfAccociationCollection;
            baseTemplate = Web.WorkflowTemplates[new Guid(Request.Params["WorkflowDefinition"])];
            associationTemplate = null;

            if (contentType != null)
            {
                // Associating with a content type.
                wfAccociationCollection = contentType.WorkflowAssociations;
                hlReturn.Text = contentType.Name;
                hlReturn.NavigateUrl = "ManageContentType.aspx" + requestQueryString;
            }
            else
            {
                list.CheckPermissions(SPBasePermissions.ManageLists);

                wfAccociationCollection = list.WorkflowAssociations;
                hlReturn.Text = list.Title;
                hlReturn.NavigateUrl = list.DefaultViewUrl;
            }
            if (wfAccociationCollection == null || wfAccociationCollection.Count < 0)
            {
                throw new SPException("No Associations Found");
            }

            workflowOptions.autoStartCreate = (Request.Params["AutoStartCreate"] == "ON");
            workflowOptions.autoStartChange = (Request.Params["AutoStartChange"] == "ON");
            workflowOptions.allowManual = (Request.Params["AllowManual"] == "ON");
            workflowOptions.lockItem = (Request.Params["LockItem"] == "ON");
            workflowOptions.setDefault = (Request.Params["SetDefault"] == "ON");
            workflowOptions.updateLists = (Request.Params["UpdateLists"] == "TRUE");

            string associationGuid = Request.Params["GuidAssoc"];
            if (associationGuid != string.Empty)
            {
                associationTemplate = wfAccociationCollection[new Guid(associationGuid)];
            }

            SPWorkflowAssociation checkForDuplicateTemplate = wfAccociationCollection.GetAssociationByName(workflowName, Web.Locale);

            if (checkForDuplicateTemplate != null && (associationTemplate == null || associationTemplate.Id != checkForDuplicateTemplate.Id))
            {
                throw new SPException("Duplicate workflow name is detected.");
            }
        }

        private void GetTaskAndHistoryList()
         {
             if (useContentTypeTemplate)
             {
                 workflowOptions.taskListName = Request.Params["TaskList"];
                 workflowOptions.historyListName = Request.Params["HistoryList"];
             }
             else
             {
                 string taskListGuid = Request.Params["TaskList"];
                 if (taskListGuid[0] != null) // already existing list
                 {
                     workflowOptions.taskListId = new Guid(taskListGuid);
                 }
                 else  // new list
                 {
                     SPList list = null;
                     workflowOptions.taskListName = taskListGuid.Substring(1);
                     try
                     {
                         list = Web.Lists[workflowOptions.taskListName];
                     }
                     catch (ArgumentException)
                     {
                     }
 
                     if (list != null)
                         throw new SPException("A list already exists with the same name as that proposed for the new task list. "+
                                               "Use your's Back button and either change the name of the workflow or "+
                                               "select an existing task list.&lt;br&gt;");
                 }
 
                 // Do the same for the history list
                 string historyListGuid = Request.Params["HistoryList"];
                 if (historyListGuid[0] != null) // user selected already existing list
                 {
                     workflowOptions.historyListId = new Guid(historyListGuid);
                 }
                 else // User wanted a new list
                 {
                     SPList list = null;
 
                     workflowOptions.historyListName = historyListGuid.Substring(1);
 
                     try
                     {
                         list = Web.Lists[workflowOptions.historyListName];
                     }
                     catch (ArgumentException)
                     {
                     }
                     if (list != null)
                         throw new SPException("A list already exists with the same name as that proposed for the new history list. Use your's Back button and either change the name of the workflow or select an existing history list.&lt;br&gt;");
                 }
             }
         }

        public void BtnOK_Click(object sender, EventArgs e)
        {
            SPList taskList = null;
            SPList historyList = null;
            if (!IsValid)
                return;
            if (!useContentTypeTemplate)
            {
                // If the user requested a new task list, create it.
                if (workflowOptions.taskListId == Guid.Empty)
                {
                    string description = string.Format("Task list for the {0} workflow.", workflowName);
                    workflowOptions.taskListId = Web.Lists.Add(workflowOptions.taskListName, description, SPListTemplateType.Tasks);
                }

                // If the user requested a new history list, create it.
                if (workflowOptions.historyListId == Guid.Empty)
                {
                    string description = string.Format("History list for the {0} workflow.", workflowName);
                    workflowOptions.historyListId = Web.Lists.Add(workflowOptions.historyListName, description, SPListTemplateType.WorkflowHistory);
                }
                taskList = Web.Lists[workflowOptions.taskListId];
                historyList = Web.Lists[workflowOptions.historyListId];
            }

            // Perform association (if it does not already exist).
            bool isNewAssociation;
            if (associationTemplate == null)
            {
                isNewAssociation = true;
                if (!useContentTypeTemplate)
                    associationTemplate = SPWorkflowAssociation.CreateListAssociation(baseTemplate,
                                        workflowName, taskList, historyList);
                else
                {
                    associationTemplate = SPWorkflowAssociation.CreateWebContentTypeAssociation(baseTemplate, workflowName,
                                        workflowOptions.taskListName, workflowOptions.historyListName);
                }
            }
            else // Modify existing template.
            {
                isNewAssociation = false;
                associationTemplate.Name = workflowName;
                associationTemplate.SetTaskList(taskList);
                associationTemplate.SetHistoryList(historyList);
            }

            // Set up startup parameters in the template.
            associationTemplate.Name = workflowName;
            associationTemplate.LockItem = workflowOptions.lockItem;
            associationTemplate.AutoStartCreate = workflowOptions.autoStartCreate;
            associationTemplate.AutoStartChange = workflowOptions.autoStartChange;
            associationTemplate.AllowManual = workflowOptions.allowManual;

            if (associationTemplate.AllowManual)
            {
                SPBasePermissions newPerms = SPBasePermissions.EmptyMask;

                if (Request.Params["ManualPermEditItemRequired"] == "ON")
                    newPerms |= SPBasePermissions.EditListItems;
                if (Request.Params["ManualPermManageListRequired"] == "ON")
                    newPerms |= SPBasePermissions.ManageLists;

                associationTemplate.PermissionsManual = newPerms;
            }

            // Place data from form into the association template.
            associationTemplate.AssociationData = base.SerializePagetoXml(FormType.Association);

            // If this is a content type association, add the template to the content type.
            if (contentType != null)
            {
                if (isNewAssociation)
                    contentType.WorkflowAssociations.Add(associationTemplate);
                else
                    contentType.WorkflowAssociations.Update(associationTemplate);

                if (workflowOptions.updateLists)
                    contentType.UpdateWorkflowAssociationsOnChildren(false);
            }
            else // Else, if this is a list association.
            {
                if (isNewAssociation)
                    list.WorkflowAssociations.Add(associationTemplate);
                else
                    list.WorkflowAssociations.Update(associationTemplate);

                if (associationTemplate.AllowManual && list.EnableMinorVersions)
                {
                    // If this WF was selected to be the content approval WF 
                    // (m_setDefault = true, see association page) then enable content
                    // Approval for the list.
                    if (list.DefaultContentApprovalWorkflowId != associationTemplate.Id && workflowOptions.setDefault)
                    {
                        if (!list.EnableModeration)
                            list.EnableModeration = true;
                        list.DefaultContentApprovalWorkflowId = associationTemplate.Id;
                        list.Update();
                    }
                    else if (list.DefaultContentApprovalWorkflowId == associationTemplate.Id && !workflowOptions.setDefault)
                    {
                        // Reset the DefaultContentApprovalWorkflowId
                        list.DefaultContentApprovalWorkflowId = Guid.Empty;
                        list.Update();
                    }
                }
            }

            SPUtility.Redirect("WrkSetng.aspx", SPRedirectFlags.RelativeToLayoutsPage, HttpContext.Current, requestQueryString);
        }
    }
}
