using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TimeToToggleCore.Models;
using TimeToToggleCore.Services;

namespace TimeToToggleCLI
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
             .ConfigureServices((context, services) =>
             {
                services.AddHttpClient<IToggleClient, ToggleClient>();
                services.AddTransient<IToggleService, ToggleService>();
             }).Build();

            IToggleService toggleService = host.Services.GetService<IToggleService>();
        }
    }
}


