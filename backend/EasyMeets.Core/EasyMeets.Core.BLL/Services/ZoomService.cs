using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.Zoom;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.Common.NamingPolicies;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.WebUtilities;

namespace EasyMeets.Core.BLL.Services;

public class ZoomService : BaseService, IZoomService
{
    private readonly HttpClient _httpClient;
    private const string TokenUri = "https://zoom.us/oauth/token";
    private const string BaseApiUri = "https://api.zoom.us/v2/";
    public ZoomService(EasyMeetsCoreContext context, IMapper mapper, HttpClient httpClient) : base(context, mapper)
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
        return await GetCredentials(queryString);
    }

    public async Task CreateZoomMeeting(Meeting meeting)
    {
        var credentials = meeting.Author.Credentials.FirstOrDefault(cr => cr.Type == CredentialsType.Zoom);
        if (credentials is null)
        {
            throw new KeyNotFoundException("No zoom credentials found for meeting Author");
        }

        var newMeeting = _mapper.Map<NewZoomMeetingDto>(meeting);
        
        using var request = new HttpRequestMessage(HttpMethod.Post, $"{BaseApiUri}/users/me/meetings");
        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
        };
        var token = await GetAccessToken(credentials);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        request.Content = JsonContent.Create(newMeeting, options:options);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var created = await response.Content.ReadFromJsonAsync<ZoomMeetingResponseDto>(options);
        meeting.MeetingLink = created!.JoinUrl;
        await _context.SaveChangesAsync();
    }

    private string GetTokenAuthorization()
    {
        var clientId = Environment.GetEnvironmentVariable("ZoomClientId")!;
        var clientSecret = Environment.GetEnvironmentVariable("ZoomClientSecret")!;
        var bytes = Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}");
        return Convert.ToBase64String(bytes);
    }

    private async Task<string> GetAccessToken(Credentials credentials)
    {
        if (DateTimeOffset.UtcNow - credentials.UpdatedAt < TimeSpan.FromSeconds(credentials.LifeCycle * 0.8))
        {
            await RefreshAccessToken(credentials);
        }

        return credentials.AccessToken;
    }

    private async Task RefreshAccessToken(Credentials credentials)
    {
        var queryString = new Dictionary<string, string?>
        {
            { "grant_type", "refresh_token" },
            { "refresh_token", credentials.RefreshToken}
        };
        var newCredentials = await GetCredentials(queryString);
        _mapper.Map(newCredentials, credentials);
        await _context.SaveChangesAsync();
    }

    private async Task<CredentialsDto> GetCredentials(IDictionary<string, string?> queryString)
    {
        var uri = QueryHelpers.AddQueryString(TokenUri, queryString);
        
        using var request = new HttpRequestMessage(HttpMethod.Post, uri);
        var authValue = GetTokenAuthorization();
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadFromJsonAsync<CredentialsDto>())!;
    }
}