using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
     public class CustomizedEventLogic
     {
          public DateTime? m_StartingTime { get; internal set; } = null;
          public DateTime? m_EndingTime { get; internal set; } = null;
          public string m_nameFormat { get; } = "{1} {2}";
          public string m_FriendPictureUrl { get; internal set; } = null;
          public string m_FriendName { get; internal set; } = null;
          public string m_Attendance { get; internal set; } = null;
          public string m_PlaceName { get; internal set; } = null;
          public string m_DurationTime { get; internal set; } = null;
          public string m_VenueName { get; internal set; } = null;
          public string m_TimeFrame { get; internal set; } = null;
          public string m_EventDescription { get; internal set; } = null;
          public string m_EventName { get; internal set; } = null;

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
