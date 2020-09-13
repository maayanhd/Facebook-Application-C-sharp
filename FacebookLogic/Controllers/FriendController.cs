using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookLogic.Controllers
{
    public class FriendController
    {
        private FriendsModel FriendsData;
        private EventHandler FriendItemRetrivied;
        private EventHandler ListBoxFriendsSelectedIndexChanged;
        private EventHandler ListBoxFriendsIndexSelected;
        public Dictionary<string, User> NameToFriendUser { get; set; } = new Dictionary<string, User>();

        public FriendController(User i_LoggedInUser, EventHandler i_FriendItemRetriviedEvent, EventHandler i_SelectedIndexChanged)
        {
            FriendsData = new FriendsModel();
            FriendsData.User = i_LoggedInUser;
            FriendItemRetrivied += i_FriendItemRetriviedEvent;
            ListBoxFriendsSelectedIndexChanged += i_SelectedIndexChanged;
            ListBoxFriendsIndexSelected += i_SelectedIndexChanged;
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
            FriendsData.FriendsList.Clear();

            foreach (User friend in FriendsData.User.Friends)
            {
                onFriendItemRetrivied(friend);
                FriendsData.FriendsList.Add(friend);
                NameToFriendUser.Add(friend.Name, friend);
            }
        }

        public User GetUserByName(string selectedItemFriendName)
        {
            NameToFriendUser.TryGetValue(selectedItemFriendName, out User o_Friend);

            return o_Friend;

        }
    }
}
