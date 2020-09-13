using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Models
{
     public class FriendsModel : UserModel
     {
          public List<User> FriendsList { get; private set; } = new List<User>();
          public City Location { get; set;}
          string NameFormat { get; set; } = "{0} {1}";
          string FirstName { get; set; }
          string LastName { get; set; }
          string Birthday { get; set;}
          public User.eGender? Gender { get; set; }
          public User.eRelationshipStatus RelationshipStatus { get; set; } 
          public string Status { get; set; }
     }
}
