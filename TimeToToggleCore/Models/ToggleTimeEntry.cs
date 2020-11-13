    using System;
    using Newtonsoft.Json;


namespace TimeToToggleCore.Models
{
    public partial class ToggleTimeEntry
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("wid")]
        public long Wid { get; set; }

        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pid { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("stop")]
        public DateTimeOffset Stop { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("duronly")]
        public bool Duronly { get; set; }

        [JsonProperty("at")]
        public DateTimeOffset At { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }
    }
}