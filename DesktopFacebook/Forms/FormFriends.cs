using System;
using System.Windows.Forms;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebook.Forms
{
     public partial class FormFriends : Form, IOpenable, ICloseable
     {
          public ApplicationController ApplicationController { get; private set; }

          public Closer Closer { get; } = new Closer();
          
          public Opener Opener { get; } = new Opener();

          public FormFriends(User i_LoggedInUser)
          public FormFriends(ApplicationController i_AppController)
          {
               ApplicationController = i_AppController;
               ApplicationController.InitializeFriendsService(this.FormFriends_FriendItemRetrivied, this.listBoxFriends_SelectedIndexChanged);
               InitializeComponent();
               ApplicationController.FriendsController.FetchUserFriends();
               defineListBoxBehaviour();
          }

          private void defineListBoxBehaviour()
          {
               this.listBoxFriends.DisplayMember = "Name";
            ApplicationController.FriendsController.bindFriendsourceBinding(friendsModelBindingSource);
          }

          private void FormFriends_FriendItemRetrivied(object sender, EventArgs e)
          {
               this.listBoxFriends.Items.Add(sender as User);
          }

          private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (isThereASelectetdFriendItem())
               {
                    User selectedFriend = ApplicationController.FriendsController.GetUserByName((listBoxFriends.SelectedItem as User).Name);
                    displayFriendPicture(selectedFriend);
                ApplicationController.FriendsController.updateCurrentUser(selectedFriend);
                    displaySelectedFriend(ApplicationController.FriendsController.GetUserByName((listBoxFriends.SelectedItem as User).Name));
               }
          }

          private void displayFriendPicture(User i_SelectedFriend)
          {
               if (i_SelectedFriend.PictureNormalURL != null)
               {
                    this.pictureBoxFriend.LoadAsync(i_SelectedFriend.PictureNormalURL);
               }
          }

          private void displaySelectedFriend(User i_SelectedFriend)
          {    // Manual UI update 
               this.labelFriendsNameData.Text = string.Format("{0} {1}", i_SelectedFriend.FirstName, i_SelectedFriend.LastName);
               this.labelFriendsBirthdayData.Text = i_SelectedFriend.Birthday != null ? i_SelectedFriend.Birthday.ToString() : "N/A";
               this.labelFriendsGenderData.Text = i_SelectedFriend.Gender != null ? i_SelectedFriend.Gender.ToString() : "N/A";
               this.labelFriendsLocationData.Text = i_SelectedFriend.Location != null ? i_SelectedFriend.Location.Name : "N/A";
               this.labelFriendsHometownData.Text = i_SelectedFriend.Hometown != null ? i_SelectedFriend.Hometown.ToString() : "N/A";
               this.labelFriendsRelationshipData.Text = i_SelectedFriend.RelationshipStatus != null ? i_SelectedFriend.RelationshipStatus.ToString() : "N/A";
               this.labelFriendsStatusData.Text = i_SelectedFriend.Statuses[0].Message != null ? i_SelectedFriend.Statuses[0].Message : "N/A";
          }

          private bool isThereASelectetdFriendItem()
          {
               return this.listBoxFriends.SelectedItems.Count == 1;
          }
     }
}
