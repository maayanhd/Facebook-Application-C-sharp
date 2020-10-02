﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
     public partial class EmptyForm : Form, IOpenable, ICloseable
     {
          public Closer Closer { get;} = new Closer();
          public Opener Opener { get; } = new Opener();

          public EmptyForm()
          {
               InitializeComponent();
          }
     }
}
