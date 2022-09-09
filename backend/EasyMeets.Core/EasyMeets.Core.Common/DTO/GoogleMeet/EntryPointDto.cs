using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class EntryPointDto
{
    [JsonProperty("uri")]
    public string Uri { get; set; } = string.Empty;
}