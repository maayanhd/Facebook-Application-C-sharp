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

namespace DesktopFacebook
{
     public partial class FormMainPage : Form
     {
          private User m_LoggedInUser;
          bool m_IsAskingToRememberLoginDets;
               
          public FormMainPage(bool i_IsAskingToRememberLoginDets)
          {
               InitializeComponent();
               m_IsAskingToRememberLoginDets = i_IsAskingToRememberLoginDets;
               customizePanelsDesign();
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
                listBoxFriends.Items.Clear();
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                }
          }

          private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
          {
                displaySelectedFriend();
          }

          private void displaySelectedFriend()
          {
                if (listBoxFriends.SelectedItems.Count == 1)
                {
                    User selectedFriend = listBoxFriends.SelectedItem as User;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    }

                    labelFriendsName.Text = String.Format("{0} {1}", selectedFriend.FirstName, selectedFriend.LastName);
                    labelFriendsBirthday.Text = selectedFriend.Birthday;
                    labelFriendsGender.Text = selectedFriend.Gender;
                    labelFriendsLocation.Text = selectedFriend.Location;
                    labelFriendsHometown.Text = selectedFriend.Hometown;
                    labelFriendsRelationship.Text = selectedFriend.RelationshipStatus;
                    labelFriendsStatus.Text = selectedFriend.Statuses[0].Message;
                }
          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void m_ButtonPost_Click(object sender, EventArgs e)
          {
               
          }
                              
          private void m_Button_Photos_Click(object sender, EventArgs e)
          {

          }

          private void m_ButtonFriends_Click(object sender, EventArgs e)
          {

          }

          private void button5_Click(object sender, EventArgs e)
          {

          }
     }
}
