using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
     public interface IOpenable
     {
          bool TopLevel { get; set; }

          FormBorderStyle FormBorderStyle { get; set; }

          DockStyle Dock { get; set; }
          
          void Show();

          void BringToFront();
     }
}
