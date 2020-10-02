using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookLogic;
using DesktopFacebook.Forms;
using FacebookApp.UI;
using FacebookLogic.Models;
using FacebookLogic.Controllers;

namespace DesktopFacebook
{
     public partial class FormMainPage : Form, ICloseable
     {
          private readonly string logoutSuccessfulMessage = "Logged out successfully!";

          private Form m_CurrentChildForm = new Form();
          protected User m_LoggedInUser;
          private bool m_IsAskingToRememberLoginDets;

          internal ApplicationController ApplicationController { get; private set; }

          public FormMainPage(bool i_IsAskingToRememberLoginDets, User i_LoggedInUser, FormSignIn i_SignInForm)          
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               m_IsAskingToRememberLoginDets = i_IsAskingToRememberLoginDets;
               customizePanelsDesign();
               fetchUserDetails();
               LoginManager.Instance.LogoutSuccessful += LoginManager_LogoutSuccessful;

               // Update the panel with the inner form
               m_CurrentChildForm.TopLevel = false;
               ApplicationController = new ApplicationController(m_LoggedInUser);
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
               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormEmpty();
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void ButtonFriends_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Friends";
               hideSubMenu();
               showSubMenu(PanelFriends);
               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormEmpty();
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void FormMainPage_Load(object sender, EventArgs e)
          {
          }

          private void buttonMyFriendsList_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Friends List";
               (m_CurrentChildForm as ICloseable)?.Close();
               
               m_CurrentChildForm = new FormFriends(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonMyAlbums_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Albums";
               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormMyAlbums(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonNewFeatures_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Special Feature";
               hideSubMenu();
               showSubMenu(PanelNewFeatures);

               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormEmpty();
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonMatchMaker_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Match Maker";

               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormMatchMakerByParameters(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonEventsByParam_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "Events Finder";

               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormEventByParameters(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonNewsFeed_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "News Feed";

               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormNewsFeed(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonPosts_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "News Feed";
               hideSubMenu();
               showSubMenu(panelPosts);

               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormEmpty();
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }

          private void buttonLogout_Click(object sender, EventArgs e)
          {
               AppSettings.Instance.SaveAppSettings();
               LoginManager eventLogoutHandler = LoginManager.Instance;

               eventLogoutHandler.Logout();
               (this as ICloseable)?.Close();
          }

          private void m_TextBoxPost_MouseClick(object sender, MouseEventArgs e)
          {
               activateTextbox(sender as TextBox);
          }

          private void ButtonMyPosts_Click(object sender, EventArgs e)
          {
               ButtonChosenMenu.Text = "My Posts";
               (m_CurrentChildForm as ICloseable)?.Close();

               m_CurrentChildForm = new FormPosts(ApplicationController);
               PanelSelectedMenu.Controls.Add(m_CurrentChildForm);
          }
     }
}
