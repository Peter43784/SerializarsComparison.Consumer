using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleClient.Models;
using ConsoleClient.Providers;

namespace ConsoleClient
{
    public class WebApiFacade
    {
        private readonly FormatProvider _formatProvider;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        private static readonly HttpClient Client = new HttpClient();

        static WebApiFacade()
        {
            Client.BaseAddress = new Uri("http://localhost:56248/");
         }

        public WebApiFacade(FormatProvider formatProvider)
        {
            _formatProvider = formatProvider;
            //Client.Timeout = TimeSpan.FromMinutes(10);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(_formatProvider.MediaTypeHeaderValue);
        }
         
        public IEnumerable<HmdfEntity>GetRecords(int count)
        {
            Stopwatch.Restart();
            var records = ReadRecordsAsync($"api/records/{count}").Result;
            Stopwatch.Stop();
            Console.WriteLine($"Get:{_formatProvider.GetType() }: {Stopwatch.Elapsed}");

            return records;
        }

        public  void PostRecords(IEnumerable<HmdfEntity> records)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "api/records")
            {
                Content = new ObjectContent<IEnumerable<HmdfEntity>>(
                    records,
                    _formatProvider.MediaTypeFormatter)
            };
            Stopwatch.Restart();
            var result = Client.SendAsync(request).Result;
            Stopwatch.Stop();

            Console.WriteLine(result.IsSuccessStatusCode
                ? $"Post:{_formatProvider.GetType()}: {Stopwatch.Elapsed}"
                : $"Post:{_formatProvider.GetType()}: {result.ReasonPhrase} ");
        }

        private async Task<IEnumerable<HmdfEntity>> ReadRecordsAsync(string path)
        {
            List<HmdfEntity> records = null;
            var response = await Client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                records = await response.Content.ReadAsAsync<List<HmdfEntity>>(new[] { _formatProvider.MediaTypeFormatter });
            }
            return records;
        }


    }
}
