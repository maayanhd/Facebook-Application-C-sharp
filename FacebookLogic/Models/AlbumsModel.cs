using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookLogic.Models
{
    public class AlbumsModel : UserModel
    {
        public List<PictureBox> Albums { get; set; } = new List<PictureBox>();
        public List<PictureBox> Photos { get; set; } = new List<PictureBox>();
        public Photo SelectedPhoto { get; set; }
    }
}
