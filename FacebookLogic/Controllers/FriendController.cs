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

          public void bindFriendsourceBinding(BindingSource friendsModelBindingSource)
          {
               friendsModelBindingSource.DataSource = FriendsData;
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

          public void updateCurrentUser(User i_User)
          {
               FriendsData.FirstName = i_User.FirstName != null ? i_User.FirstName : string.Empty;
               FriendsData.LastName = i_User.LastName != null ? i_User.LastName : string.Empty;
               FriendsData.Location = i_User.Location;
               FriendsData.LocationStr = FriendsData.Location != null ? FriendsData.Location.Name : null;
               FriendsData.Birthday = i_User.Birthday;
               FriendsData.Gender = i_User.Gender;
               FriendsData.GenderStr = FriendsData.Gender != null ? FriendsData.Gender.ToString() : null;
               FriendsData.Hometown = i_User.Hometown;
               FriendsData.HometownStr = FriendsData.Hometown != null ? FriendsData.Hometown.ToString() : null;
               FriendsData.RelationshipStatus = i_User.RelationshipStatus;
               FriendsData.RelationshipStatusStr = FriendsData.RelationshipStatus != null ? FriendsData.RelationshipStatus.ToString() : null;
               FriendsData.Status = i_User.Statuses != null ? i_User.Statuses[0].Message : null;
               FriendsData.FullName = !(FriendsData.FirstName == null && FriendsData.LastName == null) ?
                    String.Format(FriendsData.NameFormat, i_User.FirstName, i_User.LastName) : null;
          }

          public User GetUserByName(string selectedItemFriendName)
          {
            NameToFriendUser.TryGetValue(selectedItemFriendName, out User o_Friend);

            return o_Friend;
          }
    }
}
