using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MsgPack;
using MsgPack.Serialization;

namespace ConsoleClient.Utils
{
    public class MessagePackFormatter : MediaTypeFormatter
    {
        private const string Mime = "application/x-msgpack";

        //TODO: try to implement interface serialization
        private readonly Func<Type, bool> _isAllowedType = (t) => !t.IsAbstract && !t.IsInterface && !t.IsNotPublic;

        public MessagePackFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(Mime));
        }

        public override bool CanReadType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            return _isAllowedType(type);
        }

        public override bool CanWriteType(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            return _isAllowedType(type);
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream stream, HttpContent content, TransportContext transportContext)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            var tcs = new TaskCompletionSource<object>();

            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                value = (value as IEnumerable<object>)?.ToList();
            }

            var serializer = MessagePackSerializer.Get<dynamic>();
            serializer.Pack(stream, value);

            tcs.SetResult(null);

            return tcs.Task;
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream stream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var tcs = new TaskCompletionSource<object>();
            if (content.Headers != null && content.Headers.ContentLength == 0) return null;

            try
            {
                var serializer = MessagePackSerializer.Get<dynamic>();
                object result;

                using (var unpacker = Unpacker.Create(stream))
                {
                    unpacker.Read();
                    result = serializer.UnpackFrom(unpacker);
                }

                tcs.SetResult(result);
            }
            catch (Exception e)
            {
                if (formatterLogger == null) throw;
                formatterLogger.LogError(string.Empty, e.Message);
                tcs.SetResult(GetDefaultValueForType(type));
            }

            return tcs.Task;
        }

     }
}
