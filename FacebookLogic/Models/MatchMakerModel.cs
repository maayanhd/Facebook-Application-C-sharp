using System.Drawing;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookLogic.Models
{
    public class MatchMakerModel : UserModel
    {
        public User Friend { get; set; }

        public Parameters FilterParameters { get; set; }
        
        public class Parameters
        {
            public eGender Gender { get; set; }

            public Point AgeRange { get; set; }
        }
    }
}
