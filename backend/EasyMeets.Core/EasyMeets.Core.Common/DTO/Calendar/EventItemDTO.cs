using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar
{
    public class EventItemDTO
    {
        [JsonProperty("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonProperty("location")]
        public string Location { get; set; } = string.Empty;

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
        [JsonProperty("start")]
        public StartTimeEventDTO? Start { get; set; }
        [JsonProperty("end")]
        public EndTimeEventDTO? End { get; set; }
    }
}
