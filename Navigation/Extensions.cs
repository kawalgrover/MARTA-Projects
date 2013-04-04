using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Navigation
{

    public static class UriExtensions
    {
        public static Uri Combine(this Uri relativeBaseUri, Uri relativeUri)
        {
            if (relativeBaseUri == null)
            {
                throw new ArgumentNullException("relativeBaseUri");
            }

            if (relativeUri == null)
            {
                throw new ArgumentNullException("relativeUri");
            }

            string baseUrl = VirtualPathUtility.AppendTrailingSlash(relativeBaseUri.ToString());
            string combinedUrl = VirtualPathUtility.Combine(baseUrl, relativeUri.ToString());

            return new Uri(combinedUrl, UriKind.Relative);
        }
    }

}
