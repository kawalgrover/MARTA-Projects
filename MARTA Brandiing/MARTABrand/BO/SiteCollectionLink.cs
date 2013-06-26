using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace MARTABrand.BO
{
    [DataContract]
    public class SiteCollectionLink
    {
        [DataMember]
        public string SiteCollectionTitle { get; set; }
        [DataMember]
        public string SiteCollectionUrl { get; set; }
    }
}
