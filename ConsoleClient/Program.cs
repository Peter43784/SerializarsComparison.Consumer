using System;
using System.Collections.Generic;
using ConsoleClient.Helpers;
using ConsoleClient.Models;
using ConsoleClient.Providers;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1000;
            List<HmdfEntity> postrecords = SerializarionHelpers.GenerateRecords(1000);

            IEnumerable<HmdfEntity> records;
            var facade = new WebApiFacade(new JsonProvider());
            records = facade.GetRecords(count);
            facade.PostRecords(postrecords);

            facade = new WebApiFacade(new ProtoBufProvider());
            records = facade.GetRecords(count);
            facade.PostRecords(postrecords);


            facade = new WebApiFacade(new MsgPackProvider());
            records = facade.GetRecords(count);
            facade.PostRecords(postrecords);

            Console.WriteLine("-----------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
