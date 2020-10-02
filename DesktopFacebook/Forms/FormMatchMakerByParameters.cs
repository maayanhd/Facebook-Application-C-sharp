using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookLogic.Controllers;
using static FacebookWrapper.ObjectModel.User;

namespace DesktopFacebook.Forms
{
     public partial class FormMatchMakerByParameters : Form, IOpenable, ICloseable
     {
          private ApplicationController ApplicationController { get; set; }

          public Closer Closer { get; } = new Closer();
          
          public Opener Opener { get; } = new Opener();

          public FormMatchMakerByParameters(ApplicationController i_AppController)
          {
               InitializeComponent();
               ApplicationController = i_AppController;
               ApplicationController.InitializeMatchMakerService(this.MatchMakerController_MatchedFriendFoundEvent, this.MatchMakerController_MatchedFriendNotFoundEvent, this.MatchMakerController_ErrorMessageEvent);
               Opener.Open(this as IOpenable);
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
               ApplicationController.MatchMakerService.MatchMakerData.FilterParameters.Gender = (eGender)Enum.Parse(typeof(eGender), (sender as RadioButton).Tag.ToString(), true);
          }

          private void button1_Click(object sender, EventArgs e)
          {
               ApplicationController.MatchMakerService.FindMatch();
          }

          private void comboBoxAgeRangeSelection_SelectedIndexChanged(object sender, EventArgs e)
          {
               ApplicationController.MatchMakerService.SetAgeRangeParameter((sender as ComboBox).SelectedItem.ToString());
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
