using DesktopFacebook.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
     public class Opener
     {
          public void Open(IOpenable i_ToOpen)
          {
               i_ToOpen.TopLevel = false;
               i_ToOpen.FormBorderStyle = FormBorderStyle.None;
               i_ToOpen.Dock = DockStyle.Fill;
               i_ToOpen.BringToFront();
               i_ToOpen.Show();
          }
     }
}

