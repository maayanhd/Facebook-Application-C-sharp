using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Strategies
{
    public class FetchNewsFeedFromAPIStrategy : IFetchStrategy
    {
        public PostsModel NewsFeedModel { get; set; }

        public int MaxPostsLimit { get; set; }

        public void FetchData()
        {
            if (NewsFeedModel.User.Posts?.Count > 0)
            {
                int postIndex = 0;
                foreach (Post post in NewsFeedModel.User.Posts)
                {
                    NewsFeedModel.Posts.Add(post);
                    postIndex++;

                    if (postIndex >= MaxPostsLimit)
                    {
                        break;
                    }
                }
            }
            else
            {
                throw new Exception(string.Format("No news feed items to retrieve!{0]", Environment.NewLine));
            }
        }
    }
}
