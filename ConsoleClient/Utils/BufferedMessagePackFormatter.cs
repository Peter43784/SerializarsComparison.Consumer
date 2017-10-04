using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MsgPack;
using MsgPack.Serialization;

namespace ConsoleClient.Utils
{
    public class BufferedMessagePackFormatter : BufferedMediaTypeFormatter
    {
        private const string mediaType = "application/x-msgpack";

        private static bool IsAllowedType(Type t)
        {
            if (t != null && !t.IsAbstract && !t.IsInterface && !t.IsNotPublic)
                return true;

            if (typeof(IEnumerable).IsAssignableFrom(t))
                return true;

            return false;
        }

        public BufferedMessagePackFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaType));
        }

        public override bool CanReadType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type is null");

            return IsAllowedType(type);
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type is null");

            return IsAllowedType(type);
        }

        public override object ReadFromStream(Type type, System.IO.Stream readStream, System.Net.Http.HttpContent content, IFormatterLogger formatterLogger)
        {
            if (content.Headers != null && content.Headers.ContentLength == 0)
                return null;

            var serializer = MessagePackSerializer.Get(type);
            object result;
            try
            {

                using (var unpacker = Unpacker.Create(readStream))
                {
                    unpacker.Read();
                    result = serializer.UnpackFrom(unpacker);
                }
            }
            catch (Exception ex)
            {
                if (formatterLogger == null)
                    throw;

                formatterLogger.LogError("", ex.Message);
                result = GetDefaultValueForType(type);
            }

            return result;
        }

        public override void WriteToStream(Type type, object value, System.IO.Stream writeStream, System.Net.Http.HttpContent content)
        {
            if (type == null)
                throw new ArgumentNullException("type is null");

            if (writeStream == null)
                throw new ArgumentNullException("writeStream is null");

            if (typeof(IEnumerable).IsAssignableFrom(type))
                value = (value as IEnumerable<object>).ToList();

            var serializer = MessagePackSerializer.Get<dynamic>();
            serializer.Pack(writeStream, value);

        }
    }
}
