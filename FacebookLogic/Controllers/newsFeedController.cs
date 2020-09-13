using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;

namespace FacebookLogic.Controllers
{
    public class NewsFeedController
    {
        public PostsModel NewsFeedData { get; private set; }
        public event EventHandler FeedItemCreatedEvent;
        public event EventHandler ErrorMessageEvent;
        public int m_MaxPostsLimit;

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
            if (NewsFeedData.User.Posts?.Count > 0)
            {
                int postIndex = 0;
                foreach (Post feed in NewsFeedData.User.Posts)
                {
                    NewsFeedData.Posts.Add(feed);
                    onCreatedFeedItem(feed);
                    postIndex++;

                    if (postIndex >= m_MaxPostsLimit)
                    {
                        break;
                    }
                }
            }
            else
            {
                string errorMessage = String.Format("No news feed items to retrieve!{0]", Environment.NewLine);
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
