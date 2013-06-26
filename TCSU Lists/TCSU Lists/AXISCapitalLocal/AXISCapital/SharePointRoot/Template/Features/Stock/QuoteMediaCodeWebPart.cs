using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace AXISCapital.UI.WebControls.WebParts
{
    [Guid("f93b24b1-e3c0-4f99-95e8-b7bb9949bc12")]
    public class QuoteMediaCodeWebPart : Microsoft.SharePoint.WebPartPages.WebPart
    {
        public QuoteMediaCodeWebPart()
        {

        }
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("<hr  class='hrdbar' />");
            writer.Write("<table width='100%'  cellpadding='0' cellspacing='0'><tr><td align='left'><span class='mywebparttitle'>Stock</span></td></tr></table>");
            writer.Write("<table width='100%' border='0' cellspacing='0' cellpadding='0'><tr>"
            + "<td height='20' align='left' valign='middle'></td>"
            + "</tr></table><div id='wrapper' style='text-align:left'>"
            + "<table id='customChart' border='0' width='100%' cellpadding='0' cellspacing='0'>"
            + "<script src='http://app.quotemedia.com/quotetools/jsVarsQuotesSpan.go?symbol=AXS&webmasterId=101568&df=MMMM d, yyyy h:ma z'></script>"
            + "<tr><td colspan='3' class='qmHeader'>AXIS Capital Hold (AXS)</td></tr>"
            + "<tr style='background-color: #F0F0F0;'>"
            + "<td class='qmSymbol'>AXS &nbsp; &#124;</td>"
            + "<td class='qmLast'><script>document.write(qmQuote.last);</script></td>"
            + "<td class='qmChange'><script>document.write(qmQuote.change);</script></td></tr></table>"
            + "<div id='miniCharts'>"
            + "<script LANGUAGE='javascript' type='text/javascript' src='http://app.quotemedia.com/quotetools/miniCharts.go?webmasterId=101568&symbol=AXS&toolWidth=210&chhig=120&chsym= &chbgch=F0F0F0&chbg=F0F0F0&chln=5A8EBF&chbdr=cccccc&chgrd=F0F0F0&chfill=B2D0F4&chfill2=B2D0F4'></script></div></div>");
        }
    }
}
