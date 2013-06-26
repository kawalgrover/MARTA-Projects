using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace TCSU.Layouts.TCSU
{
    public partial class TCSUDocSetNewForm : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SPWeb currentWeb = SPContext.Current.Web;

                SPList releasesList = currentWeb.Lists["Releases"];
                SPList revisionsList = currentWeb.Lists["Revisions"];
                SPList sectionsList = currentWeb.Lists["Sections"];
                
                //SPList disciplinesList = currentWeb.Lists["Disciplines"];

                ddlReleases.Items.Add(new ListItem("", "0"));
                ddlRevision.Items.Add(new ListItem("", "0"));
                ddlSectionFunctions.Items.Add(new ListItem("", "0"));
                
                //ddlDisciplines.Items.Add(new ListItem("", "0"));
                                 
                foreach (SPListItem release in releasesList.Items)
                {
                    ListItem li = new ListItem(release["Title"].ToString(), release["Title"].ToString());
                    ddlReleases.Items.Add(li);
                }

                foreach (SPListItem revision in revisionsList.Items)
                {
                    ListItem li = new ListItem(revision["Title"].ToString(), revision["Title"].ToString());
                    ddlRevision.Items.Add(li);
                }

                foreach (SPListItem section in sectionsList.Items)
                {
                    ListItem li = new ListItem(section["Title"].ToString(), section["Title"].ToString());
                    ddlSectionFunctions.Items.Add(li);
                }

                //foreach (SPListItem discipline in disciplinesList.Items)
                //{
                //    string desciplineCode = discipline["DesciplineCode"].ToString().Replace("string;#", "");
                //    ListItem li = new ListItem(desciplineCode, desciplineCode);
                //    ddlDisciplines.Items.Add(li);
                //}
                lnkReleases.NavigateUrl = releasesList.DefaultViewUrl;
                lnkRevisions.NavigateUrl = revisionsList.DefaultViewUrl;
                lnkSectionFunctions.NavigateUrl = sectionsList.DefaultViewUrl;
                //lnkDisciplines.NavigateUrl = disciplinesList.DefaultViewUrl;
               
            }
        }
    }
}
