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

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void m_ButtonPost_Click(object sender, EventArgs e)
          {
               
          }
                              
          private void m_Button_Photos_Click(object sender, EventArgs e)
          {

          }

     }
}
