using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
     public class Director
     {
          public void ConstructCustomizedEvent(IBuilder i_EventBuilder)
          {
               i_EventBuilder.BuildEventDiscriptionPart();
               i_EventBuilder.BuildEventLocationDetailsPart();
               i_EventBuilder.BuildEventTimeRelatedDetailsPart();
               i_EventBuilder.BuildFriendDetailsPart();
          }
     }
}
