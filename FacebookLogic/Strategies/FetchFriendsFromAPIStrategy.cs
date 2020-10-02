using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Strategies
{
    public class FetchFriendsFromAPIStrategy : IFetchStrategy
    {
        public FriendsModel FriendsModel { get; set; }

        public void FetchData()
        {
            FriendsModel.FriendsList.Clear();
            foreach (User friend in FriendsModel.User.Friends)
            {
                FriendsModel.FriendsList.Add(friend);
            }
        }
    }
}
