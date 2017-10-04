using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using WebApiContrib.Formatting;

namespace ConsoleClient.Providers
{
    public class ProtoBufProvider : FormatProvider
    {
        public ProtoBufProvider()
        {
            _mdiaTypeHeaderValue = new MediaTypeWithQualityHeaderValue("application/x-protobuf");
            _mediaTypeFormatter = new ProtoBufFormatter();
        }
    }
}
