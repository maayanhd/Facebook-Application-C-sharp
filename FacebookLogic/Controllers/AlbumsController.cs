using System;
using FacebookLogic.Models;
using FacebookLogic.Strategies;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Controllers
{
    public class AlbumsController
    {
        public event EventHandler AlbumCreatedEvent;

        public event EventHandler PhotoCreatedEvent;

        public event EventHandler ErrorMessageNotifier;

        public AlbumsModel UserAlbumsData { get; private set; }

        public IFetchStrategy AlbumsFetchStrategy;

        public AlbumsController(User i_LoggedInUser, EventHandler i_AlbumCreatedEvent, EventHandler i_PhotoCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            UserAlbumsData = new AlbumsModel();
            UserAlbumsData.User = i_LoggedInUser;
            AlbumCreatedEvent += i_AlbumCreatedEvent;
            PhotoCreatedEvent += i_PhotoCreatedEvent;
            ErrorMessageNotifier += i_ErrorMessageNotifier;
        }

        public void FetchUserAlbums()
        {
            AlbumsFetchStrategy.FetchData();
            foreach (Album album in UserAlbumsData.User.Albums)
            {
                onCreatedAlbum(album);
            }
        }

        private void onCreatedAlbum(Album i_Album)
        {
            if (AlbumCreatedEvent != null)
            {
                AlbumCreatedEvent.Invoke(i_Album, EventArgs.Empty);
            }
        }

        public void FetchAlbumPhotos(Album i_Album)
        {
            UserAlbumsData.Photos.Clear();
            try
            {
                foreach (Photo photo in i_Album.Photos)
                {
                    UserAlbumsData.Photos.Add(photo);
                    onCreatedPhoto(photo);
                }
            }
            catch (Exception)
            {
                string errorMessage = string.Format("Unable to fetch album photos {0]", Environment.NewLine);
                onErrorMessage(errorMessage);
            }
        }

        private void onCreatedPhoto(Photo i_Photo)
        {
            if (PhotoCreatedEvent != null)
            {
                PhotoCreatedEvent.Invoke(i_Photo, EventArgs.Empty);
            }
        }

        private void onErrorMessage(string i_ErrorMessage)
        {
            if (ErrorMessageNotifier != null)
            {
                ErrorMessageNotifier.Invoke(i_ErrorMessage, EventArgs.Empty);
            }
        }
    }
}
