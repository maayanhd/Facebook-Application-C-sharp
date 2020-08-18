using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace DesktopFacebook.Forms
{
    public partial class FormMatchMakerByParameters : Form
    {
        private readonly User m_LoggedInUser;
        internal eGender SelectedGender { get; set; } = eGender.female;
        internal Dictionary<User, int> FriendsLikesCountMapper { get; set; } = new Dictionary<User, int>();
        //private Point SelectedAgeRange { get; set; } = new Point();
        private Point m_SelectedAgeRange = new Point(18, 120);

        public FormMatchMakerByParameters(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelectedGender = (eGender)Enum.Parse(typeof(eGender), (sender as RadioButton).Tag.ToString(), true);
            //labelTester.Text = SelectedGender.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // filter friends according to user's choice
            foreach (User friend in m_LoggedInUser.Friends)
            {
                int friendAge = calculateAgeByBirth(friend.Birthday);
                if (friend.Gender == SelectedGender && friendAge >= m_SelectedAgeRange.X && friendAge <= m_SelectedAgeRange.Y)
                {
                    FriendsLikesCountMapper.Add(friend, 0);
                }
            }

            // count likes made by filtered friends
            foreach (Post post in m_LoggedInUser.Posts)
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
                catch(Exception)
                {
                    MessageBox.Show(
                        string.Format("Could not retreive your Posts Likes.{0}Please try again at a later time.", Environment.NewLine)
                        );
                    break;
                }
            }

            // find friend with the highest likes count
            if (FriendsLikesCountMapper.Count > 0 && FriendsLikesCountMapper.Values.Max() > 0)
            {
                User maxLikesFriend = FriendsLikesCountMapper.FirstOrDefault(x => x.Value == FriendsLikesCountMapper.Values.Max()).Key;
                presentMatchedUser(maxLikesFriend);
            }
            else
            {
                labelMatchResult.Text = "Sorry, no match found!";
                labelMatchResult.Visible = true;
            }  
        }

        private int calculateAgeByBirth(string birthday)
        {
            DateTime birthDate = Convert.ToDateTime(birthday);
            int age = new DateTime(DateTime.Now.Subtract(birthDate).Ticks).Year - 1;
            return age;
        }

        private void presentMatchedUser(User i_MaxLikesFriend)
        {
            labelMatchResult.Visible = true;
            pictureBoxFriend.LoadAsync(i_MaxLikesFriend.PictureNormalURL);
            labelFriendsName.Text = String.Format("{0} {1}", i_MaxLikesFriend.FirstName, i_MaxLikesFriend.LastName);
            labelFriendsBirthday.Text = i_MaxLikesFriend.Birthday;
            labelFriendsGender.Text = i_MaxLikesFriend.Gender.ToString();
            labelFriendsLocation.Text = i_MaxLikesFriend.Location.ToString();
            labelFriendsHometown.Text = i_MaxLikesFriend.Hometown.ToString();
            labelFriendsRelationship.Text = i_MaxLikesFriend.RelationshipStatus.ToString();
            labelFriendsStatus.Text = i_MaxLikesFriend.Statuses[0].Message;
        }

        private void comboBoxAgeRangeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((sender as ComboBox).SelectedItem.ToString())
            {
                case "18-21":
                    m_SelectedAgeRange.X = 18;
                    m_SelectedAgeRange.Y = 21;
                    break;

                case "22-25":
                    m_SelectedAgeRange.X = 22;
                    m_SelectedAgeRange.Y = 25;
                    break;

                case "26- 29":
                    m_SelectedAgeRange.X = 26;
                    m_SelectedAgeRange.Y = 29;
                    break;

                case "30-35":
                    m_SelectedAgeRange.X = 30;
                    m_SelectedAgeRange.Y = 35;
                    break;

                case "36-39":
                    m_SelectedAgeRange.X = 36;
                    m_SelectedAgeRange.Y = 39;
                    break;

                case "40-49":
                    m_SelectedAgeRange.X = 40;
                    m_SelectedAgeRange.Y = 49;
                    break;

                case "50-59":
                    m_SelectedAgeRange.X = 50;
                    m_SelectedAgeRange.Y = 59;
                    break;

                case "60+":
                    m_SelectedAgeRange.X = 60;
                    m_SelectedAgeRange.Y = 120;
                    break;

                default:
                    break;
            }
        }
    }
}
