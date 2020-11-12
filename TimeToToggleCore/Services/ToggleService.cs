using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Logging;
using TimeToToggleCore.Models;
using TimeToToggleCore.Untlies;

namespace TimeToToggleCore.Services
{
    public class ToggleService : IToggleService
    {
        private readonly ILogger _logger;
        private readonly IToggleClient _client;
        public ToggleService(ILogger<ToggleService> logger, IToggleClient client)
        {
            _logger = logger;
            _client = client;
        }

        public IEnumerable<ToggleTimeEntries> GetTimeEntriesToday()
        {
            List<ToggleTimeEntries> timeEntries = _client.GetTimeEntries().Result.ToList();
            
            return timeEntries.Where(entries => {
                DateTime entryDate = entries.Start.ToLocalTime().Date;
                DateTime today = DateTime.Today.ToLocalTime().Date;
                return entryDate == today;
                });
        }

        
    }
}
