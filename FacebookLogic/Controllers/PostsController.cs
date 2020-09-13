using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;

namespace FacebookLogic.Controllers
{
    public class PostsController
    {
        public PostsModel UserPostsData { get; private set; }
        public event EventHandler PostCreatedEvent;
        public event EventHandler ErrorMessageEvent;
        public int m_MaxPostsLimit;

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
            if (UserPostsData.User.Posts?.Count > 0)
            {
                int postIndex = 0;
                foreach (Post post in UserPostsData.User.Posts)
                {
                    UserPostsData.Posts.Add(post);
                    onCreatedPost(post);
                    postIndex++;

                    if (postIndex >= m_MaxPostsLimit)
                    {
                        break;
                    }
                }
            }
            else
            {
                string errorMessage = String.Format("No posts to retrieve!{0]", Environment.NewLine);
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