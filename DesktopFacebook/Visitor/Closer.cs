using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
     public class Closer
     {
          public void Close(ICloseable i_ToClose)
          {
               i_ToClose.Close();
          }
     }
}
