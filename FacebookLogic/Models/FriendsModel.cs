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
          public List<User> m_FriendsList { get; private set; } = new List<User>();
     }
}
