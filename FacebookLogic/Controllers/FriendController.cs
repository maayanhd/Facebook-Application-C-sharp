using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Controllers
{
     public class FriendController
     {
          private FriendsModel m_FriendsModel;
          public event EventHandler FriendItemRetrivied;

          public FriendController(FriendsModel i_FriendsModel)
          {
               m_FriendsModel = i_FriendsModel;
          }

         
          private void onFriendItemRetrivied(User i_FriendUser)
          {
               if(FriendItemRetrivied != null)
               {
                    FriendItemRetrivied.Invoke(i_FriendUser, EventArgs.Empty);
               }
          }

          public void fetchUserFriends()
          {
               //EventHandler friendSelectionChangedEventHandler = new EventHandler(this.listBoxFriends_SelectedIndexChanged);
               //formFriends.listBoxFriends.SelectedIndexChanged += friendSelectionChangedEventHandler;

               m_FriendsModel.m_FriendsList.Clear();

               foreach (User friend in m_FriendsModel.User.Friends)
               {
                    onFriendItemRetrivied(friend);
                    //listBoxFriends.Items.Clear();
                    //m_FriendsObjectNameMapper.Clear();
                    //listBoxFriends.
                    //string friendsNameFormatted = string.Format("{0} {1}", friend.FirstName, friend.LastName);
                    //m_FriendsObjectNameMapper.Add(friendsNameFormatted, friend);
                    m_FriendsModel.m_FriendsList.Add(friend);
               }
          }
     }
}
