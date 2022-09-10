using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class ConferenceSolutionKeyDto
{
    [JsonProperty("type")]
    public string Type { get; set; } = "hangoutsMeet";
}