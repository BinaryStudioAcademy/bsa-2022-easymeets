using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class EventTimeDto
{
    [JsonProperty("dateTime")]
    public DateTime DateTime { get; set; }
}