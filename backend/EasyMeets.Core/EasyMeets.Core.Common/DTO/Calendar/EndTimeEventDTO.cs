using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar
{
    public class EndTimeEventDTO
    {
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; } = string.Empty;
    }
}
