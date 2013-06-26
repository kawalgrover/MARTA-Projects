using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace AgendaApprovalWorkflow
{
    [Serializable()]
    public class Workflow1Data
    {
        public bool TechnologyManager { get; set; }
        public bool FinanceManager { get; set; }
        public bool Superviser { get; set; }

        public static Workflow1Data DeserializeFormData(string xmlString)
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xmlString)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Workflow1Data));
                Workflow1Data data = (Workflow1Data)serializer.Deserialize(stream);
                return data;
            }
        }
    }

   
}
