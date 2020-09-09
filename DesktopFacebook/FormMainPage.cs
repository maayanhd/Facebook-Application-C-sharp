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
          private readonly string logoutSuccessfulMessage = "Logged out successfully!";

          private Form m_CurrentChildForm = new Form();
          protected User m_LoggedInUser;

          private Dictionary<string, User> m_FriendsObjectNameMapper { get; set; } = new Dictionary<string, User>();

          private bool m_IsAskingToRememberLoginDets;

          public FormMainPage(bool i_IsAskingToRememberLoginDets, User i_LoggedInUser, FormSignIn i_SignInForm)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               m_IsAskingToRememberLoginDets = i_IsAskingToRememberLoginDets;
               customizePanelsDesign();
               fetchUserDetails();
               LoginManager.Instance.LogoutSuccessful += LoginManager_LogoutSuccessful;
          }

          private void LoginManager_LogoutSuccessful(object sender, EventArgs e)
          {
               MessageBox.Show(
                    logoutSuccessfulMessage,
                    "Logout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
               Environment.Exit(0);
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

               // Update visability of submenu
               o_SubMenu.Visible = !o_SubMenu.Visible;
          }

          private void fetchUserFriends()
          {
               FormFriends formFriends = m_CurrentChildForm as FormFriends;
               formFriends.listBoxFriends.Items.Clear();
               m_FriendsObjectNameMapper.Clear();

               EventHandler friendSelectionChangedEventHandler = new EventHandler(this.listBoxFriends_SelectedIndexChanged);
               formFriends.listBoxFriends.SelectedIndexChanged += friendSelectionChangedEventHandler;

               foreach (User friend in m_LoggedInUser.Friends)
               {
                    string friendsNameFormatted = string.Format("{0} {1}", friend.FirstName, friend.LastName);
                    formFriends.listBoxFriends.Items.Add(friendsNameFormatted);
                    m_FriendsObjectNameMapper.Add(friendsNameFormatted, friend);
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
                    User selectedFriend = m_FriendsObjectNameMapper[formFriends.listBoxFriends.SelectedItem.ToString()];
                    if (selectedFriend.PictureNormalURL != null)
                    {
                         formFriends.pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }

                    formFriends.labelFriendsNameData.Text = string.Format("{0} {1}", selectedFriend.FirstName, selectedFriend.LastName);
                    formFriends.labelFriendsBirthdayData.Text = selectedFriend.Birthday != null ? selectedFriend.Birthday.ToString() : "N/A";
                    formFriends.labelFriendsGenderData.Text = selectedFriend.Gender != null ? selectedFriend.Gender.ToString() : "N/A";
                    formFriends.labelFriendsLocationData.Text = selectedFriend.Location != null ? selectedFriend.Location.ToString() : "N/A";
                    formFriends.labelFriendsHometownData.Text = selectedFriend.Hometown != null ? selectedFriend.Hometown.ToString() : "N/A";
                    formFriends.labelFriendsRelationshipData.Text = selectedFriend.RelationshipStatus != null ? selectedFriend.RelationshipStatus.ToString() : "N/A";
                    formFriends.labelFriendsStatusData.Text = selectedFriend.Statuses[0].Message != null ? selectedFriend.Statuses[0].Message : "N/A";
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
               try
               {
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
               catch (Exception)
               {
                    MessageBox.Show("Unable to fetch album photos", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
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
               if (!string.IsNullOrEmpty(this.textboxWritePost.Text))
               {
                    try
                    {
                         m_LoggedInUser.PostStatus(this.textboxWritePost.Text);
                    }
                    catch (Exception)
                    {
                         MessageBox.Show(
                             string.Format(
                                  "Unable to publish new post.{0}Please try again at a later time.",
                                        Environment.NewLine));
                    }
               }
          }

          private void button_Photos_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Photos";
               hideSubMenu();
               showSubMenu(PanelPhotos);
               openChildForm(new Form());
          }

          private void ButtonFriends_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Friends";
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
               ButtonChosenMenu.Text = "Special Feature";
               hideSubMenu();
               showSubMenu(PanelNewFeatures);
               openChildForm(new Form());
          }

          private void buttonMatchMaker_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Match Maker";
               openChildForm(new FormMatchMakerByParameters(m_LoggedInUser));
          }

          private void buttonEventsByParam_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Events Finder";
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
               ButtonChosenMenu.Text = "News Feed";
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

          private void textboxWritePost_TextChanged(object sender, EventArgs e)
          {
          }

          private void PanelSelectedMenu_Paint(object sender, PaintEventArgs e)
          {

          }
     }
}
