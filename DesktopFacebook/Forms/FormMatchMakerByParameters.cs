using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;
using FacebookLogic.Controllers;

namespace DesktopFacebook.Forms
{
    public partial class FormMatchMakerByParameters : Form
    {
        public MatchMakerController MatchMakerController { get; private set; }

        public FormMatchMakerByParameters(User i_LoggedInUser)
        {
            InitializeComponent();
            MatchMakerController = new MatchMakerController(i_LoggedInUser, this.MatchMakerController_MatchedFriendFoundEvent, this.MatchMakerController_MatchedFriendNotFoundEvent, this.MatchMakerController_ErrorMessageEvent);
            MatchMakerController.MatchMakerData.User = i_LoggedInUser;
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
            eGender selectedGender = (eGender)Enum.Parse(typeof(eGender), (sender as RadioButton).Tag.ToString(), true);
            MatchMakerController.FindMatch();
        }

        private void comboBoxAgeRangeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatchMakerController.SetAgeRangeParameter((sender as ComboBox).SelectedItem.ToString());
        }

        private void MatchMakerController_ErrorMessageEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }

        private void MatchMakerController_MatchedFriendNotFoundEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }
    }
}
