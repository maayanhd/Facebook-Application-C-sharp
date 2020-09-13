using FacebookWrapper.ObjectModel;
using System;

namespace FacebookLogic.Controllers
{
    public class ApplicationController
    {
        private readonly User m_LoggedInUser;
        public EventByParametersController EventsFinderService { get; set; }
        public MatchMakerController MatchMakerService { get; set; }
        private AlbumsController AlbumsController { get; set; }
        private FriendController FriendsController { get; set; }
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

        public void InitializeEventsController(EventHandler i_EventsFetchedErrorOccured, EventHandler i_FriendsFetchedErrorOccured,
               EventHandler i_GenderFieldFetchedErrorOccured, EventHandler i_FilteredMatchingEventFound)
        {
            EventsFinderService = new EventByParametersController(m_LoggedInUser, i_EventsFetchedErrorOccured, i_FriendsFetchedErrorOccured, i_GenderFieldFetchedErrorOccured, i_FilteredMatchingEventFound);
        }

        public void InitializeFriendsController(EventHandler i_FriendItemRetriviedEvent, EventHandler i_SelectedIndexChanged)
        {
            FriendsController = new FriendController(m_LoggedInUser, i_FriendItemRetriviedEvent, i_SelectedIndexChanged);
        }

        public void FetchUserFriends()
        {
            FriendsController.FetchUserFriends();
        }

        public void InitializeMatchMakerController(EventHandler i_MatchedFriendFoundEvent, EventHandler i_MatchedFriendNotFoundEvent, EventHandler i_ErrorMessageNotifier)
        {
            MatchMakerService = new MatchMakerController(m_LoggedInUser, i_MatchedFriendFoundEvent, i_MatchedFriendNotFoundEvent, i_ErrorMessageNotifier);
        }

        public void InitializeNewsFeedController(EventHandler i_FeedItemCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            NewsFeedController = new NewsFeedController(m_LoggedInUser, i_FeedItemCreatedEvent, i_ErrorMessageNotifier);
        }

        public void FetchNewsFeed()
        {
            NewsFeedController.FetchNewsFeed();
        }

        public void InitializePostsController(EventHandler i_PostCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            PostsController = new PostsController(m_LoggedInUser, i_PostCreatedEvent, i_ErrorMessageNotifier);
        }

        public void FetchUserPosts()
        {
            PostsController.FetchUserPosts();
        }
    }
}