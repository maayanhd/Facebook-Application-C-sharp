using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;
using FacebookLogic.Models;

namespace DesktopFacebook
{
     public partial class EventCustomedItem : UserControl
     {
          public EventCustomedItem()
          {
               InitializeComponent();
          }

          public EventCustomedItem(CustomizedEventModel i_CustomizedEventLogic)
          {
               InitializeComponent();
               labelFriendName.Text = i_CustomizedEventLogic.FriendName;
               pictureBoxFriendProfile.LoadAsync(i_CustomizedEventLogic.FriendPictureUrl); 
               labelAttendance.Text = i_CustomizedEventLogic.Attendance;
               labelVenueName.Text = i_CustomizedEventLogic.VenueName;
               labelPlaceName.Text = i_CustomizedEventLogic.PlaceName;
               labelTimeFrame.Text = i_CustomizedEventLogic.TimeFrame;
               labelDurationTime.Text = i_CustomizedEventLogic.DurationTime;
               Tag = i_CustomizedEventLogic.Key;
          }
          #region
          public Label LabelTimeFrame
          {
               get
               {
                    return labelTimeFrame;
               }
          }

          public Label LabelDurationTime
          {
               get
               {
                    return labelDurationTime;
               }
          }

          public Label LabelFriendName
          {
               get
               {
                    return labelFriendName;
               }
          }
          
          public Label LabelVenue
          {
               get
               {
                    return labelVenue;
               }
          }

          public Label LabelPlace
          {
               set
               {
                    labelLocation = value;
               }
          }

          public PictureBox PictureBoxFriendProfile
          {
               get
               {
                    return pictureBoxFriendProfile;
               }
          }

          public PictureBox PictureBoxEvent
          {
               get
               {
                    return PictureBoxEvent;
               }
          }

          public Label LabelAttendance
          {
               get
               {
                    return labelAttendance;
               }
          }

          public Label LabelVenueName
          {
               get
               {
                    return labelVenueName;
               }
          }
          
          public Label LabelPlaceName
          {
               get
               {
                    return labelPlaceName;
               }
          }

          #endregion
     }
}
