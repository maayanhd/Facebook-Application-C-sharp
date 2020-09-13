using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Models
{
     public class EventByParametersModel: UserModel
     {
          public string SelectedAgeRange { get; set; } = "24 - 30";

          public Point AgeRange { get; set; } = new Point(24, 30);

          public eReligions SelectedReligion { get; set; } = eReligions.Chrisitianity;

          public eTimeFrame SelectedTimeFrame { get; set; } = eTimeFrame.Morning;

          public eGender SelectedSexPreference { get; set; } = eGender.male;

          private readonly Dictionary<int, CustomizedEventModel> m_KeyToCustomizedEventLogicMap= new Dictionary<int, CustomizedEventModel>();

          public Dictionary<int, CustomizedEventModel> KeyToCustomizedEventLogicMap
          {
               get
               {
                    return m_KeyToCustomizedEventLogicMap;
               }
          }

          public Dictionary<Point, eTimeFrame> DurationToTimeframe { get; private set; } = new Dictionary<Point, eTimeFrame>()
                              {
                                   { new Point(0, 0), eTimeFrame.Midnight },
                                   { new Point(0, 3), eTimeFrame.MidnightToDawn },
                                   { new Point(3, 6), eTimeFrame.EarlyMorning },
                                   { new Point(6, 12), eTimeFrame.Morning },
                                   { new Point(12, 16), eTimeFrame.Midday },
                                   { new Point(16, 19), eTimeFrame.Afternoon },
                                   { new Point(19, 23), eTimeFrame.Evening },
                              };

          private User LoggedInUser { get; }
        
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
         
     }
}
