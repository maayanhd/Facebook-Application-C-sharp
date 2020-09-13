using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Controllers
{
     public class EventByParametersController
     {
          private EventByParametersModel m_EventByParametersLogic;
          private EventByParametersModel m_FilteredEventLogic;
    
          public EventByParametersController(EventByParametersModel i_EventByParametersLogic)  
          {
              m_EventByParametersLogic = i_EventByParametersLogic;
          }

          public EventByParametersController(EventByParametersModel m_FilteredEventLogic, EventHandler EventByParametersLogic_EventsFetchedErrorOccured, EventHandler EventByParametersLogic_FriendsFetchedErrorOccured,
               EventHandler EventByParametersLogic_GenderFieldFetchedErrorOccured, EventHandler EventByParametersLogic_FilteredMatchingEventFound)
          {
               this.m_FilteredEventLogic = m_FilteredEventLogic;
               this.m_FilteredEventLogic.EventsFetchedErrorOccured += EventByParametersLogic_EventsFetchedErrorOccured;
               this.m_FilteredEventLogic.FilteredMatchingEventFound += EventByParametersLogic_FilteredMatchingEventFound;
               this.m_FilteredEventLogic.FriendsFetchedErrorOccured += EventByParametersLogic_FriendsFetchedErrorOccured;
               this.m_FilteredEventLogic.GenderFieldFetchedErrorOccured += EventByParametersLogic_GenderFieldFetchedErrorOccured;
          }

          public void HandleAgeRangeChanged(object sender)
          {
               // Find a way to update UI - data binding 
               string selectedAgeRangeStr = (sender as ComboBox).SelectedItem.ToString();
               m_EventByParametersLogic.MapAndExtractPointByStr(selectedAgeRangeStr);
          }

          public void GenerateListOfEventsByParameters()
          {
               m_EventByParametersLogic.GenerateListOfFilteredEvents();
          }

          public CustomizedEventModel HandleEventCustomedItemClickedByTag(Object tag)
          {
               m_FilteredEventLogic.KeyToCustomizedEventLogicMap.TryGetValue((int)tag, out CustomizedEventModel ClickedCustomizedEvent);

               return ClickedCustomizedEvent;
          }

          public void HandleSexPreferencePickChanged(object sender)
          {
               m_EventByParametersLogic.m_SelectedSexPreference = (eGender)Enum.Parse(typeof(eGender), (sender as ComboBox).SelectedItem.ToString());

          }

          public void HandleTimeFramePickChanged(object sender)
          {
               m_EventByParametersLogic.m_SelectedTimeFrame = (EventByParametersModel.eTimeFrame)Enum.Parse(typeof(EventByParametersModel.eTimeFrame), (sender as ComboBox).SelectedItem.ToString());

          }

          public void HandleReligionPickChanged(object sender)
          {
               m_EventByParametersLogic.m_SelectedReligion= (EventByParametersModel.eReligions)Enum.Parse(typeof(EventByParametersModel.eReligions), (sender as ComboBox).SelectedIndex.ToString());
          }
     }
}
