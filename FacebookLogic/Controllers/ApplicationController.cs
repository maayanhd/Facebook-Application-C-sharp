using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Controllers
{
    public class ApplicationController
    {
        private readonly User m_LoggedInUser;
        private AlbumsController AlbumsController { get; set; }
        private EventByParametersController FindEventsController { get; set; }
        private FriendController FriendsController { get; set; }
        private MatchMakerController MatchMakerController { get; set; }
        private NewsFeedController NewsFeedController { get; set; }
        private PostsController PostsController { get; set; }

        public ApplicationController(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void InitizalizeAlbumsController(EventHandler i_AlbumCreatedEvent, EventHandler i_PhotoCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            AlbumsController = new AlbumsController(m_LoggedInUser, i_AlbumCreatedEvent, i_PhotoCreatedEvent, i_ErrorMessageNotifier);
        }

        public void FetchUserAlbums()
        {
            AlbumsController.FetchUserAlbums();
        }

        public void FetchAlbumPhotos(Album i_Album)
        {
            AlbumsController.FetchAlbumPhotos(i_Album);
        }
    }
}
