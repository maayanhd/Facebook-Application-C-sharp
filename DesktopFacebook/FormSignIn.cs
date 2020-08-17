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
          private LoginManager m_LoginManager;
          private AppSettings m_AppSettings;
          private bool m_IsAskingToRememberLoginDets;

          public FormSignIn()
          {
               InitializeComponent();
               FacebookService.s_CollectionLimit = 200;
               FacebookService.s_FbApiVersion = 2.8f;
               m_AppSettings = AppSettings.Instance;
               m_LoginManager = LoginManager.Instance;
               m_IsAskingToRememberLoginDets = false;
               m_LoginManager.DirectedToMainForm += FormSignIn_DirectedToMainForm;
          }

          private void FormSignIn_DirectedToMainForm(object sender, EventArgs e)
          {
               this.Hide();
               FormMainPage mainForm = new FormMainPage(m_IsAskingToRememberLoginDets, m_LoginManager.LoggedInUser, this);
               mainForm.ShowDialog();
               User user = new User();
          }

          private void customPictureBoxbutton_Click(object sender, EventArgs e)
          {
               m_LoginManager.Login();
               directToMainForm();
          }

          private void directToMainForm()
          {
               m_LoginManager.Login();
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

          private void panel2_Paint(object sender, PaintEventArgs e)
          {

          }
     }
}
