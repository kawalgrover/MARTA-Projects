using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MARTA.Services.PaperlessBoard
{
    public class BoardMeetingInfo
    {
        public DateTime StartTime { get; set; }

        public string Title { get; set; }

        public string WorkspaceURL { get; set; }

        public int MeetingID { get; set; }
    }
}