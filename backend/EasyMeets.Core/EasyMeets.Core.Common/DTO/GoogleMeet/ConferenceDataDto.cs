using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class ConferenceDataDto
{
    [JsonProperty("createRequest")]
    public CreateRequestDto CreateRequest { get; set; } = new();
}