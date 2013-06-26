using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Microsoft.Office.Server;
using Microsoft.Office.Server.UserProfiles;
using Microsoft.Office.Server.Search.Administration;
using System.IO;


namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("cb383a9a-ab9e-4050-9f32-950ca49f215d")]
    public class SearchBoxWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        public SearchBoxWebPart()
        {
            this.ExportMode = WebPartExportMode.All;
        }
        protected override void Render(HtmlTextWriter writer)
        {
            try
            {
                SearchContext _searchContext = SearchContext.Current;

                if (_searchContext != null)
                {
                    Scopes _scopes = new Scopes(_searchContext);
                    string _options = string.Empty;
                    foreach (Scope scop in _scopes.AllScopes)
                    {
                        _options += "<option value='" + scop.Name + "'>" + scop.Name + "</option>";
                    }
                    writer.Write("<table width='90%' class='searchtable' cellpadding='0' cellspacing='0'>"
                    + "<tr  height='32px'>"
                    + "<td colspan='2' class='searchtxt' align='left' style='background-color:#2066aa;'>Search</td></tr>"
                    + "<tr><td colspan='2' class = 'searchtr' align='left'><select id='drpsearchbox' class='drpsearch' >" + _options + "</select></td></tr>"
                    + "<tr><td class='searchtr' align='left'><input name='txtsearchbox' id='txtsearchbox' type='text' class='searchtextbox'  width='100%' /><input type='hidden' name='nameprefix$ASB_SS_scb_1_4' value='nameprefix$ASB_SS_scb_1_4'/></td><td class='searchtr' width='5%' align='left'><input id=\"Submit1\" onclick=\"WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions('nameprefix$ASB_BS_SRCH_1', '', false, '', '/Pages/SearchResult.aspx?k=' + document.getElementById('txtsearchbox').value + '&s=' + document.getElementById('drpsearchbox').value  , false, false))\" type=\"submit\" name=\"nameprefix$ASB_BS_SRCH_1\" value=\"Go\" /> </td></tr>"
                    + "</tr></table>");
                   

                }
            }
            catch (Exception exc)
            {
                writer.Write(exc.Message);
            }
        }
    }
}
