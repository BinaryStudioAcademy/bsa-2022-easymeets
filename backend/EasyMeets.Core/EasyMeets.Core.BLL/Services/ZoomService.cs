using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;

namespace EasyMeets.Core.BLL.Services;

public class ZoomService : IZoomService
{
    private readonly HttpClient _httpClient;
    private const string TokenUri = "zoom.us/oauth/token";

    public ZoomService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CredentialsDto> GetNewCredentials(string authCode, string redirectUri)
    {
        var body = new NewCredentialsRequestDto
        {
            Code = authCode,
            RedirectUri = redirectUri
        };
        using var request = new HttpRequestMessage(HttpMethod.Post, TokenUri);
        var authValue = GetNewTokenAuthorization();
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);
        request.Content = JsonContent.Create(body);
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

        var response = await _httpClient.SendAsync(request);

        return (await response.Content.ReadFromJsonAsync<CredentialsDto>())!;
    }

    private string GetNewTokenAuthorization()
    {
        var clientId = Environment.GetEnvironmentVariable("ZoomClientId")!;
        var clientSecret = Environment.GetEnvironmentVariable("ZoomClientSecret")!;
        var bytes = Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}");
        return Convert.ToBase64String(bytes);
    }
}