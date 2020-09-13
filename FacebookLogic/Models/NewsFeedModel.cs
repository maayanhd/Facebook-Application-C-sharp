using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Models
{
     public class NewsFeedModel: UserModel
     {
        public List<Post> Feed { get; set; } = new List<Post>();
     }
}
