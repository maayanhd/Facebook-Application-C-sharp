using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace DesktopFacebook.Forms
{
     public partial class FormEventByParameters : Form
     {
          private EventByParametersModel m_FilteredEventLogic;
          private EventByParametersController m_FilteredEventController;

          public FlowLayoutPanel flowLayoutPanelCutomedEvents { get; private set; }

          public FlowLayoutPanel FlowLayoutPanelCutomedEvents
          {
               get
               {
                    return flowLayoutPanelCutomedEvents;
               }
          }

          public FormEventByParameters(User i_LoggedInUser)
          {
               InitializeComponent();
               this.FormBorderStyle = FormBorderStyle.FixedDialog;
               m_FilteredEventLogic = new EventByParametersModel(i_LoggedInUser);
               m_FilteredEventController = new EventByParametersController(this, m_FilteredEventLogic);
               m_FilteredEventLogic.EventsFetchedErrorOccured += EventByParametersLogic_EventsFetchedErrorOccured;
               m_FilteredEventLogic.FriendsFetchedErrorOccured += EventByParametersLogic_FriendsFetchedErrorOccured;
               m_FilteredEventLogic.GenderFieldFetchedErrorOccured += EventByParametersLogic_GenderFieldFetchedErrorOccured;
               m_FilteredEventLogic.FilteredMatchingEventFound += EventByParametersLogic_FilteredMatchingEventFound;
          }

          private void EventByParametersLogic_FilteredMatchingEventFound(object sender, EventArgs e)
          {
               FlowLayoutPanelCutomedEvents.Controls.Add(new EventCustomedItem(sender as CustomizedEventModel));
          }

          private void EventByParametersLogic_GenderFieldFetchedErrorOccured(object sender, EventArgs e)
          {
               notifyGenderFetchingErrorOccured();
          }

          private void notifyGenderFetchingErrorOccured()
          {
               MessageBox.Show("Please choose a sex preference first",
                           "Sex Preference missing",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.None);
          }

          private void EventByParametersLogic_FriendsFetchedErrorOccured(object sender, EventArgs e)
          {
               notifyFriendsFetchingErrorOccured();
          }

          private void notifyFriendsFetchingErrorOccured()
          {
               MessageBox.Show(
                        "We're Sorry, No friends were found",
                                "Event Filter Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None);
          }

          private void EventByParametersLogic_EventsFetchedErrorOccured(object sender, EventArgs e)
          {
               notifyEventsFetchingErrorOccured();
          }

          private void notifyEventsFetchingErrorOccured()
          {
               MessageBox.Show(
                    "We're Sorry, no matching events were found ",
                        "Event Filter Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);               
          }

          private void comboBoxAgeRange_SelectedIndexChanged(object sender, EventArgs e)
          {
               m_FilteredEventController.HandleAgeRangeChanged(sender);
          }
     
          // Generating the items of event by the given parameters of the users
          private void customPictureBoxButtonFilterEvent_Click(object sender, EventArgs e)
          {
               m_FilteredEventController.GenerateListOfEventsByParameters();
          }

          private void comboBoxTimeFrame_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    m_FilteredEventController.HandleTimeFramePickChanged(sender);
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(EventByParametersModel.eTimeFrame)));
               }
          }

          private void comboBoxReligion_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    m_FilteredEventController.HandleReligionPickChanged(sender);
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(EventByParametersModel.eReligions)));
               }
          }

          private void comboBoxSexPreference_SelectedIndexChanged(object sender, EventArgs e)
          {
               try
               {
                    m_FilteredEventController.HandleSexPreferencePickChanged(sender);
               }
               catch (Exception)
               {
                    throw new Exception(string.Format("Error: parsing to {0} failed", typeof(eGender)));
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
