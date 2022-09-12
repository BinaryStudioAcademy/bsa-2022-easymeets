using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class MeetResponseDto
{
    [JsonProperty("conferenceData")]
    public ConferenceDataResponseDto ConferenceData { get; set; } = null!;
}