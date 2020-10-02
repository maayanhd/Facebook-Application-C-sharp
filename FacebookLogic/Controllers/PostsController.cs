using System;
using FacebookLogic.Models;
using FacebookLogic.Strategies;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Controllers
{
    public class PostsController
    {
        public PostsModel UserPostsData { get; private set; }

        public event EventHandler PostCreatedEvent;

        public event EventHandler ErrorMessageEvent;

        public int m_MaxPostsLimit;

        public IFetchStrategy PostsFetchStrategy { get; set; }

        public PostsController(User i_LoggedInUser, EventHandler i_PostCreatedEvent, EventHandler i_ErrorMessageNotifier)
        {
            UserPostsData = new PostsModel();
            UserPostsData.User = i_LoggedInUser;
            PostCreatedEvent += i_PostCreatedEvent;
            ErrorMessageEvent += i_ErrorMessageNotifier;
            m_MaxPostsLimit = AppSettings.Instance.MaxPostsShown;
        }

        public void FetchUserPosts()
        {
            try
            {
                PostsFetchStrategy.FetchData();
                foreach (Post post in UserPostsData.Posts)
                {
                    onCreatedPost(post);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                onErrorMessageEvent(errorMessage);
            }
        }

        private void onCreatedPost(Post post)
        {
            if (PostCreatedEvent != null)
            {
                PostCreatedEvent.Invoke(post, EventArgs.Empty);
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