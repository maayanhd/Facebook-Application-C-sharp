using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FacebookLogic.Controllers
{
    public class MatchMakerController
    {
        public MatchMakerModel MatchMakerData { get; private set; }

        private Dictionary<User, int> FriendsLikesCountMapper { get; set; } = new Dictionary<User, int>();

        public event EventHandler MatchedFriendNotFoundEvent;
        public event EventHandler MatchedFriendFoundEvent;
        public event EventHandler ErrorMessageEvent;

        public MatchMakerController(User i_LoggedInUser, EventHandler i_ErrorMessageNotifier, EventHandler i_MatchedFriendFoundEvent, EventHandler i_MatchedFriendNotFoundEvent)
        {
            MatchMakerData = new MatchMakerModel();
            MatchMakerData.FilterParameters = new MatchMakerModel.Parameters();
            MatchMakerData.User = i_LoggedInUser;
            MatchMakerData.FilterParameters.AgeRange = new Point(18, 120);
            ErrorMessageEvent += i_ErrorMessageNotifier;
            MatchedFriendFoundEvent += i_MatchedFriendFoundEvent;
            MatchedFriendNotFoundEvent += i_MatchedFriendNotFoundEvent;
        }

        public void FindMatch()
        {
            foreach (User friend in MatchMakerData.User.Friends)
            {
                int friendAge = calculateAgeByBirth(friend.Birthday);
                if (friend.Gender == MatchMakerData.FilterParameters.Gender && friendAge >= MatchMakerData.FilterParameters.AgeRange.X  && friendAge <= MatchMakerData.FilterParameters.AgeRange.Y)
                {
                    FriendsLikesCountMapper.Add(friend, 0);
                }
            }

            // count likes made by filtered friends
            foreach (Post post in MatchMakerData.User.Posts)
            {
                try
                {
                    foreach (User userLiked in post.LikedBy)
                    {
                        if (FriendsLikesCountMapper.ContainsKey(userLiked))
                        {
                            FriendsLikesCountMapper[userLiked]++;
                        }
                    }
                }
                catch (Exception)
                {
                    string errorMessage = String.Format("Could not retreive your Posts Likes.{0}Please try again at a later time.", Environment.NewLine);
                    onErrorMessage(errorMessage);
                    break;
                }
            }

            // find friend with the highest likes count
            if (FriendsLikesCountMapper.Count > 0 && FriendsLikesCountMapper.Values.Max() > 0)
            {
                User maxLikesFriend = FriendsLikesCountMapper.FirstOrDefault(x => x.Value == FriendsLikesCountMapper.Values.Max()).Key;
                //presentMatchedUser(maxLikesFriend);
                onMatchedFriendFound(maxLikesFriend);
            }
            else
            {
                string message = string.Format("Sorry, no match found!");
                onMatchedFriendNotFound(message);
            }
        }

        private int calculateAgeByBirth(string i_Birthday)
        {
            DateTime birthDate = Convert.ToDateTime(i_Birthday);
            int age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
            return age;
        }

        public void SetAgeRangeParameter(string i_AgeRange)
        {
            switch (i_AgeRange)
            {
                case "18-21":
                    MatchMakerData.FilterParameters.AgeRange = new Point(18, 21);
                    break;

                case "22-25":
                    MatchMakerData.FilterParameters.AgeRange = new Point(22, 25);
                    break;

                case "26- 29":
                    MatchMakerData.FilterParameters.AgeRange = new Point(26, 29);
                    break;

                case "30-35":
                    MatchMakerData.FilterParameters.AgeRange = new Point(30, 35);
                    break;

                case "36-39":
                    MatchMakerData.FilterParameters.AgeRange = new Point(36, 39);
                    break;

                case "40-49":
                    MatchMakerData.FilterParameters.AgeRange = new Point(40, 49);
                    break;

                case "50-59":
                    MatchMakerData.FilterParameters.AgeRange = new Point(50, 59);
                    break;

                case "60+":
                    MatchMakerData.FilterParameters.AgeRange = new Point(60, 120);
                    break;

                default:
                    break;
            }
        }

        private void onMatchedFriendFound(User i_MaxLikesFriend)
        {
            if (MatchedFriendFoundEvent != null)
            {
                MatchedFriendFoundEvent.Invoke(i_MaxLikesFriend, EventArgs.Empty);
            }
        }

        private void onMatchedFriendNotFound(string i_Message)
        {
            if (MatchedFriendNotFoundEvent != null)
            {
                MatchedFriendNotFoundEvent.Invoke(i_Message, EventArgs.Empty);
            }
        }

        private void onErrorMessage(string i_ErrorMessage)
        {
            if (ErrorMessageEvent != null)
            {
                ErrorMessageEvent.Invoke(i_ErrorMessage, EventArgs.Empty);
            }
        }
    }
}
