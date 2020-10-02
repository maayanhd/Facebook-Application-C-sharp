using System;
using FacebookLogic.Models;
using FacebookLogic.Strategies;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Controllers
{
    public class NewsFeedController
    {
        public PostsModel NewsFeedData { get; private set; }

        public event EventHandler FeedItemCreatedEvent;

        public event EventHandler ErrorMessageEvent;

        public int m_MaxPostsLimit;

        public IFetchStrategy NewsFeedFetchStrategy;

        public NewsFeedController(User i_LoggedInUser, EventHandler i_FeedItemCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            NewsFeedData = new PostsModel();
            NewsFeedData.User = i_LoggedInUser;
            FeedItemCreatedEvent += i_FeedItemCreatedEvent;
            ErrorMessageEvent += i_ErrorMessageNotifier;
            m_MaxPostsLimit = AppSettings.Instance.MaxPostsShown;
        }

        public void FetchNewsFeed()
        {
            try
            {
                NewsFeedFetchStrategy.FetchData();
                foreach (Post feed in NewsFeedData.User.Posts)
                {
                    onCreatedFeedItem(feed);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                onErrorMessageEvent(errorMessage);
            }
        }

        private void onCreatedFeedItem(Post post)
        {
            if (FeedItemCreatedEvent != null)
            {
                FeedItemCreatedEvent.Invoke(post, EventArgs.Empty);
            }
        }

        private void onErrorMessageEvent(string i_ErrorMessage)
        {
            if (ErrorMessageEvent != null)
            {
                ErrorMessageEvent.Invoke(i_ErrorMessage, EventArgs.Empty);
            }
        }
    }
}
