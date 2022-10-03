using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TouristGuide.DataLayer;

namespace TouristGuide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IHost host = BuildWebHost(args);
            await host.RunAsync();
        }

        public static IHost BuildWebHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(Web => {
                    Web.UseStartup<Startup>()
                      .UseConfiguration(Configuration)
                      .UseSerilog();
                })
                .Build();
    }
}
