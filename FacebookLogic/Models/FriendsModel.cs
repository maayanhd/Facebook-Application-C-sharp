using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Models
{
     public class FriendsModel : UserModel
     {
          public List<User> FriendsList { get; private set; } = new List<User>();

          public City Location { get; set; }

          public string NameFormat { get; set; } = "{0} {1}";

          public string FirstName { get; set; }

          public string LastName { get; set; }

          public string Birthday { get; set; }

          public User.eGender? Gender { get; set; }

          public User.eRelationshipStatus RelationshipStatus { get; set; } 

          public string Status { get; set; }
     }
}
