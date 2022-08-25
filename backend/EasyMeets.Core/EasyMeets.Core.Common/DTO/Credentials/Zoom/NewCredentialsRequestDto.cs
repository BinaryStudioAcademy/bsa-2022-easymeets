using System.Text.Json.Serialization;

namespace EasyMeets.Core.Common.DTO.Credentials.Zoom;

public class NewCredentialsRequestDto
{
    public string Code { get; set; } = string.Empty;
    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; } = "authorization_code";
    [JsonPropertyName("redirect_uri")]
    public string RedirectUri { get; set; } = string.Empty;
}