﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
     public partial class CustomPictureBoxButton : PictureBox
     {
          public Image m_NormalImage { get; set; }
          public Image m_HoverImage{ get; set; }
          public CustomPictureBoxButton()
          {
               InitializeComponent();
          }

          //private void CustomPictureBoxButton_MouseHover(object sender, EventArgs e)
          //{
          //     this.Image = m_HoverImage;
          //}

          //private void CustomPictureBoxButton_MouseLeave(object sender, EventArgs e)
          //{
          //     this.Image = m_NormalImage;
          //}

     }
}
