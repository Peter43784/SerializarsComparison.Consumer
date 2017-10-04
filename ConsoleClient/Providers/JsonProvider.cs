using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace ConsoleClient.Providers
{
    public class JsonProvider : FormatProvider
    {
        public JsonProvider()
        {
            _mdiaTypeHeaderValue = new MediaTypeWithQualityHeaderValue("application/json");
            _mediaTypeFormatter = new JsonMediaTypeFormatter();
        }
    }
}
