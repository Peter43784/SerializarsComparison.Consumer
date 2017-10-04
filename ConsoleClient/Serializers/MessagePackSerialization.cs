using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.Helpers;
using ConsoleClient.Models;
using MsgPack.Serialization;

namespace ConsoleClient.Serializers
{
    public class MessagePackSerialization
    {
        private static readonly MessagePackSerializer<List<HmdfEntity>> Serializer =
            SerializationContext.Default.GetSerializer<List<HmdfEntity>>();

        public static byte[] Serialize(List<HmdfEntity> records)
        {
 
            using (var ms = new MemoryStream())
            {
                Serializer.Pack(ms, records);

                return ms.ToArray();
            }

            // Pack obj to stream.


        }

        public static List<HmdfEntity> Deserialize(byte[] serializedData)
        {
            using (var ms = new MemoryStream(serializedData))
            {
                return Serializer.Unpack(ms);

            }
        }
    }
}
