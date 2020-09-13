using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Models
{
     public class CustomizedEventModel
     {
          public DateTime? StartingTime { get; internal set; } = null;
          public DateTime? EndingTime { get; internal set; } = null;
          public string nameFormat { get; } = "{1} {2}";
          public string FriendPictureUrl { get; internal set; } = null;
          public string FriendName { get; internal set; } = null;
          public string Attendance { get; internal set; } = null;
          public string PlaceName { get; internal set; } = null;
          public string DurationTime { get; internal set; } = null;
          public string VenueName { get; internal set; } = null;
          public string TimeFrame { get; internal set; } = null;
          public string EventDescription { get; internal set; } = null;
          public string EventName { get; internal set; } = null;
          public int Key { get; }

          private static int m_Counter = 0;

          internal CustomizedEventModel()
          {
               Key = m_Counter++;
          }

          public event EventHandler EventDescriptionFetchingErrorOccured;
          public event EventHandler EventLocationFetchingErrorOccured;
          public event EventHandler EventTimeRelatedDetailsErrorOccured;
          public event EventHandler EventFriendsDetailErrorOccured;
       
          #region "On" methods for eventHandlers
          internal void OnEventDescriptionFetchingErrorOccured(EventArgs e)
          {
               EventHandler handler = EventDescriptionFetchingErrorOccured;

               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void OnEventLocationFetchingErrorOccured(EventArgs e)
          {
               EventHandler handler = EventLocationFetchingErrorOccured;

               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void OnEventTimeRelatedDetailsErrorOccured(EventArgs e)
          {
               EventHandler handler = EventTimeRelatedDetailsErrorOccured;

               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          internal void OnEventFriendsDetailErrorOccured(EventArgs e)
          {
               EventHandler handler = EventFriendsDetailErrorOccured;

               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }
          #endregion
     }
}
