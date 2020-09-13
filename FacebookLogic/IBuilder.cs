﻿using FacebookLogic.Models;
using System;

namespace FacebookLogic
{
     public interface IBuilder
     {
          void BuildFriendDetailsPart();
          
          void BuildEventLocationDetailsPart();

          void BuildEventTimeRelatedDetailsPart();

          void BuildEventDiscriptionPart();

          CustomizedEventModel CustomizedEvent { get;}
     }
}