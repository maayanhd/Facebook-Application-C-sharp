using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
     class FriendsLogic
     {
          protected User m_LoggedInUser;
          private Dictionary<string, User> m_FriendsObjectNameMapper { get; set; } = new Dictionary<string, User>();


     }
}
