using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class CreateRequestDto
{
    [JsonProperty("conferenceSolutionKey")]
    public ConferenceSolutionKeyDto ConferenceSolutionKey { get; set; } = new();
    [JsonProperty("requestId")]
    public string RequestId { get; set; } = Guid.NewGuid().ToString();
}