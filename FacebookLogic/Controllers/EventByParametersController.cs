using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Controllers
{
     public class EventByParametersController
     {
          private Form m_FormEventByParameters;
          private EventByParametersLogic m_EventByParametersLogic;

          public EventByParametersController(Form i_FormEventByParameters, EventByParametersLogic i_EventByParametersLogic)  
          {
               m_FormEventByParameters = i_FormEventByParameters;
               m_EventByParametersLogic = i_EventByParametersLogic;
               m_EventByParametersLogic.FilteredMatchingEventFound += EventByParametersLogic_FilteredMatchingEventFound;
          }

          private void EventByParametersLogic_FilteredMatchingEventFound(object sender, EventArgs e)
          {
               // Find a way to update UI - creating customized event logic item in sender and  
               
               //FlowLayoutPanelCutomedEvents.Controls.Add(createEventCustomedItem(friendEvent, friend, currentEventTimeFrame, friendAttendance));

          }

          public void HandleAgeRangeChanged(object sender)
          {
               // Find a way to update UI - data binding 
               string selectedAgeRangeStr = (sender as ComboBox).SelectedItem.ToString();
               m_EventByParametersLogic.MapAndExtractPointByStr(selectedAgeRangeStr);
          }

          //private EventCustomedItem createCustomizedEventItem(Event i_CriterionizedEvent, User i_CriterionizedFriend, eTimeFrame i_CurrentEventTimeFrame, string i_FriendEventAttendance)
          //{
          //     EventCustomedItem eventCustomedItem = new EventCustomedItem();
          //     const string Format = "{1} {2}";

          //     eventCustomedItem.PictureBoxFriendProfile.LoadAsync(i_CriterionizedFriend.PictureNormalURL);
          //     eventCustomedItem.LabelFriendName.Text = string.Format(Format, i_CriterionizedFriend.FirstName, i_CriterionizedFriend.LastName);
          //     eventCustomedItem.LabelAttendance.Text = i_FriendEventAttendance;

          //     eventCustomedItem.LabelPlaceName.Text = i_CriterionizedEvent.Place.ToString();
          //     DateTime currentEventStartTime = i_CriterionizedEvent.StartTime.Value,
          //              currentEventEndTime = i_CriterionizedEvent.EndTime.Value;

          //     eventCustomedItem.LabelDurationTime.Text = string.Format(
          //          "{0} at {1} - {2} at {3}",
          //          currentEventStartTime.ToString("dd/MM"),
          //          currentEventStartTime.ToString("hh:mm tt"),
          //          currentEventEndTime.ToString("hh:mm tt"),
          //          currentEventEndTime.ToString("dd/MM"));
          //     eventCustomedItem.LabelVenueName.Text = i_CriterionizedEvent.Venue.ToString();
          //     eventCustomedItem.LabelTimeFrame.Text = i_CurrentEventTimeFrame.ToString();
          //     labelEventDescription.Visible = true;
          //     // Make it by 2-way data binding
          //     labelDescriptionContent.Visible = true;
          //     labelDescriptionContent.Text = i_CriterionizedEvent.Description;

          //     return eventCustomedItem;
          //}


          public void GenerateListOfEventsByParameters()
          {
               m_EventByParametersLogic.GenerateListOfFilteredEvents();
          }

          public void HandleSexPreferencePickChanged(object sender)
          {
               // fix with data binding
               m_EventByParametersLogic.m_SelectedSexPreference = (eGender)Enum.Parse(typeof(eGender), (sender as ComboBox).SelectedItem.ToString());

          }

          public void HandleTimeFramePickChanged(object sender)
          {
               // fix with data binding
               m_EventByParametersLogic.m_SelectedTimeFrame = (EventByParametersLogic.eTimeFrame)Enum.Parse(typeof(EventByParametersLogic.eTimeFrame), (sender as ComboBox).SelectedItem.ToString());

          }

          public void HandleReligionPickChanged(object sender)
          {
               // fix with data binding
               m_EventByParametersLogic.m_SelectedReligion= (EventByParametersLogic.eReligions)Enum.Parse(typeof(EventByParametersLogic.eReligions), (sender as ComboBox).SelectedIndex.ToString());
          }
     }
}
