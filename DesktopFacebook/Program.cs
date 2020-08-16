using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DesktopFacebook
{
     static class Program
     {
         [STAThread]
         static void Main()
         {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               UIManager ui = new UIManager();
               ui.Run();
         }
     }
}
