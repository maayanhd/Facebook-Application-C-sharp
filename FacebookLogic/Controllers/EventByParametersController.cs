using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Controllers
{
    public class EventByParametersController
    {
        public EventByParametersModel EventsData { get; set; }

        public EventByParametersController(User i_LoggedInUser, EventHandler EventByParametersLogic_EventsFetchedErrorOccured, EventHandler EventByParametersLogic_FriendsFetchedErrorOccured,
             EventHandler EventByParametersLogic_GenderFieldFetchedErrorOccured, EventHandler EventByParametersLogic_FilteredMatchingEventFound)
        {
            EventsData = new EventByParametersModel();
            EventsData.User = i_LoggedInUser;
            this.EventsData = EventsData;
            this.EventsData.EventsFetchedErrorOccured += EventByParametersLogic_EventsFetchedErrorOccured;
            this.EventsData.FilteredMatchingEventFound += EventByParametersLogic_FilteredMatchingEventFound;
            this.EventsData.FriendsFetchedErrorOccured += EventByParametersLogic_FriendsFetchedErrorOccured;
            this.EventsData.GenderFieldFetchedErrorOccured += EventByParametersLogic_GenderFieldFetchedErrorOccured;
        }

        public void HandleAgeRangeChanged(object sender)
        {
            // Find a way to update UI - data binding 
            string selectedAgeRangeStr = (sender as ComboBox).SelectedItem.ToString();
            EventsData.MapAndExtractPointByStr(selectedAgeRangeStr);
        }

        public void GenerateListOfEventsByParameters()
        {
            EventsData.GenerateListOfFilteredEvents();
        }

        public CustomizedEventModel HandleEventCustomedItemClickedByTag(Object tag)
        {
            EventsData.KeyToCustomizedEventLogicMap.TryGetValue((int)tag, out CustomizedEventModel ClickedCustomizedEvent);

            return ClickedCustomizedEvent;
        }

        public void HandleSexPreferencePickChanged(object sender)
        {
            EventsData.m_SelectedSexPreference = (eGender)Enum.Parse(typeof(eGender), (sender as ComboBox).SelectedItem.ToString());

        }

        public void HandleTimeFramePickChanged(object sender)
        {
            EventsData.m_SelectedTimeFrame = (EventByParametersModel.eTimeFrame)Enum.Parse(typeof(EventByParametersModel.eTimeFrame), (sender as ComboBox).SelectedItem.ToString());

        }

        public void HandleReligionPickChanged(object sender)
        {
            EventsData.m_SelectedReligion = (EventByParametersModel.eReligions)Enum.Parse(typeof(EventByParametersModel.eReligions), (sender as ComboBox).SelectedIndex.ToString());
        }
    }
}
