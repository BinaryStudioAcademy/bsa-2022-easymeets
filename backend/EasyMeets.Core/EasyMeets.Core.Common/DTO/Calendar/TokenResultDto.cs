using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar;

public class TokenResultDto
{
    [JsonProperty("access_token")] 
    public string AccessToken { get; set; } = string.Empty;

    [JsonProperty("expires_in")]
    public string ExpiresIn { get; set; } = string.Empty;

    [JsonProperty("scope")]
    public string Scope { get; set; } = string.Empty;

    [JsonProperty("token_type")]
    public string TokenType { get; set; } = string.Empty;

    [JsonProperty("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
}