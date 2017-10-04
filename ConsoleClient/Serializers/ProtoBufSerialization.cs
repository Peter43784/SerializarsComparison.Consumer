using System.Collections.Generic;
using System.IO;
using ConsoleClient.Helpers;
using ConsoleClient.Models;
using ProtoBuf;

namespace ConsoleClient.Serializers
{
    public class ProtoBufSerialization
    {
        public static byte[] Serialize(List<HmdfEntity> records)
        {
 
            using (var ms = new MemoryStream())
            {
                Serializer.Serialize(ms, records);
                return ms.ToArray();
            }


        }

        public static List<HmdfEntity> Deserialize(byte[] serializedData)
        {
            using (var ms = new MemoryStream(serializedData))
            {
                 return Serializer.Deserialize<List<HmdfEntity>>(ms);
            }
        }
    }
}
