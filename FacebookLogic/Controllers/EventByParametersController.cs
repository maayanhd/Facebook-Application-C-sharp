using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using static FacebookLogic.Models.EventByParametersModel;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Controllers
{
     public class EventByParametersController
     {
          public EventByParametersModel EventsData { get; set; }

          public event EventHandler EventsFetchedErrorOccured;

          public event EventHandler FriendsFetchedErrorOccured;

          public event EventHandler GenderFieldFetchedErrorOccured;

          public event EventHandler FilteredMatchingEventFound;

          public EventByParametersController(
                        User i_LoggedInUser, 
                    EventHandler i_EventsFetchedErrorOccured, 
                    EventHandler i_FriendsFetchedErrorOccured,                                                                                       
                    EventHandler i_GenderFieldFetchedErrorOccured, 
                    EventHandler i_FilteredMatchingEventFound)
          {
               EventsData = new EventByParametersModel();
               EventsData.User = i_LoggedInUser;
               this.EventsData = EventsData;
               EventsFetchedErrorOccured += i_EventsFetchedErrorOccured;
               FilteredMatchingEventFound += i_FilteredMatchingEventFound;
               FriendsFetchedErrorOccured += i_FriendsFetchedErrorOccured;
               GenderFieldFetchedErrorOccured += i_GenderFieldFetchedErrorOccured;
          }

          public void HandleAgeRangeChanged(object sender)
          {
               string selectedAgeRangeStr = (sender as ComboBox).SelectedItem.ToString();
               MapAndExtractPointByStr(selectedAgeRangeStr);
          }

          public void GenerateListOfEventsByParameters()
          {
               generateListOfFilteredEvents();
          }

          public CustomizedEventModel HandleEventCustomedItemClickedByTag(object tag)
          {
               EventsData.KeyToCustomizedEventLogicMap.TryGetValue((int)tag, out CustomizedEventModel ClickedCustomizedEvent);
               
               return ClickedCustomizedEvent;
          }

          public void HandleSexPreferencePickChanged(object sender)
          {
               EventsData.SelectedSexPreference = (eGender)Enum.Parse(typeof(eGender), (sender as ComboBox).SelectedItem.ToString());
          }

          public void HandleTimeFramePickChanged(object sender)
          {
               EventsData.SelectedTimeFrame = (EventByParametersModel.eTimeFrame)Enum.Parse(typeof(EventByParametersModel.eTimeFrame), (sender as ComboBox).SelectedItem.ToString());
          }

          public void HandleReligionPickChanged(object sender)
          {
               EventsData.SelectedReligion = (EventByParametersModel.eReligions)Enum.Parse(typeof(EventByParametersModel.eReligions), (sender as ComboBox).SelectedIndex.ToString());
          }

          internal void OnFilteredMatchingEventFound(EventArgs e, object sender)
          {
               if (FilteredMatchingEventFound != null)
               {
                    FilteredMatchingEventFound.Invoke(sender as CustomizedEventModel, e);
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

          private void generateListOfFilteredEvents()
          {
               if (!IsFriendListEmpty(EventsData.User.Friends))
               {
                    foreach (User friend in LoginManager.Instance.LoggedInUser.Friends)
                    {
                         FacebookObjectCollection<Event> friendEvents = friend.Events;
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

                         if (isCriterionsMatchingFriend(currentFriendAge, currentFriendSex) && friendEvents.Count > 1)
                         {
                              bool eventIsMatching = false;
                              foreach (Event friendEvent in friendEvents)
                              {
                                   eTimeFrame? currentEventTimeFrame = getCurrentEventTimeFrameOrNull(friendEvent);

                                   if (currentEventTimeFrame.HasValue && currentEventTimeFrame.Value.Equals(EventsData.SelectedTimeFrame))
                                   {
                                        Director customizedEventDirector = new Director();
                                        CustomizedEventBuilder customizedEventBuilder = new CustomizedEventBuilder(friendEvent, friend, currentEventTimeFrame.Value);
                                        customizedEventDirector.ConstructCustomizedEvent(customizedEventBuilder);
                                        OnFilteredMatchingEventFound(EventArgs.Empty, customizedEventBuilder.CustomizedEvent);
                                        eventIsMatching = true;

                                        // Adding to logic storage
                                        EventsData.KeyToCustomizedEventLogicMap.Add(customizedEventBuilder.CustomizedEvent.Key, customizedEventBuilder.CustomizedEvent);
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

               return EventsData.DurationToTimeframe.TryGetValue(duration, out eTimeFrame currentEventTimeFrame) ?
                         currentEventTimeFrame : (eTimeFrame?)null;
          }

          internal void MapAndExtractPointByStr(string selectedAgeRangeStr)
          {
               switch (EventsData.SelectedAgeRange)
               {
                    case "under 18":
                         EventsData.AgeRange = new Point(1, 17);
                         break;

                    case "18 - 24":
                         EventsData.AgeRange = new Point(18, 24);
                         break;

                    case "24 - 30":
                         EventsData.AgeRange = new Point(24, 30);
                         break;

                    case "30 - 40":
                         EventsData.AgeRange = new Point(30, 40);
                         break;

                    case "40 - 50":
                         EventsData.AgeRange = new Point(40, 50);
                         break;

                    case "50 - 60":
                         EventsData.AgeRange = new Point(50, 60);
                         break;

                    case "over 60":
                         EventsData.AgeRange = new Point(60, 120);
                         break;

                    default:
                         break;
               }
          }

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
               return i_CurrentFriendAge >= EventsData.AgeRange.X &&
                   i_CurrentFriendAge <= EventsData.AgeRange.Y &&
                   i_CurrentFriendSex.Equals(EventsData.SelectedSexPreference);
          }

          private int calculateAgeByBirth(string birthday)
          {
               DateTime birthDate = Convert.ToDateTime(birthday);
               int age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
               return age;
          }
     }
}
