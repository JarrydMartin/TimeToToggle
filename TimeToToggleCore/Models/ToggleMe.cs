using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace TimeToToggleCore.Models
{
    public partial class ToggleMe
    {
        [JsonProperty("since")]
        public long Since { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("api_token")]
        public string ApiToken { get; set; }

        [JsonProperty("default_wid")]
        public long DefaultWid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("jquery_timeofday_format")]
        public string JqueryTimeofdayFormat { get; set; }

        [JsonProperty("jquery_date_format")]
        public string JqueryDateFormat { get; set; }

        [JsonProperty("timeofday_format")]
        public string TimeofdayFormat { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }

        [JsonProperty("store_start_and_stop_time")]
        public bool StoreStartAndStopTime { get; set; }

        [JsonProperty("beginning_of_week")]
        public long BeginningOfWeek { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("new_blog_post")]
        public NewBlogPost NewBlogPost { get; set; }

        [JsonProperty("projects")]
        public object[] Projects { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("tasks")]
        public object[] Tasks { get; set; }

        [JsonProperty("workspaces")]
        public Workspace[] Workspaces { get; set; }

        [JsonProperty("clients")]
        public object[] Clients { get; set; }
    }

    public partial class NewBlogPost
    {
    }

    public partial class Workspace
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("at")]
        public DateTimeOffset At { get; set; }
    }
}