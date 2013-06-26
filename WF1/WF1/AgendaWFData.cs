using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WF1
{
    [Serializable()]
    public class AgendaWFData
    {
        public string AdHocUserNames { get; set; }

        public string AGM_Finance { get; set; }

        public string AGM_IT { get; set; }

        public string AGM_Planning { get; set; }

        public string AGM_HumanResource { get; set; }

        public string AGM_Safety { get; set; }

        public string AGM_Legal { get; set; }

        public string AGM_Contracts { get; set; }

        public string AGM_Audit { get; set; }

        public string AGM_BusOperations { get; set; }

        public string AGM_RaiOperations { get; set; }

        public string AGM_Communications { get; set; }

        public string Executive_Director { get; set; }

        public string AGM_Police { get; set; }

        public string AdHocUser1 { get; set; }

        public string AdHocUser2 { get; set; }

        public string AdHocUser3 { get; set; }

        public string AdHocUser4 { get; set; }

        public string AdHocUser1Selected { get; set; }

        public string AdHocUser2Selected { get; set; }
        
        public string AdHocUser3Selected { get; set; }

        public string AdHocUser4Selected { get; set; }

        public string IsExpedited { get; set; }

        public string Expedited_DGMSelected { get; set; }

        public string Expedited_CBSSSelected { get; set; }
    }
}
