using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WF1
{
    public class WFData
    {
        public string TechnologyManager { get; set; }
        public string FinanceManager { get; set; }
        public string Superviser { get; set; }

        public static WFData DeserializeFormData(string xmlString)
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(xmlString)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(WFData));
                WFData data = (WFData)serializer.Deserialize(stream);
                return data;
            }
        }
    }
}
