using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace ExecutiveTaskTracking.Fields
{
    public class ExecutiveAssignedToField : SPFieldChoice
    {
        #region Constructors
        public ExecutiveAssignedToField(SPFieldCollection fields, string fieldName)
            : base(fields, fieldName)
        {
        }

        public ExecutiveAssignedToField(SPFieldCollection fields, string typeName, string displayName)
            : base(fields, typeName, displayName)
        {
        }
        #endregion

        #region Properties
        public override BaseFieldControl FieldRenderingControl
        {
            get
            {
                return new ExecutiveAssignedToFieldControl() { FieldName = base.InternalName };
            }
        }

        #endregion
    }
}
