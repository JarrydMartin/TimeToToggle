using System;
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
                services.AddHttpClient<ToggleService>(client =>
                {
                    var authString = "<ApiToken>:api_token";
                    var EncodedAuthString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authString));
                    client.BaseAddress = new Uri("https://api.track.toggl.com/api/v8/");
                    client.DefaultRequestHeaders.Add("Authorization", $"Basic {EncodedAuthString}");
                });
             }).Build();

            ToggleService toggleService = host.Services.GetService<ToggleService>();

            ToggleMe result = toggleService.GetMe().Result;
            Console.WriteLine(result.Data.Fullname);

            // List<ToggleTimeEntries> timeEntriesResults = toggleService.GetTimeEntries().Result.ToList();
        }
    }
}


