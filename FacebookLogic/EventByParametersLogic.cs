using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic
{
     public class EventByParametersLogic
     {
          public string m_SelectedAgeRange { get; set; } = "24 - 30";

          private Point m_AgeRange = new Point(24, 30);

          public eReligions m_SelectedReligion { get; set; } = eReligions.Chrisitianity;

          public eTimeFrame m_SelectedTimeFrame { get; set; } = eTimeFrame.Morning;

          public eGender m_SelectedSexPreference { get; set; } = eGender.male;

          public User CurrentLoggedInUser { get; set; }

          private readonly Dictionary<int, CustomizedEventLogic> m_KeyToCustomizedEventLogicMap= new Dictionary<int, CustomizedEventLogic>();

          public Dictionary<int, CustomizedEventLogic> KeyToCustomizedEventLogicMap
          {
               get
               {
                    return m_KeyToCustomizedEventLogicMap;
               }
          }

          private Dictionary<Point, eTimeFrame> m_DurationToTimeframe = new Dictionary<Point, eTimeFrame>()
                              {
                                   { new Point(0, 0), eTimeFrame.Midnight },
                                   { new Point(0, 3), eTimeFrame.MidnightToDawn },
                                   { new Point(3, 6), eTimeFrame.EarlyMorning },
                                   { new Point(6, 12), eTimeFrame.Morning },
                                   { new Point(12, 16), eTimeFrame.Midday },
                                   { new Point(16, 19), eTimeFrame.Afternoon },
                                   { new Point(19, 23), eTimeFrame.Evening },
                              };

          public event EventHandler EventsFetchedErrorOccured;
          public event EventHandler FriendsFetchedErrorOccured; 
          public event EventHandler GenderFieldFetchedErrorOccured;
          public event EventHandler FilteredMatchingEventFound;

          private User m_LoggedInUser { get; }

          public EventByParametersLogic(User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
          }

          internal void OnFilteredMatchingEventFound(EventArgs e, Object sender)
          {
               EventHandler handler = FilteredMatchingEventFound;
               if (handler != null)
               {
                    handler.Invoke(sender as CustomizedEventLogic, e);
               }
          }
          
          internal void OnEventsFetchedErrorOccured(EventArgs e)
          {
               EventHandler handler = EventsFetchedErrorOccured;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void OnFriendsFetchedErrorOccured(EventArgs e)
          {
               EventHandler handler = FriendsFetchedErrorOccured;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void OnGenderFieldFetchedErrorOccured(EventArgs e)
          {
               EventHandler handler = GenderFieldFetchedErrorOccured;

               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void GenerateListOfFilteredEvents()
          {
               if (!IsFriendListEmpty(CurrentLoggedInUser.Friends))
               {
                    foreach (User friend in LoginManager.Instance.LoggedInUser.Friends)
                    {
                         FacebookObjectCollection<Event> friendfEvents = friend.Events;
                         int currentFriendAge = calculateAgeByBirth(friend.Birthday);
                         eGender currentFriendSex = eGender.male; // Default
                         if (friend.Gender.HasValue)
                         {
                              currentFriendSex = friend.Gender.Value;
                         }
                         else
                         {
                              OnGenderFieldFetchedErrorOccured(EventArgs.Empty);
                         }

                         if (isCriterionsMatchingFriend(currentFriendAge, currentFriendSex) && friendfEvents.Count > 1)
                         {
                              bool eventIsMatching = false;
                              foreach (Event friendEvent in friendfEvents)
                              {
                                  eTimeFrame? currentEventTimeFrame = getCurrentEventTimeFrameOrNull(friendEvent);

                                   if (currentEventTimeFrame.HasValue && currentEventTimeFrame.Value.Equals(m_SelectedTimeFrame))
                                   {
                                        Director customizedEventDirector = new Director();
                                        CustomizedEventBuilder customizedEventBuilder = new CustomizedEventBuilder(friendEvent, friend, currentEventTimeFrame.Value);
                                        customizedEventDirector.ConstructCustomizedEvent(customizedEventBuilder);
                                        OnFilteredMatchingEventFound(EventArgs.Empty, customizedEventBuilder.CustomizedEvent);
                                        eventIsMatching = true;
                                        // Adding to logic storage
                                        m_KeyToCustomizedEventLogicMap.Add(customizedEventBuilder.CustomizedEvent.m_Key, customizedEventBuilder.CustomizedEvent);
                                   }
                              }

                              if (eventIsMatching == false)
                              {
                                   OnEventsFetchedErrorOccured(EventArgs.Empty);
                              }
                         }
                         else
                         {
                                   OnEventsFetchedErrorOccured(EventArgs.Empty);
                         }
                    }
               }
               else
               {
                    OnFriendsFetchedErrorOccured(EventArgs.Empty);
               }
          }

          internal eTimeFrame? getCurrentEventTimeFrameOrNull(Event i_CriterionizedFriendEvent)
          {
              Point duration = getDurationPointToMap(
                                     int.Parse(i_CriterionizedFriendEvent.StartTime.Value.ToString("HH")),
                                     int.Parse(i_CriterionizedFriendEvent.EndTime.Value.ToString("HH")),
                                     i_CriterionizedFriendEvent.StartTime.Value.ToString("tt"));
               
               return m_DurationToTimeframe.TryGetValue(duration, out eTimeFrame currentEventTimeFrame) ? 
                         currentEventTimeFrame : (eTimeFrame?)null;
          }

          internal void MapAndExtractPointByStr(string selectedAgeRangeStr)
          {
               switch (m_SelectedAgeRange)
               {
                    case "under 18":
                         m_AgeRange.X = 1;
                         m_AgeRange.Y = 17;
                         break;

                    case "18 - 24":
                         m_AgeRange.X = 18;
                         m_AgeRange.Y = 24;
                         break;

                    case "24 - 30":
                         m_AgeRange.X = 24;
                         m_AgeRange.Y = 30;
                         break;

                    case "30 - 40":
                         m_AgeRange.X = 30;
                         m_AgeRange.Y = 40;
                         break;

                    case "40 - 50":
                         m_AgeRange.X = 40;
                         m_AgeRange.Y = 50;
                         break;

                    case "50 - 60":
                         m_AgeRange.X = 50;
                         m_AgeRange.Y = 60;
                         break;

                    case "over 60":
                         m_AgeRange.X = 60;
                         m_AgeRange.Y = 120;
                         break;

                    default:
                         break;
               }
          }
          
          #region Enumeration
          public enum eReligions
          {
               Judaism,
               Islam,
               Chrisitianity,
               Budhism,
               Hinduism
          }

          public enum eTimeFrame
          {
               EarlyMorning,
               Morning,
               Midday,
               Afternoon,
               Evening,
               Midnight,
               MidnightToDawn
          }

          #endregion
                    
          private bool IsFriendListEmpty(FacebookObjectCollection<User> i_Friends)
          {
               return i_Friends.Count >= 1;
          }

          internal Point getDurationPointToMap(int i_StartTimeNumericHour, int i_EndTimeNumericHour, string i_AMorPM)
          {
               Point mappedDuration = new Point();

               if (i_AMorPM.Equals("PM"))
               {
                    i_StartTimeNumericHour += 12;
                    i_EndTimeNumericHour += 12;
               }

               if (i_StartTimeNumericHour >= 0 && i_EndTimeNumericHour <= 3)
               {
                    mappedDuration.X = 0;
                    mappedDuration.Y = 3;
               }
               else if (i_StartTimeNumericHour >= 3 && i_EndTimeNumericHour <= 6)
               {
                    mappedDuration.X = 3;
                    mappedDuration.Y = 6;
               }
               else if (i_StartTimeNumericHour >= 6 && i_EndTimeNumericHour <= 12)
               {
                    mappedDuration.X = 6;
                    mappedDuration.Y = 12;
               }
               else if (i_StartTimeNumericHour >= 12 && i_EndTimeNumericHour <= 16)
               {
                    mappedDuration.X = 12;
                    mappedDuration.Y = 16;
               }
               else if (i_StartTimeNumericHour >= 16 && i_EndTimeNumericHour <= 19)
               {
                    mappedDuration.X = 16;
                    mappedDuration.Y = 19;
               }
               else if (i_StartTimeNumericHour >= 19 && i_EndTimeNumericHour <= 23)
               {
                    mappedDuration.X = 19;
                    mappedDuration.Y = 23;
               }

               return mappedDuration;
          }

          private bool isCriterionsMatchingFriend(int i_CurrentFriendAge, eGender i_CurrentFriendSex)
          {
               return i_CurrentFriendAge >= m_AgeRange.X &&
                   i_CurrentFriendAge <= m_AgeRange.Y &&
                   i_CurrentFriendSex.Equals(m_SelectedSexPreference);
          }

          private int calculateAgeByBirth(string birthday)
          {
               DateTime birthDate = Convert.ToDateTime(birthday);
               int age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
               return age;
          }       
     }
}
