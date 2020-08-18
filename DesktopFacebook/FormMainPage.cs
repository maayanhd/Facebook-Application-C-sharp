using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookLogic;
using DesktopFacebook.Forms;
using FacebookApp.UI;

namespace DesktopFacebook
{
     public partial class FormMainPage : Form
     {
          private Form m_CurrentChildForm = new Form();
          protected User m_LoggedInUser;
          private FormSignIn m_SignInForm;
          bool m_IsAskingToRememberLoginDets;
          readonly string logoutSuccessfulMessage = "Logging out successfully!";
          
          public FormMainPage(bool i_IsAskingToRememberLoginDets, User i_LoggedInUser, FormSignIn i_SignInForm)
          {
               m_LoggedInUser = i_LoggedInUser;
               m_SignInForm = i_SignInForm;
               InitializeComponent();
               m_IsAskingToRememberLoginDets = i_IsAskingToRememberLoginDets;
               customizePanelsDesign();
               fetchUserDetails();
               (LoginManager.Instance).LogoutSuccessful += LoginManager_LogoutSuccessful;
          }

          private void FormMainPage_DirectedToSignInForm(object sender, EventArgs e)
          {
               DirectToSignInForm((sender as FormMainPage).m_SignInForm);
          }

          public void DirectToSignInForm(FormSignIn i_SignInForm)
          {
               i_SignInForm.Visible = true;
               i_SignInForm.ShowDialog();
          }

          private void LoginManager_LogoutSuccessful(object sender, EventArgs e)
          {
               MessageBox.Show(
                    logoutSuccessfulMessage,
                    "Logout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
          }

          private void fetchUserDetails()
          {
               pictureBox_ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
               label_LoggedInUserFullName.Text = string.Format("{0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
          }

          private void customizePanelsDesign()
          {
               PanelFriends.Visible = false;
               PanelPhotos.Visible = false;
               PanelNewFeatures.Visible = false;
          }

          private void hideSubMenu()
          {
               PanelPhotos.Visible = PanelFriends.Visible = PanelNewFeatures.Visible = panelPosts.Visible = false;
          }

          private void showSubMenu(Panel o_SubMenu)
          {
               if (o_SubMenu.Visible == true)
               {
                    // Hiding buttons of a sub menu
                    hideSubMenu();
               }

               //Update visability of submenu
               o_SubMenu.Visible = !o_SubMenu.Visible;


          }

          private void fetchUserFriends()
          {
               FormFriends formFriends = m_CurrentChildForm as FormFriends;
               formFriends.listBoxFriends.Items.Clear();
               foreach (User friend in m_LoggedInUser.Friends)
               {
                    formFriends.listBoxFriends.Items.Add(friend);
               }
          }

          private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
          {
               displaySelectedFriend();
          }

          private void displaySelectedFriend()
          {
               FormFriends formFriends = m_CurrentChildForm as FormFriends;
               if (formFriends.listBoxFriends.SelectedItems.Count == 1)
               {
                    User selectedFriend = formFriends.listBoxFriends.SelectedItem as User;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                         formFriends.pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }

                    formFriends.labelFriendsName.Text = String.Format("{0} {1}", selectedFriend.FirstName, selectedFriend.LastName);
                    formFriends.labelFriendsBirthday.Text = selectedFriend.Birthday;
                    formFriends.labelFriendsGender.Text = selectedFriend.Gender.ToString();
                    formFriends.labelFriendsLocation.Text = selectedFriend.Location.ToString();
                    formFriends.labelFriendsHometown.Text = selectedFriend.Hometown.ToString();
                    formFriends.labelFriendsRelationship.Text = selectedFriend.RelationshipStatus.ToString();
                    formFriends.labelFriendsStatus.Text = selectedFriend.Statuses[0].Message;
               }
          }

          private void fetchUserAlbums()
          {
               foreach (Album album in m_LoggedInUser.Albums)
               {
                    PictureBox picBoxAlbum = new PictureBox();
                    picBoxAlbum.Name = album.Name;
                    picBoxAlbum.Size = new System.Drawing.Size(75, 75);
                    picBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picBoxAlbum.Visible = true;
                    picBoxAlbum.Tag = album;
                    picBoxAlbum.LoadAsync(album.PictureAlbumURL);
                    (m_CurrentChildForm as FormMyAlbums).flowLayoutPanelAlbums.Controls.Add(picBoxAlbum);

                    EventHandler albumClickedEventHandler = new EventHandler(this.album_Clicked);
                    picBoxAlbum.Click += albumClickedEventHandler;
               }
          }


          private void album_Clicked(object sender, EventArgs e)
          {
               PictureBox clickedAlbumBox = sender as PictureBox;
               Album selectedAlbum = clickedAlbumBox.Tag as Album;
               foreach (Photo photo in selectedAlbum.Photos)
               {
                    PictureBox picBoxPhoto = new PictureBox();
                    picBoxPhoto.Name = photo.Name;
                    picBoxPhoto.Size = new System.Drawing.Size(75, 75);
                    picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picBoxPhoto.Visible = true;
                    picBoxPhoto.Tag = photo;
                    picBoxPhoto.LoadAsync(photo.PictureNormalURL);
                    (m_CurrentChildForm as FormMyAlbums).flowLayoutPanelPhotos.Controls.Add(picBoxPhoto);

                    EventHandler photoClickedEvent = new EventHandler(this.photo_Clicked);
                    picBoxPhoto.Click += photoClickedEvent;
               }
          }

          private void photo_Clicked(object sender, EventArgs e)
          {
               PictureBox clickedPhotoBox = sender as PictureBox;
               Photo selectedPhoto = clickedPhotoBox.Tag as Photo;
               (m_CurrentChildForm as FormMyAlbums).pictureBoxSelectedPhoto.Load(selectedPhoto.PictureNormalURL);
          }

          private void fetchNewsFeed()
          {
               int postIndex = 0;
               foreach (Post post in m_LoggedInUser.NewsFeed)
               {
                    PostBox postBox = new PostBox(post);
                    (m_CurrentChildForm as FormNewsFeed).flowLayoutPanelNewsFeed.Controls.Add(postBox);
                    postIndex++;
                    if (postIndex == AppSettings.Instance.MaxPostsShown)
                    {
                         break;
                    }
               }

               if (m_LoggedInUser.Posts.Count == 0)
               {
                    MessageBox.Show("No posts to retrieve!");
               }
          }

          private void fetchPosts()
          {
               int postIndex = 0;
               foreach (Post post in m_LoggedInUser.Posts)
               {
                    PostBox postBox = new PostBox(post);
                    (m_CurrentChildForm as FormPosts).flowLayoutPanelPosts.Controls.Add(postBox);
                    postIndex++;
                    if (postIndex == AppSettings.Instance.MaxPostsShown)
                    {
                         break;
                    }
               }

               if (m_LoggedInUser.Posts.Count == 0)
               {
                    MessageBox.Show("No posts to retrieve!");
               }
          }

          private void activateTextbox(TextBox o_PostTextBox)
          {
               o_PostTextBox.Text = o_PostTextBox.Text.Equals("What\'s on your mind?") ? string.Empty : o_PostTextBox.Text;
          }
                   
          private void buttonPost_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = (sender as Button).Text;
               hideSubMenu();
               showSubMenu(panelPosts);
          }

          private void button_Photos_Click(object sender, EventArgs e)
          {
               hideSubMenu();
               showSubMenu(PanelPhotos);
               openChildForm(new Form());
          }

          private void ButtonFriends_Click(object sender, EventArgs e)
          {
               hideSubMenu();
               showSubMenu(PanelFriends);
               openChildForm(new Form());
          }


          private void FormMainPage_Load(object sender, EventArgs e)
          {

          }

          private void buttonMyFriendsList_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Friends List";
               openChildForm(new FormFriends());
               fetchUserFriends();
          }

          private void buttonMyAlbums_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Albums";
               openChildForm(new FormMyAlbums());
               fetchUserAlbums();
          }

          private void buttonNewFeatures_Click(object sender, EventArgs e)
          {
               hideSubMenu();
               showSubMenu(PanelNewFeatures);
               openChildForm(new Form());
          }

          private void buttonMatchMaker_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "MatchMaker";
               openChildForm(new FormMatchMakerByParameters(m_LoggedInUser));
          }

        private void buttonEventsByParam_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "EventByFilter";
               openChildForm(new FormEventByParameters(m_LoggedInUser));

          }


          private void buttonNewsFeed_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "News Feed";
               openChildForm(new FormNewsFeed());
               fetchNewsFeed();

          }

          private void buttonPosts_Click(object sender, EventArgs e)
          {
               hideSubMenu();
               showSubMenu(panelPosts);
               openChildForm(new Form());
          }

          private void buttonLogout_Click(object sender, EventArgs e)
          {
               AppSettings.Instance.SaveAppSettings();
               LoginManager eventLogoutHandler = LoginManager.Instance;

               eventLogoutHandler.Logout();
               this.Close();
          }

          private void m_TextBoxPost_MouseClick(object sender, MouseEventArgs e)
          {
               activateTextbox(sender as TextBox);
          }

          private void ButtonMyPosts_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Posts";
               openChildForm(new FormPosts());
               fetchPosts();
          }
     }
}
