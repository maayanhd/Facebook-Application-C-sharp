using FacebookLogic.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
     public partial class FormMyAlbums : Form
     {
          private AlbumsController AlbumsController { get; set; }
          
          public FormMyAlbums()
          {
               InitializeComponent();
               AlbumsController = new AlbumsController(m_LoggedInUser, this.album_Clicked, this.photo_Clicked);
          }

      
     }
}
