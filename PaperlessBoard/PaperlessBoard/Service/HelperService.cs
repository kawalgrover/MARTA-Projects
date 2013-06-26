using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using Microsoft.SharePoint;
using System.ServiceModel;

namespace MARTA.PaperlessBoard
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
#if DEBUG
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
#endif
    public class HelperService : IHelperService
    {
        public List<BoardMeetingInfo> BoardMeetings(string committee)
        {
            return GetBoardMeetings(committee);
        }

        private List<BoardMeetingInfo> GetBoardMeetings(string meetingType)
        {
            List<BoardMeetingInfo> boardMeetings = new List<BoardMeetingInfo>();

            using (SPSite site = new SPSite("http://m264981:1411"))
            using (SPWeb web = site.OpenWeb())
            {
                SPList list = web.Lists["Board Meeting"];
                SPListItemCollection meetings = list.Items;

                foreach (SPListItem meeting in meetings)
                {
                    if (meeting["Committee"].ToString() == meetingType)
                    {
                        DateTime meetingStartTime = DateTime.Parse(meeting["EventDate"].ToString());
                        if (meetingStartTime > DateTime.Now)
                        {
                            BoardMeetingInfo bmi = new BoardMeetingInfo()
                            {
                                StartTime = DateTime.Parse(meeting["EventDate"].ToString()),
                                Title = meeting["Title"].ToString(),
                                WorkspaceURL = meeting["Workspace"].ToString(),
                                MeetingID = meeting.ID
                            };
                            boardMeetings.Add(bmi);
                        }
                    }
                }
            }

            return boardMeetings;
        }
    }
}
