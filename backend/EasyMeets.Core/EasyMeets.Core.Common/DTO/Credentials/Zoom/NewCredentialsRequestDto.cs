using System.Text.Json.Serialization;

namespace EasyMeets.Core.Common.DTO.Credentials.Zoom;

public class NewCredentialsRequestDto
{
    public string Code { get; set; } = string.Empty;
    public string GrantType { get; set; } = "authorization_code";
    public string RedirectUri { get; set; } = string.Empty;
}