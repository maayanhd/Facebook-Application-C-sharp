using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Models
{
    public class PostsModel : UserModel
    {
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
