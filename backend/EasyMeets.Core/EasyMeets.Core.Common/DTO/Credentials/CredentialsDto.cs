using System.Text.Json.Serialization;

namespace EasyMeets.Core.Common.DTO.Credentials;

public class CredentialsDto
{
    [JsonPropertyName("access_token")] 
    public string AccessToken { get; set; } = string.Empty;

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
    
    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; set; }
}