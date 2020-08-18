using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebook.Forms
{
     public partial class FormEventByParameters : Form
     {
          private readonly User m_CurrentLoggedInUser;
          
          private readonly List<string> religionStrings = new List<string>{
               "Judaism",
               "Islam",
               "Chrisitianity",
               "Budhism",
               "Hinduism" };
          private readonly List<string> TimeFramesStrings = new List<string>
          {
               "Early Morning",
               "Morning",
               "Midday",
               "Afternoon",
               "Evening",
               "Midnight",
               "Midnight to Dawn"
          };

          private readonly List<string> SexPreferenceStrings = new List<string>
          {
               "Female",
               "Male"
           };

          public FormEventByParameters(User io_LoggedInUser)
          {
               InitializeComponent();
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void customPictureBoxButton1_Click(object sender, EventArgs e)
          {

          }

          private void comboBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
          {
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

          public enum eSexPreference
          {
               Male,
               Female
          }
          #endregion

          public ComboBox ComboBoxSexPreference
          {
               get
               {
                    return comboBoxSexPreference;
               }

          }

          // Generating the items of event by the given parameters of the users
          private void generateListOfEventByParameters()
          {
               FacebookObjectCollection<User> friendsCollections = m_CurrentLoggedInUser.Friends;
               string ageRangeString = comboBoxAgeRange.SelectedText;
               string TimeFrame = comboBoxAgeRange.SelectedText,
                    sexPreference = comboBoxSexPreference.SelectedText,
                    religion = comboBoxReligion.SelectedText;

               foreach (User friend in friendsCollections)
               {
                    FacebookObjectCollection<Event> friendfEvents = friend.Events;
                    string currentFriendAgeRange = getAgeRangeStringByAge(calculateAge(friend.Birthday));
                    string currentFriendSex = friend.Gender.Value.ToString()
                    foreach (Event friendEvent in friendfEvents)
                    {
                         
                         friendEvent.
                    }
               }

          }

          private string getAgeRangeStringByAge(int i_FriendAge)
          {
               string ageRange = string.Empty;

               if (i_FriendAge < 18)
               {

               }
               else if (i_FriendAge <= 24)
               {

               }
               else if (i_FriendAge <= 30)
               {

               }
               else if(i_FriendAge <=40)
               {

               }
               else if(i_FriendAge<=50)
               {

               }
               else 
          }

          private void showChosenEventPicture()
          {

          }

          private EventCustomedItem createEventCustomedItem(Event i_CriterionizedEvent, User i_CriterionizedFriend, string i_FriendEventAttendence)
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
               eventCustomedItem.LabelTimeFrame.Text = updateTimeFrame(currentEventStartTime)

               return eventCustomedItem;
          }

          private string updateTimeFrame(DateTime io_StartTime)
          {
               int hour = int.Parse(io_StartTime.ToString("HH"));
               string dayTime = io_StartTime.ToString("tt");
               string dayTimeFrame = string.Empty;

               if (hour < 3 && dayTime.Equals("AM"))
               {
                    dayTimeFrame = "Midnight to dawn";
               }
               else if (hour < 6 && dayTime.Equals("AM"))
               {
                    dayTimeFrame = "Early Morning";
               }
               else if (hour < 12 && dayTime.Equals("AM"))
               {
                    dayTimeFrame = "Morning";
               }
               else if (hour < 5 && dayTime.Equals("PM"))
               {
                    dayTimeFrame = "Afternoon";
               }
               else if (hour < 9 && dayTime.Equals("PM"))
               {
                    dayTimeFrame = "Evening";
               }
               else if (hour == 0 && dayTime.Equals("PM"))
               {
                    dayTimeFrame = "Midnight";
               }

               return dayTime;
          }

          private void customPictureBoxButtonFilterEvent_Click(object sender, EventArgs e)
          {

          }
     }




}
}
