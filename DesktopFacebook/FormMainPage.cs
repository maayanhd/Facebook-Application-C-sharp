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

namespace DesktopFacebook
{
     public partial class FormMainPage : Form
     {
          private Form m_CurrentChildForm = new Form();
          private User m_LoggedInUser;
          bool m_IsAskingToRememberLoginDets;
               
          public FormMainPage(bool i_IsAskingToRememberLoginDets, User i_LoggedInUser)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               m_IsAskingToRememberLoginDets = i_IsAskingToRememberLoginDets;
               customizePanelsDesign();
               fetchUserDetails();
          }

        private void fetchUserDetails()
        {
            pictureBox_ProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            label_LoggedInUserFullName.Text = string.Format("{0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
        }

        private void customizePanelsDesign()
          {
               m_PanelFriends.Visible = false;
               m_PanelPhotos.Visible = false;
               m_PanelNewFeatures.Visible = false;
          }

          private void hideSubMenu()
          {
               m_PanelFriends.Visible = m_PanelPhotos.Visible = m_PanelNewFeatures.Visible= false;
          }

          private void showSubMenu(Panel o_SubMenu)
          {
               if(o_SubMenu.Visible == true)
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
                    (m_CurrentChildForm as FormPhotos).flowLayoutPanelAlbums.Controls.Add(picBoxAlbum);

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
                    (m_CurrentChildForm as FormPhotos).flowLayoutPanelPhotos.Controls.Add(picBoxPhoto);

                    EventHandler photoClickedEvent = new EventHandler(this.photo_Clicked);
                    picBoxPhoto.Click += photoClickedEvent;
                }
          }

          private void photo_Clicked(object sender, EventArgs e)
          {
                PictureBox clickedPhotoBox = sender as PictureBox;
                Photo selectedPhoto = clickedPhotoBox.Tag as Photo;
                (m_CurrentChildForm as FormPhotos).pictureBoxSelectedPhoto.Load(selectedPhoto.PictureNormalURL);
          }



          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void m_ButtonPost_Click(object sender, EventArgs e)
          {
               
          }
                              
          private void m_Button_Photos_Click(object sender, EventArgs e)
          {
               openChildForm(new FormPhotos());
               fetchUserAlbums();
          }

          private void m_ButtonFriends_Click(object sender, EventArgs e)
          {
               openChildForm(new FormFriends());
               fetchUserFriends();
          }

          private void button5_Click(object sender, EventArgs e)
          {

          }
     }
}
