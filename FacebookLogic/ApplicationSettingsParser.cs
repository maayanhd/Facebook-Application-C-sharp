using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FacebookLogic
{
     internal class ApplicationSettingsParser
     {
          public static void Serialize(Stream i_Stream, object i_Caller)
          {
               XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
               xmlSerializer.Serialize(i_Stream, i_Caller);
          }

          public static AppSettings Desirialize(Stream i_Stream)
          {
               XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
               AppSettings result = xmlSerializer.Deserialize(i_Stream) as AppSettings;
               return result;
          }
     }
}
