using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace ExecutiveTaskTracking
{
    internal static class Utils
    {
        internal static SPFieldUserValue GetSPUserValue(SPListItem item, string key)
        {
            SPFieldUser field = item.Fields[key] as SPFieldUser;

            if (field != null && item[key] != null)
            {
                SPFieldUserValue fieldValue = field.GetFieldValue(item[key].ToString()) as SPFieldUserValue;
                return fieldValue;
            }
            return null;
        }
    }
}
