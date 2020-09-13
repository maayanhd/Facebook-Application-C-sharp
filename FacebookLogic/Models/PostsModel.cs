using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookLogic.Models
{
    public class PostsModel : UserModel
    {
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
