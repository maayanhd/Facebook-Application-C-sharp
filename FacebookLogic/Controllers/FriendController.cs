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

        public FriendController(User i_LoggedInUser, EventHandler i_FriendItemRetriviedEvent)
        {
            m_FriendsModel = new FriendsModel();
            m_FriendsModel.User = i_LoggedInUser;
            FriendItemRetrivied += i_FriendItemRetriviedEvent;
        }


        private void onFriendItemRetrivied(User i_FriendUser)
        {
            if (FriendItemRetrivied != null)
            {
                FriendItemRetrivied.Invoke(i_FriendUser, EventArgs.Empty);
            }
        }

        public void FetchUserFriends()
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
