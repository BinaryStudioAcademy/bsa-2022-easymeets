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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services;

public class ZoomService : BaseService, IZoomService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    public ZoomService(EasyMeetsCoreContext context, IMapper mapper, HttpClient httpClient, IConfiguration configuration) : base(context, mapper)
    {
        _httpClient = httpClient;
        _configuration = configuration;
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

    public async Task CreateZoomMeeting(long meetingId)
    {
        var meeting = _context.Meetings
            .Include(m => m.Author)
                .ThenInclude(u => u.Credentials)
            .FirstOrDefault(m => m.Id == meetingId) ?? throw new KeyNotFoundException("Invalid meeting id");
        var credentials = meeting.Author.Credentials.FirstOrDefault(cr => cr.Type == CredentialsType.Zoom) 
                          ?? throw new KeyNotFoundException("No zoom credentials found for meeting Author");

        var newMeeting = _mapper.Map<NewZoomMeetingDto>(meeting);
        
        using var request = new HttpRequestMessage(HttpMethod.Post, $"{_configuration["Zoom:BaseApiUri"]}/users/me/meetings");
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
        if (IsAlmostExpired(credentials))
        {
            await RefreshAccessToken(credentials);
        }

        return credentials.AccessToken;
    }

    private static bool IsAlmostExpired(Credentials credentials)
    {
        return DateTimeOffset.UtcNow - credentials.UpdatedAt > TimeSpan.FromSeconds(credentials.LifeCycle * 0.8);
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
        var uri = QueryHelpers.AddQueryString(_configuration["Zoom:AuthUri"], queryString);
        
        using var request = new HttpRequestMessage(HttpMethod.Post, uri);
        var authValue = GetTokenAuthorization();
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadFromJsonAsync<CredentialsDto>())!;
    }
}