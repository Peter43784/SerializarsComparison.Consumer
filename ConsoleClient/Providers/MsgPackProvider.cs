using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using ConsoleClient.Utils;

namespace ConsoleClient.Providers
{
    public class MsgPackProvider : FormatProvider
    {
        public MsgPackProvider()
        {
            _mdiaTypeHeaderValue = new MediaTypeWithQualityHeaderValue("application/x-msgpack");
            _mediaTypeFormatter = new BufferedMessagePackFormatter();
        }
    }
}
