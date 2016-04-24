using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models.Helpers
{
    public static class Serializer
    {
        public static Message Serialize<T>(Dictionary<Guid, T> d) where T : Base<T>
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Dictionary<Guid, T>));

            using (MemoryStream ms = new MemoryStream())
            {
                jsonFormatter.WriteObject(ms, d);
                return new Message { Data = Encoding.Default.GetString(ms.ToArray()), Name = typeof(T).ToString() };
            }
        }
        public static Dictionary<Guid, T> Deserialize<T>(Message m) where T : Base<T>
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Dictionary<Guid, T>));
            return (Dictionary<Guid, T>)json.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(m.Data)));
        }
    }
}
