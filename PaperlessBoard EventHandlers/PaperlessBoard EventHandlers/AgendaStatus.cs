using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace PaperlessBoard
{
    public static class AgendaStatus
    {
        public static string AgendaCreated = "Agenda Created";
    }

    public static class PaperLessBoardHelper
    {
        public static SPFieldUserValueCollection GetAgendaContentProviders(string agendaType)
        {
            SPList list = SPContext.Current.Web.Lists["Agenda Coordinators"];

            SPFieldUserValueCollection authUsers = null;

            if (list != null)
            {
                foreach (SPListItem item in list.Items)
                {
                    if (item["Agenda Type"].ToString() == agendaType)
                    {
                        string authUsersFieldValue = item["ContentProviders"].ToString();

                        authUsers = new SPFieldUserValueCollection(item.Web, authUsersFieldValue);
                        break;
                    }
                }
                return authUsers;
            }
            else
                return null;

        }

        public static SPFieldUserValueCollection GetKeyPeopleForAgenda(string agendaType, string agmOffice, SPItemEventProperties eventProperties)
        {
            string masterKeyPeopleListName = null;
            //SPFolder defaultDocuments =rootWeb.RootWeb.Folders["Default Documents"];
            SPWebApplication webApplication = eventProperties.Web.Site.WebApplication;
            if (webApplication.Properties != null && webApplication.Properties.Count > 0)
            {
                masterKeyPeopleListName = webApplication.Properties["MasterKeyPeopleListName"].ToString();
            }

            SPList list = eventProperties.Web.Lists[masterKeyPeopleListName];

            SPFieldUserValueCollection authUsers = new SPFieldUserValueCollection();

            if (list != null)
            {
                foreach (SPListItem item in list.Items)
                {
                    if ((item["Agenda Type"].ToString() == agendaType) && (item["AGM Office"].ToString() == agmOffice) && (item["Position"].ToString() == "Agenda Coordinator"))
                    {
                        string authUsersFieldValue = item["KeyPerson"].ToString();

                        authUsers.Add(new SPFieldUserValue(item.Web, authUsersFieldValue));
                        //break;
                    }
                }
                return authUsers;
            }
            else
                return null;
        }
    }
}
