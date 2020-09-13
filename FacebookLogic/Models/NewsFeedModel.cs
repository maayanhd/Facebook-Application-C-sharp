using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Models
{
     public class NewsFeedModel: UserModel
     {
        public List<Post> Feed { get; set; } = new List<Post>();
     }
}
