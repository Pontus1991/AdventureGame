using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Lektion1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Hej. Till onsdag kväll ska vi ha gjort lite mer på codeblocks.
            //Tja!! Haha, vi kollar igenom ifall man kör flexbox eller grid!
            //sen applicerar vi det på vår sida, med lite responsive webdesign och shit tror det är en struktur en sida ska ha
            //då kan vi göra en mall också, med layout och grids och sånt är klart, som när vi typ gjorde de här projektet.
           
            //Applicera Grids på elementen.
            //Köra igenom async.

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
