using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControls
{
     public partial class EventCustomedItem : UserControl
     {
          public EventCustomedItem()
          {
               InitializeComponent();
          }

          #region
          public Label LabelTimeFrame
          {
               get
               {
                    return labelTimeFrame;
               }
          }

          public Label LabelDescriptionContent
          {
               get
               {
                    return LabelDescriptionContent;
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

          public Label LabelAttendence
          {
               get
               {
                    return labelAttendence;
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

