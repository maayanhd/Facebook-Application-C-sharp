using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;
using FacebookLogic.Controllers;

namespace DesktopFacebook.Forms
{
    public partial class FormMatchMakerByParameters : Form
    {
        private readonly User m_LoggedInUser;

        //internal eGender SelectedGender { get; set; } = eGender.female;
        //internal Dictionary<User, int> FriendsLikesCountMapper { get; set; } = new Dictionary<User, int>();
        //private Point m_SelectedAgeRange = new Point(18, 120);
        public MatchMakerController MatchMakerController { get; private set; }

        public FormMatchMakerByParameters(User i_LoggedInUser)
        {
            InitializeComponent();
            MatchMakerController = new MatchMakerController(i_LoggedInUser, this.MatchMakerController_MatchedFriendFoundEvent, this.MatchMakerController_MatchedFriendNotFoundEvent, this.MatchMakerController_ErrorMessageEvent);
            MatchMakerController.MatchMakerData.User = i_LoggedInUser;
        }

        private void MatchMakerController_ErrorMessageEvent(object sender, EventArgs e)
        {
            
        }

        private void MatchMakerController_MatchedFriendNotFoundEvent(object sender, EventArgs e)
        {
            
        }

        private void MatchMakerController_MatchedFriendFoundEvent(object sender, EventArgs e)
        {
            User matchedFriend = sender as User;
            labelMatchResult.Visible = true;
            pictureBoxFriend.LoadAsync(matchedFriend.PictureNormalURL);
            labelFriendsName.Text = string.Format("{0} {1}", matchedFriend.FirstName, matchedFriend.LastName);
            labelFriendsBirthday.Text = matchedFriend.Birthday;
            labelFriendsGender.Text = matchedFriend.Gender.ToString();
            labelFriendsLocation.Text = matchedFriend.Location.ToString();
            labelFriendsHometown.Text = matchedFriend.Hometown.ToString();
            labelFriendsRelationship.Text = matchedFriend.RelationshipStatus.ToString();
            labelFriendsStatus.Text = matchedFriend.Statuses[0].Message;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MatchMakerController.MatchMakerData.FilterParameters.Gender = (eGender)Enum.Parse(typeof(eGender), (sender as RadioButton).Tag.ToString(), true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchMakerController.FindMatch();
            //// filter friends according to user's choice
            //foreach (User friend in m_LoggedInUser.Friends)
            //{
            //    int friendAge = calculateAgeByBirth(friend.Birthday);
            //    if (friend.Gender == SelectedGender && friendAge >= m_SelectedAgeRange.X && friendAge <= m_SelectedAgeRange.Y)
            //    {
            //        FriendsLikesCountMapper.Add(friend, 0);
            //    }
            //}

            //// count likes made by filtered friends
            //foreach (Post post in m_LoggedInUser.Posts)
            //{
            //    try
            //    {
            //        foreach (User userLiked in post.LikedBy)
            //        {
            //            if (FriendsLikesCountMapper.ContainsKey(userLiked))
            //            {
            //                FriendsLikesCountMapper[userLiked]++;
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show(
            //            string.Format(
            //                 "Could not retreive your Posts Likes.{0}Please try again at a later time.",
            //            Environment.NewLine));
            //        break;
            //    }
            //}

            //// find friend with the highest likes count
            //if (FriendsLikesCountMapper.Count > 0 && FriendsLikesCountMapper.Values.Max() > 0)
            //{
            //    User maxLikesFriend = FriendsLikesCountMapper.FirstOrDefault(x => x.Value == FriendsLikesCountMapper.Values.Max()).Key;
            //    presentMatchedUser(maxLikesFriend);
            //}
            //else
            //{
            //    labelMatchResult.Text = "Sorry, no match found!";
            //    labelMatchResult.Visible = true;
            //}
        }

        //private int calculateAgeByBirth(string i_Birthday)
        //{
        //    DateTime birthDate = Convert.ToDateTime(i_Birthday);
        //    int age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
        //    return age;
        //}

        //private void presentMatchedUser(User i_MaxLikesFriend)
        //{

        //}

        private void comboBoxAgeRangeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatchMakerController.SetAgeRangeParameter((sender as ComboBox).SelectedItem.ToString());
        }
    }
}
