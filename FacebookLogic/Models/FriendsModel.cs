using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
     public class FriendsModel : UserModel
     {
          public Dictionary<string, User> m_FriendsObjectNameMapper { get; private set; } = new Dictionary<string, User>();
          public FacebookObjectCollection<User> m_Friends { get; private set; }


     }
}
