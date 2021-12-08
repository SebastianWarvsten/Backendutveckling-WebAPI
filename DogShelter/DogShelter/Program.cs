using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DogShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
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


//url = https//localhost:5001
//GET url/api/dogs/{id} -> få tillbaka en en unik dog baserad på id
//PUT url/api/dogs/{id} -> updatera namnet på en dog
//DELETE url/api/dogs/{id} -> radera en dog baserat på id
//POST url/api/dogs/ -> skapa en dog