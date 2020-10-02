using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Strategies
{
     public class FetchPostsFromAPIStrategy : IFetchStrategy
     {
          public PostsModel PostsModel { get; set; }

          public int MaxPostsLimit { get; set; }

          public void FetchData()
          {
               PostsModel.Posts.Clear();

               if (PostsModel.User.Posts?.Count > 0)
               {
                    int postIndex = 0;
                    foreach (Post post in PostsModel.User.Posts)
                    {
                         PostsModel.Posts.Add(post);
                         postIndex++;

                         if (postIndex >= MaxPostsLimit)
                         {
                              break;
                         }
                    }
               }
               else
               {
                    throw new Exception(string.Format("No posts to retrieve!{0]", Environment.NewLine));
               }
          }
     }
}
