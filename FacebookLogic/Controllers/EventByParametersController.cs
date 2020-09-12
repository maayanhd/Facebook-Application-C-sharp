using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Controllers
{
     public class EventByParametersController
     {
          private EventByParametersLogic m_EventByParametersLogic;

          public EventByParametersController(Form i_FormEventByParameters, EventByParametersLogic i_EventByParametersLogic)  
          {
              m_EventByParametersLogic = i_EventByParametersLogic;
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
