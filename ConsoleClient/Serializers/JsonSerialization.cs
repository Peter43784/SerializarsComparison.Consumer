using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.Helpers;
using ConsoleClient.Models;
using Newtonsoft.Json;

namespace ConsoleClient.Serializers
{
    public class JsonSerialization
    {
        public static string Serialize(List<HmdfEntity> records)
        {
             JsonSerializer serializer = new JsonSerializer();

            return JsonConvert.SerializeObject(records);

        }

        public static List<HmdfEntity> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<List<HmdfEntity>>(json);
        }
    }
}
