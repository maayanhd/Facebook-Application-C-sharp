﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.Models
{
    public class UserModel
    {
          public UserModel(User i_LoggedInUser)
          {
               User = i_LoggedInUser;
          }

          public User User { get; set; }
         
    }
}