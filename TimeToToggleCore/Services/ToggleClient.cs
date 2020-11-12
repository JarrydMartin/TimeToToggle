using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TimeToToggleCore.Models;
using TimeToToggleCore.Untlies;

namespace TimeToToggleCore.Services
{
    public class ToggleClient : IToggleClient
    {

        private readonly ILogger _logger;
        private readonly HttpClient _client;
        public ToggleClient(ILogger<ToggleClient> logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<ToggleMe> GetMe()
        {
            var response = await _client.GetAsync("me");

            response.EnsureSuccessStatusCode();
            return await Parse<ToggleMe>.HttpResponse(response);
        } 

        public async Task<IEnumerable<ToggleTimeEntries>> GetTimeEntries()
        {
            var response = await _client.GetAsync("time_entries");

            response.EnsureSuccessStatusCode();
            return await Parse<IEnumerable<ToggleTimeEntries>>.HttpResponse(response);
        }
    
    }
}
