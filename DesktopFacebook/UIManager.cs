using System;
using System.Windows.Forms;

namespace DesktopFacebook
{
     public class UIManager
     {
          FormSignIn m_SigningInForm = null;
          
          public UIManager()
          {
               m_SigningInForm = new FormSignIn();
          }

          public void Run()
          {
               Application.Run(m_SigningInForm);
          }
     }
}
