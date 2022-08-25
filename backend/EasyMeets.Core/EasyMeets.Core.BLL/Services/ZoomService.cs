using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using Microsoft.AspNetCore.WebUtilities;

namespace EasyMeets.Core.BLL.Services;

public class ZoomService : IZoomService
{
    private readonly HttpClient _httpClient;
    private const string TokenUri = "https://zoom.us/oauth/token";

    public ZoomService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CredentialsDto> GetNewCredentials(NewCredentialsRequestDto newCredentialsRequestDto)
    {
        var queryString = new Dictionary<string, string?>
        {
            { "code", newCredentialsRequestDto.Code },
            { "grant_type", newCredentialsRequestDto.GrantType },
            { "redirect_uri", newCredentialsRequestDto.RedirectUri }
        };
        var uri = QueryHelpers.AddQueryString(TokenUri, queryString);
        
        using var request = new HttpRequestMessage(HttpMethod.Post, uri);
        var authValue = GetNewTokenAuthorization();
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

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