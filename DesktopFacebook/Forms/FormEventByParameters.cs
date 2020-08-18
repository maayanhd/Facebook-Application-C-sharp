using CustomControls;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace DesktopFacebook.Forms
{
     public partial class FormEventByParameters : Form
     {
          private readonly User m_CurrentLoggedInUser;
          public string m_SelectedAgeRange { get; set; } = "24 - 30";
          private Point m_AgeRange = new Point(24, 30);
          public eReligions m_SelectedReligion { get; set; } = eReligions.Chrisitianity;
          public eTimeFrame m_SelectedTimeFrame { get; set; } = eTimeFrame.Morning;
          public eGender m_SelectedSexPreference { get; set; } = eGender.male;

          public FlowLayoutPanel FlowLayoutPanelCutomedEvents
          {
               get
               {
                    return flowLayoutPanelCutomedEvents;
               }
          }

          public FlowLayoutPanel flowLayoutPanelCutomedEvents { get; private set; }

          Dictionary<Point, eTimeFrame> m_DurationToTimeframe = new Dictionary<Point, eTimeFrame>()
                              {
                                   {new Point(0,0), eTimeFrame.Midnight},
                                   {new Point(0,3), eTimeFrame.MidnightToDawn},
                                   {new Point(3,6), eTimeFrame.EarlyMorning},
                                   {new Point(6,12), eTimeFrame.Morning},
                                   {new Point(12,16), eTimeFrame.Midday},
                                   {new Point(16,19), eTimeFrame.Afternoon},
                                   {new Point(19,23), eTimeFrame.Evening},
                              };
          public FormEventByParameters(User io_LoggedInUser)
          {
               InitializeComponent();
               this.FormBorderStyle = FormBorderStyle.FixedDialog;
          }

          private void comboBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
          {
               m_SelectedAgeRange = (sender as ComboBox).SelectedItem.ToString();
               testerlabel.Text = m_SelectedAgeRange;

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

          // Generating the items of event by the given parameters of the users
          private void generateListOfEventByParameters()
          {
               try
               {
                    FacebookObjectCollection<User> friendsCollections = m_CurrentLoggedInUser.Friends;

                    foreach (User friend in friendsCollections)
                    {
                         FacebookObjectCollection<Event> friendfEvents = friend.Events;
                         int currentFriendAge = calculateAgeByBirth(friend.Birthday);
                         eGender currentFriendSex = eGender.male; // Default
                         if (friend.Gender.HasValue)
                         {
                              currentFriendSex = friend.Gender.Value;
                              testerlabel.Text = currentFriendSex.ToString();
                         }
                         else
                         {
                              MessageBox.Show(
                                   "Please choose a sex preference first",
                                   "Sex Preference missing",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.None);
                         }

                         if (isCriterionsMatchingFriend(currentFriendAge, currentFriendSex))
                         {
                              foreach (Event friendEvent in friendfEvents)
                              {
                                   Point duration = getDurationPointToMap(int.Parse(friendEvent.StartTime.Value.ToString("HH")),
                                                                int.Parse(friendEvent.EndTime.Value.ToString("HH")),
                                                                friendEvent.StartTime.Value.ToString("tt"));
                                   m_DurationToTimeframe.TryGetValue(duration, out eTimeFrame currentEventTimeFrame);

                                   string friendAttendence = getFriendAttendence(friend, friendEvent);

                                   testerlabel.Text = friendAttendence;
                                   if (currentEventTimeFrame.Equals(m_SelectedTimeFrame))
                                   {

                                        FlowLayoutPanelCutomedEvents.Controls.Add(createEventCustomedItem(friendEvent, friend, currentEventTimeFrame, friendAttendence));
                                   }
                              }
                         }
                    }
               }
               catch (NullReferenceException)
               {
                    throw new NullReferenceException("Error: retrieving Friends or friend's events null exception");
               }
               catch (Exception)
               {
                    throw new Exception("Unknown exception");
               }
          }
          private string getFriendAttendence(User io_CurrentFriend, Event io_CurrentEvent)
          {
               string friendAttendece = "Participating";
               //Assuming the events of the user are approved ones, since there isn't approved events field
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

          private Point getDurationPointToMap(int i_StartTimeNumericHour, int i_EndTimeNumericHour, string i_AMorPM)
          {
               Point mappedDuration = new Point();
               //{ new Point(0, 0), eTimeFrame.Midnight},
               //                    { new Point(0, 3), eTimeFrame.MidnightToDawn},
               //                    { new Point(3, 6), eTimeFrame.EarlyMorning},
               //                    { new Point(6, 12), eTimeFrame.Morning},
               //                    { new Point(12, 16), eTimeFrame.Midday},
               //                    { new Point(16, 19), eTimeFrame.Afternoon},
               //                    { new Point(19, 23), eTimeFrame.Evening},
               testerlabel.Text = i_StartTimeNumericHour.ToString();
               testerlabel.Text = i_EndTimeNumericHour.ToString();

               if (i_AMorPM.Equals("PM"))
               {
                    i_StartTimeNumericHour += 12;
                    i_EndTimeNumericHour += 12;
               }

               if (i_StartTimeNumericHour >= 0 && i_EndTimeNumericHour <= 3)
               {
                    mappedDuration.X = 0; mappedDuration.Y = 3;
               }
               else if (i_StartTimeNumericHour >= 3 && i_EndTimeNumericHour <= 6)
               {
                    mappedDuration.X = 3; mappedDuration.Y = 6;
               }
               else if (i_StartTimeNumericHour >= 6 && i_EndTimeNumericHour <= 12)
               {

               }
               else if (i_StartTimeNumericHour >= 6 && i_EndTimeNumericHour <= 12)
               {
                    mappedDuration.X = 6; mappedDuration.Y = 12;
               }
               else if (i_StartTimeNumericHour >= 12 && i_EndTimeNumericHour <= 16)
               {
                    mappedDuration.X = 12; mappedDuration.Y = 16;
               }
               else if (i_StartTimeNumericHour >= 16 && i_EndTimeNumericHour <= 19)
               {
                    mappedDuration.X = 16; mappedDuration.Y = 19;
               }
               else if (i_StartTimeNumericHour >= 19 && i_EndTimeNumericHour <= 23)
               {
                    mappedDuration.X = 19; mappedDuration.Y = 23;
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

          private EventCustomedItem createEventCustomedItem(Event i_CriterionizedEvent, User i_CriterionizedFriend, eTimeFrame i_CurrentEventTimeFrame, string i_FriendEventAttendence)
          {
               EventCustomedItem eventCustomedItem = new EventCustomedItem();
               const string Format = "{1} {2}";

               eventCustomedItem.PictureBoxFriendProfile.LoadAsync(i_CriterionizedFriend.PictureNormalURL);
               eventCustomedItem.LabelFriendName.Text = string.Format(Format, i_CriterionizedFriend.FirstName, i_CriterionizedFriend.LastName);
               eventCustomedItem.LabelAttendence.Text = i_FriendEventAttendence;

               eventCustomedItem.LabelPlaceName.Text = i_CriterionizedEvent.Place.ToString();
               DateTime currentEventStartTime = i_CriterionizedEvent.StartTime.Value,
                        currentEventEndTime = i_CriterionizedEvent.EndTime.Value;

               eventCustomedItem.LabelDurationTime.Text = string.Format("{0} at {1} - {2} at {3}",
                    currentEventStartTime.ToString("dd/MM"),
                    currentEventStartTime.ToString("hh:mm tt"),
                    currentEventEndTime.ToString("hh:mm tt"),
                    currentEventEndTime.ToString("dd/MM"));
               eventCustomedItem.LabelVenueName.Text = i_CriterionizedEvent.Venue.ToString();
               eventCustomedItem.LabelTimeFrame.Text = i_CurrentEventTimeFrame.ToString();
               eventCustomedItem.LabelDescriptionContent.Text = i_CriterionizedEvent.Description;

               return eventCustomedItem;
          }

          private void customPictureBoxButtonFilterEvent_Click(object sender, EventArgs e)
          {
               generateListOfEventByParameters();
          }

          private void comboBoxTimeFrame_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    eTimeFrame timeFrameParsed = (eTimeFrame)Enum.Parse(typeof(eTimeFrame), (sender as ComboBox).SelectedItem.ToString());
                    testerlabel.Text = timeFrameParsed.ToString();
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(eTimeFrame)));
               }
          }

          private void comboBoxReligion_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    m_SelectedReligion = (eReligions)Enum.Parse(typeof(eReligions), (sender as ComboBox).SelectedIndex.ToString());
                    testerlabel.Text = m_SelectedReligion.ToString();
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(eTimeFrame)));
               }
          }

          private void comboBoxSexPreference_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    m_SelectedSexPreference = (eGender)Enum.Parse(typeof(eGender), (sender as ComboBox).SelectedItem.ToString());
                    testerlabel.Text = m_SelectedSexPreference.ToString();
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(eTimeFrame)));
               }
          }

          private void customPictureBoxButtonFilterEvent_MouseHover(object sender, EventArgs e)
          {
               (sender as CustomPictureBoxButton).Image = (sender as CustomPictureBoxButton).m_HoverImage;
          }

          private void customPictureBoxButtonFilterEvent_MouseLeave(object sender, EventArgs e)
          {
               (sender as CustomPictureBoxButton).Image = (sender as CustomPictureBoxButton).m_NormalImage;
          }

          
     }
}
