using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class ConferenceDataResponseDto
{
    [JsonProperty("entryPoints")]
    public EntryPointDto[] EntryPoints { get; set; } = Array.Empty<EntryPointDto>();
}