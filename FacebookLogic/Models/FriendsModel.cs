using FacebookLogic.Models;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FacebookLogic.Models
{
     public class FriendsModel : UserModel
     {
          public List<User> FriendsList { get; private set; } = new List<User>();
          public City Location { get; set; }
          public string LocationStr { get; set; } = "N/A";
          public string FullName { get; set; } = "N/A";
          public string NameFormat { get; set; } = "{0} {1}";
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public string Birthday { get; set; } = "N/A";
          public User.eGender? Gender { get; set; }
          public string GenderStr { get; set; } = "N/A";
          public City Hometown { get; set; }
          public string HometownStr { get; set; } = "N/A";
          public User.eRelationshipStatus? RelationshipStatus { get; set; }
          public string RelationshipStatusStr { get; set; } = "N/A";

          public string Status { get; set; } = "N/A";
     }
}
