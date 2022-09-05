using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar
{
    public class CalendarEventsDTO
    {
        [JsonProperty("summary")]
        public string Summary { get; set; } = string.Empty;

        [JsonProperty("items")]
        public List<EventItemDTO>? Items { get; set; }
    }
}
