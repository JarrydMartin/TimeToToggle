using System;
using Newtonsoft.Json;

namespace TimeToToggleCore.Models
{
    public class ToggleReportTransport
    {
        [JsonProperty("data")]
        public ToggleReport ToggleReport { get; set; }
    }

    public partial class ToggleReport
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("wid")]
        public long Wid { get; set; }

        [JsonProperty("cid")]
        public long Cid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("at")]
        public DateTimeOffset At { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

}
