using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace ConsoleClient.Providers
{
    public abstract class FormatProvider
    {
        protected MediaTypeWithQualityHeaderValue _mdiaTypeHeaderValue;
        protected MediaTypeFormatter _mediaTypeFormatter;
        public MediaTypeWithQualityHeaderValue MediaTypeHeaderValue => _mdiaTypeHeaderValue;
        public MediaTypeFormatter MediaTypeFormatter => _mediaTypeFormatter;
        
    }
}
