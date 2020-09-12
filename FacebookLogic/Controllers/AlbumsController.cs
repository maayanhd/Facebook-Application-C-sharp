using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookLogic.Controllers
{
    public class AlbumsController
    {
        private readonly User m_LoggedInUser;
        private readonly EventHandler m_AlbumSelectedNotifier;
        private readonly EventHandler m_PhotoSelectedNotifier;
        public AlbumsModel UserAlbumsData { get; private set; }

        public AlbumsController(User i_LoggedInUser, EventHandler i_AlbumSelectedNotifier, EventHandler i_PhotoSelectedNotifier)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_AlbumSelectedNotifier = i_AlbumSelectedNotifier;
            m_PhotoSelectedNotifier = i_PhotoSelectedNotifier;
            UserAlbumsData = new AlbumsModel();
        }

        public void FetchUserAlbums()
        {
            UserAlbumsData.Albums.Clear();
            foreach (Album album in m_LoggedInUser.Albums)
            {
                PictureBox picBoxAlbum = new PictureBox();
                picBoxAlbum.Name = album.Name;
                picBoxAlbum.Size = new System.Drawing.Size(75, 75);
                picBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picBoxAlbum.Visible = true;
                picBoxAlbum.Tag = album;
                picBoxAlbum.LoadAsync(album.PictureAlbumURL);

                //EventHandler albumClickedEventHandler = new EventHandler(this.onAlbumSelected);
                picBoxAlbum.Click += this.onAlbumSelected;
                picBoxAlbum.Click += m_AlbumSelectedNotifier;
                UserAlbumsData.Albums.Add(picBoxAlbum);
            }
        }

        private void onAlbumSelected(object sender, EventArgs e)
        {
            UserAlbumsData.Photos.Clear();
            PictureBox clickedAlbumBox = sender as PictureBox;
            Album selectedAlbum = clickedAlbumBox.Tag as Album;
            try
            {
                foreach (Photo photo in selectedAlbum.Photos)
                {
                    PictureBox picBoxPhoto = new PictureBox();
                    picBoxPhoto.Name = photo.Name;
                    picBoxPhoto.Size = new System.Drawing.Size(75, 75);
                    picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picBoxPhoto.Visible = true;
                    picBoxPhoto.Tag = photo;
                    picBoxPhoto.LoadAsync(photo.PictureNormalURL);

                    //EventHandler photoClickedEvent = new EventHandler(this.onPhotoSelected);
                    picBoxPhoto.Click += this.onPhotoSelected;
                    picBoxPhoto.Click += m_PhotoSelectedNotifier;
                    UserAlbumsData.Photos.Add(picBoxPhoto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to fetch album photos", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void onPhotoSelected(object sender, EventArgs e)
        {
            PictureBox clickedPhotoBox = sender as PictureBox;
            UserAlbumsData.SelectedPhoto = clickedPhotoBox.Tag as Photo;
        }
    }
}
