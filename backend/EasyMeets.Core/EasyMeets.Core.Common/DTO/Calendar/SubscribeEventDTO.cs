using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar
{
    public class SubscribeEventDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; } = string.Empty;

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; } = string.Empty;
    }
}
