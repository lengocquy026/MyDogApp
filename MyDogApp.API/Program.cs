using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyDogApp.API.Data;

namespace MyDogApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            // var host = CreateWebHostBuilder(args).Build();
            // using(var scope = host.Services.CreateScope()) {
            //     var sevices = scope.ServiceProvider;
            //     try{
            //         var context = sevices.GetRequiredService<DataContext>();
            //         context.Database.Migrate();
            //         Seed.SeedUsers(context);
            //     }
            //     catch(Exception ex) {
            //         var logeer = sevices.GetRequiredService<ILogger<Program>>();
            //         logeer.LogError(ex, "Error");
            //     }
            // }

            // host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
