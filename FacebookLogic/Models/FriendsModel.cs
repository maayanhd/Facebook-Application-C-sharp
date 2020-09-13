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
          private User i_LoggedInUser;

          public FriendsModel(User i_LoggedInUser): base(i_LoggedInUser)
          {
          }

          public List<User> m_FriendsList { get; private set; } = new List<User>();

     }
}
