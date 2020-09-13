using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookLogic.Models
{
    public class AlbumsModel : UserModel
    {
        public List<Album> Albums { get; set; } = new List<Album>();
        public List<Photo> Photos { get; set; } = new List<Photo>();
        public Photo SelectedPhoto { get; set; }
    }
}
