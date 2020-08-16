using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;

namespace DesktopFacebook
{
     public partial class FormSignIn : Form
     {
          User m_LoggedInUser;
          PictureBox m_pictureBox_smallProfilePicture;
          private LoginManager m_LoginManager;
          private AppSettings m_AppSettings;
          private bool m_IsAskingToRememberLoginDets;

          public FormSignIn()
          {
               InitializeComponent();
               FacebookWrapper.FacebookService.s_CollectionLimit = 200;
               FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
               m_AppSettings = AppSettings.Instance;
               m_LoginManager = LoginManager.Instance;
               m_IsAskingToRememberLoginDets = false;
               m_LoginManager.DirectedToMainForm += m_LoginManager_DirectedToMainForm;
          }

          private void m_LoginManager_DirectedToMainForm(object sender, EventArgs e)
          {
               this.Hide();
               this.Enabled = false;
               FormMainPage mainForm = new FormMainPage(m_IsAskingToRememberLoginDets);
               mainForm.ShowDialog();
          }

          private void customPictureBoxButton1_Click(object sender, EventArgs e)
          {
               directToMainForm();
          }

          private void directToMainForm()
          {
               m_LoginManager.directToMainForm();
          }

          private void m_CheckBoxRememberMe_CheckedChanged(object sender, EventArgs e)
          {
               handleRememberingMechanism();
          }

          private void handleRememberingMechanism()
          {
               m_IsAskingToRememberLoginDets = m_CheckBoxRememberMe.Checked;
          }
         
          //     if (!string.IsNullOrEmpty(result.AccessToken))
          //     {
          //          m_LoggedInUser = result.LoggedInUser;
          //          fetchUserInfo();
          //     }
          //     else
          //     {
          //          MessageBox.Show(result.ErrorMessage);
          //     }
          //}

          //private void fetchUserInfo()
          //{
          //     m_pictureBox_smallProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
          //     if (m_LoggedInUser.Posts.Count > 0)
          //     {
          //          textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
          //     }
          //}

     }
}
