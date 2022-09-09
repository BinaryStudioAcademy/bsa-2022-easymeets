using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class EventWithMeetDto
{
    [JsonProperty("summary")]
    public string Summary { get; set; } = string.Empty;
    [JsonProperty("end")]
    public EventTimeDto End { get; set; } = new();
    [JsonProperty("start")]
    public EventTimeDto Start { get; set; } = new();
    [JsonProperty("conferenceData")]
    public ConferenceDataDto ConferenceData { get; set; } = new();
}