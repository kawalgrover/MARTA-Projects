using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace PB_Emis.List_Definitions.Board_Meetings.Board_Meeting_List.BoardMeetingAddingReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class BoardMeetingAddingReceiver : SPItemEventReceiver
    {
       /// <summary>
       /// An item is being added.
       /// </summary>
       public override void ItemAdding(SPItemEventProperties properties)
       {
           string committee = properties.AfterProperties["Board Committee"].ToString();
           DateTime eventDate = DateTime.Parse(properties.AfterProperties["EventDate"].ToString());
           DateTime beginningOfMonth = new DateTime(eventDate.Year, eventDate.Month, 1);
           DateTime endOfMonth = beginningOfMonth.AddMonths(1);
           endOfMonth = endOfMonth.AddDays(-1);

           string eventMonth = eventDate.ToString("MMMM");
           string eventYear = eventDate.Year.ToString();

           SPQuery query = new SPQuery()
           {
               Query = string.Format(@"
                    <Query>
                        <Where>
                            <And>
                                <Geq>
                                   <FieldRef Name=""EventDate"" />
                                     <Value Type=""DateTime"">
                                        {0}
                                    </Value>
                                </Geg>
                                <Leq>
                                     <FieldRef Name=""EventDate"" />
                                     <Value Type=""DateTime"">
                                        {1}
                                    </Value>
                                </Leq>
                                <Eq>
                                    <FieldRef Name=""Board Committee"" />
                                     <Value Type=""Choice"">
                                        {2}
                                    </Value>
                                </Eq>
                            </And>
                        </Where>
                    </Query>", 
                            SPUtility.CreateISO8601DateTimeFromSystemDateTime(beginningOfMonth),
                            SPUtility.CreateISO8601DateTimeFromSystemDateTime(endOfMonth),
                            committee)
                            
           };

           SPListItemCollection meetings = properties.List.GetItems(query);

           
           /*Temporary code till the CAML Query is working correctly */
           int itemsInMonth = 0;
           foreach (SPListItem meeting in meetings)
           {
               DateTime meetingTime = DateTime.Parse(meeting["EventDate"].ToString());

               if ((meetingTime > beginningOfMonth) && (meetingTime < endOfMonth))
               {
                   if (meeting["Board Committee"].ToString() == committee)
                   {
                       itemsInMonth++;
                   }
               }
           }

           /* End of Temporary Code */


           //
           int meetingNumber = itemsInMonth + 1;

           properties.AfterProperties["Title"] = string.Format("{0} - {1}, {2} - Meeting {3}",
               committee, eventMonth, eventYear, meetingNumber.ToString());

           base.ItemAdding(properties);
       }

       /// <summary>
       /// An item is being updated.
       /// </summary>
       public override void ItemUpdating(SPItemEventProperties properties)
       {
           base.ItemUpdating(properties);
       }


    }
}
