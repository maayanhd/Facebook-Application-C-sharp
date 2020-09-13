using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;

namespace DesktopFacebook
{
     public partial class EventCustomedItem : UserControl
     {
          public EventCustomedItem()
          {
               InitializeComponent();
               // 
               // customizedEventLogicBindingSource
               // 
               this.customizedEventModelBindingSource.DataSource = typeof(FacebookLogic.CustomizedEventModel);
          }
          public EventCustomedItem(CustomizedEventModel i_CustomizedEventLogic)
          {
               InitializeComponent();
               labelFriendName.Text = i_CustomizedEventLogic.m_FriendName;
               pictureBoxFriendProfile.LoadAsync(i_CustomizedEventLogic.m_FriendPictureUrl); 
               labelAttendance.Text = i_CustomizedEventLogic.m_Attendance;
               labelVenueName.Text = i_CustomizedEventLogic.m_VenueName;
               labelPlaceName.Text = i_CustomizedEventLogic.m_PlaceName;
               labelTimeFrame.Text = i_CustomizedEventLogic.m_TimeFrame;
               labelDurationTime.Text = i_CustomizedEventLogic.m_DurationTime;
               Tag = i_CustomizedEventLogic.m_Key;
               // 
               // customizedEventLogicBindingSource
               // 
               this.customizedEventModelBindingSource.DataSource = typeof(FacebookLogic.CustomizedEventModel);
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
