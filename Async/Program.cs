using System;
using System.Net.Https;
using System.Diagnostics;
using System.Threading.

namespace Async
{
    class Program
    {
        static async Main()
        {
         //Making Breakfast
           //Make Tea
           //Turn on Burner(2s)
           //Place kettle(2s)
           //Pour the water(5s)
           //Grind Masalas(60s)
           //Put sugar and masalas(5s)
           //Put Milk(3s)
           //Let it Boil(5s)

           ////Turn on Burner(2s)
           //put pan and add butter(2s)
           //Crack eggs and whisk it(2s)
           //fry eggs(2s)

           Stopwatch stopwatch= Stopwatch.StartNew();
           HttpClient client = new HttpClient();
           var google=client.GetStringAsync("www.google.com").Result;
           var m=client.GetStringAsync("www.microsoft.com").Result;
           var y=client.GetStringAsync("www.yahoo.com").Result;
           var g=client.GetStringAsync("https://github.com/MBM-SecA").Result;
           Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");

            var google=await client.GetStringAsync("www.google.com");
           var m=await client.GetStringAsync("www.microsoft.com");
           var y=await client.GetStringAsync("www.yahoo.com");
           var g=await client.GetStringAsync("github.com/MBM-SecA");
           Console.WriteLine($"{stopwatch.ElapsedMilliseconds}ms");


        }
    }
}
