using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Web.Services;

namespace MARTA.PaperlessBoard
{
    [ServiceContract(Namespace="MARTA.PaperlessBoard")]
    public interface IHelperService
    {
        [OperationContract]
        [WebMethod]
        List<BoardMeetingInfo> BoardMeetings(string committee);
    }

    [DataContract]
    public class BoardMeetingInfo
    {
        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string WorkspaceURL { get; set; }

        [DataMember]
        public int MeetingID { get; set; }
    }
}
