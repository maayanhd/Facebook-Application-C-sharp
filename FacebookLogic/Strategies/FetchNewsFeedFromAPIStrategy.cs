using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Strategies
{
     public class FetchNewsFeedFromAPIStrategy : IFetchStrategy
     {
          public NewsFeedModel NewsFeedModel { get; set; }

          public int MaxPostsLimit { get; set; }

          public void FetchData()
          {
               NewsFeedModel.Feed.Clear();

               if (NewsFeedModel.User.NewsFeed?.Count > 0)
               {
                    int postIndex = 0;
                    foreach (Post post in NewsFeedModel.User.NewsFeed)
                    {
                         NewsFeedModel.Feed.Add(post);
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
