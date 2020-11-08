using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TimeToToggleCore.Untlies
{
    public static class JsonTranslate<T>
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters = {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        public static T FromJson(string json) => JsonConvert.DeserializeObject<T>(json, Settings);
    
        public static string ToJson(T self) => JsonConvert.SerializeObject(self, Settings);       
    }

}
