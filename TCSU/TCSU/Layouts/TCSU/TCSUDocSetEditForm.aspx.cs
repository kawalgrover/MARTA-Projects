using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;

namespace TCSU.Layouts.TCSU
{
    public partial class TCSUDocSetEditForm : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SPWeb currentWeb = SPContext.Current.Web;

                SPList releasesList = currentWeb.Lists["Releases"];
                SPList revisionsList = currentWeb.Lists["Revisions"];
                SPList sectionsList = currentWeb.Lists["Sections"];
                
                SPList disciplinesList = currentWeb.Lists["Disciplines"];

                ddlReleases.Items.Add(new ListItem("", "0"));
                ddlRevision.Items.Add(new ListItem("", "0"));
                ddlSectionFunctions.Items.Add(new ListItem("", "0"));
                
                

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

                

                SPList currentList = SPContext.Current.List;
                SPListItem currentItem = currentList.GetItemById(SPContext.Current.ItemId);

                //Populate the ListBox based on the Discipline value
                if (currentItem["Discipline"] != null)
                {
                    string discipline = currentItem["Discipline"].ToString();
                    SPQuery query = new SPQuery();
                    query.Query = string.Format(@"<Where>
                            <Eq><FieldRef Name='Discipline'/><Value Type='Choice'>{0}</Value></Eq>
                        </Where>", discipline);

                    SPListItemCollection locationVehicles = disciplinesList.GetItems(query);

                    foreach (SPListItem locationVehicle in locationVehicles)
                    {
                        string lv = string.Format("{0} - {1}", locationVehicle["Title"].ToString(), locationVehicle["Code"].ToString());

                        lbLocationVehicles.Items.Add(new ListItem(lv, lv));
                    }

                    if (currentItem["Location/Vehicle"] != null)
                    {
                        lbLocationVehicles.SelectedValue = currentItem["Location/Vehicle"].ToString();
                    }
                }

               

                if (currentItem["Release"] != null)
                {
                    ddlReleases.SelectedValue = currentItem["Release"].ToString();
                }

                if (currentItem["Revision"] != null)
                {
                    ddlRevision.SelectedValue = currentItem["Revision"].ToString();
                }

                if (currentItem["SectionFunction"] != null)
                {
                    ddlSectionFunctions.SelectedValue = currentItem["SectionFunction"].ToString();
                }

                
                lnkReleases.NavigateUrl = releasesList.DefaultViewUrl;
                lnkRevisions.NavigateUrl = revisionsList.DefaultViewUrl;
                lnkSectionFunctions.NavigateUrl = sectionsList.DefaultViewUrl;
                
            }
        }
    }
}
