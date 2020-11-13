using System;
using Newtonsoft.Json;


namespace TimeToToggleCore.Models
{
    public partial class FreshdeskTimeEntry
    {
        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("agent_id")]
        public long AgentId { get; set; }
    }
}

