using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
     public class CustomizedEventBuilder : IBuilder
     {
          private CustomizedEventModel m_CustomizedEventLogicItem = new CustomizedEventModel();
          
          // Basic details of a customized event
          private Event m_CriterionizedEvent;
          private User m_CriterionizedFriend;
          private EventByParametersModel.eTimeFrame m_EventTimeFrame;

          public CustomizedEventBuilder(Event i_CritirionizedFriendEvent, User i_CritirionizedFriend, EventByParametersModel.eTimeFrame i_TimeFrame)
          {
               m_CriterionizedEvent = i_CritirionizedFriendEvent;
               m_CriterionizedFriend = i_CritirionizedFriend;
               m_EventTimeFrame = i_TimeFrame;
          }

          public void BuildEventDiscriptionPart()
          {
               m_CustomizedEventLogicItem.m_EventName = m_CriterionizedEvent.Name.ToString() ?? null;
               m_CustomizedEventLogicItem.m_EventDescription = m_CriterionizedEvent.Description ?? null;
               // "missing" visibility of components 

               if (m_CustomizedEventLogicItem.m_EventName is null || m_CustomizedEventLogicItem.m_EventDescription is null)
               {
                   m_CustomizedEventLogicItem.OnEventDescriptionFetchingErrorOccured(EventArgs.Empty);                   
               }
          }    
          
          public void BuildEventLocationDetailsPart()
          {
               m_CustomizedEventLogicItem.m_PlaceName = m_CriterionizedEvent.Place.ToString() ?? null;
               m_CustomizedEventLogicItem.m_VenueName = m_CriterionizedEvent.Venue.ToString() ?? null;

               if (m_CustomizedEventLogicItem.m_PlaceName is null || m_CustomizedEventLogicItem.m_VenueName is null)
               {
                    m_CustomizedEventLogicItem.OnEventLocationFetchingErrorOccured(EventArgs.Empty);
               }

          }
          
          public void BuildEventTimeRelatedDetailsPart()
          {
               m_CustomizedEventLogicItem.m_StartingTime = m_CriterionizedEvent.StartTime ?? null;
               m_CustomizedEventLogicItem.m_EndingTime = m_CriterionizedEvent.EndTime ?? null;
               m_CustomizedEventLogicItem.m_DurationTime = string.Format(
                                        "{0} at {1} - {2} at {3}",
                                        m_CustomizedEventLogicItem.m_StartingTime.Value.ToString("dd/MM"),
                                        m_CustomizedEventLogicItem.m_StartingTime.Value.ToString("hh:mm tt"),
                                        m_CustomizedEventLogicItem.m_EndingTime.Value.ToString("hh:mm tt"),
                                        m_CustomizedEventLogicItem.m_EndingTime.Value.ToString("dd/MM"));
               m_CustomizedEventLogicItem.m_TimeFrame = m_EventTimeFrame.ToString() ?? null;

               if (m_CustomizedEventLogicItem.m_StartingTime is null || m_CustomizedEventLogicItem.m_EndingTime is null 
                    || m_CustomizedEventLogicItem.m_DurationTime is null || m_CustomizedEventLogicItem.m_TimeFrame is null)  
               {
                    m_CustomizedEventLogicItem.OnEventTimeRelatedDetailsErrorOccured(EventArgs.Empty);
               }
          }
          
          public void BuildFriendDetailsPart()
          {
               m_CustomizedEventLogicItem.m_FriendPictureUrl = m_CriterionizedFriend.PictureNormalURL ?? null;
               m_CustomizedEventLogicItem.m_FriendName = string.Format(m_CustomizedEventLogicItem.m_nameFormat, m_CriterionizedFriend.FirstName, m_CriterionizedFriend.LastName);
               m_CustomizedEventLogicItem.m_Attendance = getFriendAttendance(m_CriterionizedFriend, m_CriterionizedEvent) ?? null;

               if (m_CustomizedEventLogicItem.m_FriendPictureUrl is null || m_CustomizedEventLogicItem.m_FriendName is null || m_CustomizedEventLogicItem.m_Attendance is null)
               {
                    m_CustomizedEventLogicItem.OnEventFriendsDetailErrorOccured(EventArgs.Empty);
               }

          }

          private string getFriendAttendance(User io_CurrentFriend, Event io_CurrentEvent)
          {
               string friendAttendece = "Participating";

               // Assuming the events of the user are approved ones, since there isn't approved events field
               foreach (Event maybeEvent in io_CurrentFriend.EventsMaybe)
               {
                    if (maybeEvent.Equals(io_CurrentEvent))
                    {
                         friendAttendece = "Maybe";
                    }
               }

               foreach (Event createdEvent in io_CurrentFriend.EventsCreated)
               {
                    if (createdEvent.Equals(io_CurrentEvent))
                    {
                         friendAttendece = "Created Event";
                    }
               }

               return friendAttendece;
          }
          
          public CustomizedEventModel CustomizedEvent
          {
               get
               {
                    return m_CustomizedEventLogicItem;
               }
          }
     }
}
