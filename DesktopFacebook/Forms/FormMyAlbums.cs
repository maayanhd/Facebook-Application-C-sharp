using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
    public partial class FormMyAlbums : Form
    {
        private AlbumsController AlbumsController { get; set; }
        public FormMyAlbums(User i_LoggedInUser)
        {
            AlbumsController = new AlbumsController(i_LoggedInUser, this.AlbumsController_AlbumCreatedEvent, this.AlbumsController_PhotoCreatedEvent, this.AlbumsController_ErrorMessage);
            InitializeComponent();
            fetchUserAlbums();
        }

        private void AlbumsController_PhotoCreatedEvent(object sender, EventArgs e)
        {
            Photo photo = sender as Photo;
            PictureBox picBoxPhoto = new PictureBox();
            picBoxPhoto.Name = photo.Name;
            picBoxPhoto.Size = new System.Drawing.Size(75, 75);
            picBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBoxPhoto.Visible = true;
            picBoxPhoto.Tag = photo;
            picBoxPhoto.LoadAsync(photo.PictureNormalURL);

            picBoxPhoto.Click += this.photo_Clicked;
            this.flowLayoutPanelPhotos.Controls.Add(picBoxPhoto);
        }

        private void AlbumsController_AlbumCreatedEvent(object sender, EventArgs e)
        {
            while (!this.IsHandleCreated)
                System.Threading.Thread.Sleep(100);
            this.flowLayoutPanelAlbums.Invoke(new Action(() => 
            {
                Album album = sender as Album;
                PictureBox picBoxAlbum = new PictureBox();
                picBoxAlbum.Name = album.Name;
                picBoxAlbum.Size = new System.Drawing.Size(75, 75);
                picBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picBoxAlbum.Visible = true;
                picBoxAlbum.Tag = album;
                picBoxAlbum.LoadAsync(album.PictureAlbumURL);
                Photo photos = new Photo();

                picBoxAlbum.Click += this.album_Clicked;
                this.flowLayoutPanelAlbums.Controls.Add(picBoxAlbum);
            }
            ));
            //this.flowLayoutPanelAlbums.Controls.Add(picBoxAlbum);
        }

        private void fetchUserAlbums()
        {
            //this.flowLayoutPanelAlbums.Controls.Clear();
            new Thread(() => AlbumsController.FetchUserAlbums()).Start();
        }

        private void album_Clicked(object sender, EventArgs e)
        {
            this.flowLayoutPanelPhotos.Controls.Clear();
            Album selectedAlbum = (sender as PictureBox).Tag as Album;
            AlbumsController.FetchAlbumPhotos(selectedAlbum);
        }



        private void photo_Clicked(object sender, EventArgs e)
        {
            Photo selectedPhoto = (sender as PictureBox).Tag as Photo;
            this.pictureBoxSelectedPhoto.Load(selectedPhoto.PictureNormalURL);
        }

        private void AlbumsController_ErrorMessage(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }

        private void flowLayoutPanelAlbums_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
