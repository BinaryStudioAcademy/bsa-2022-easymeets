using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.User;
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
    private IUserService _userService;
    public ZoomService(EasyMeetsCoreContext context, IMapper mapper, HttpClient httpClient, IConfiguration configuration, IUserService userService) : base(context, mapper)
    {
        _userService = userService;
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

    public async Task RevokeAccessTokenAsync()
    {
        var currentUser = await _userService.GetCurrentUserAsync();

        var user = await _context.Users.Include(u => u.Credentials)
            .FirstAsync(u => u.Uid == currentUser.Uid);
        var credentials = user.Credentials.FirstOrDefault(cr => cr.Type == CredentialsType.Zoom) ??
            throw new KeyNotFoundException("Credentials doesn't exist");

        var token = await GetAccessToken(credentials);

        var queryString = new Dictionary<string, string?>
        {
            { "token", token}
        };

        var uri = QueryHelpers.AddQueryString(_configuration["Zoom:RevokeUri"], queryString);

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);
        var authValue = GetTokenAuthorization();
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        _context.Credentials.Remove(credentials);

        await _context.SaveChangesAsync();
    }

    public async Task<EmailDto> CreateZoomCredentials(NewCredentialsRequestDto newCredentialsRequestDto)
    {
        EmailDto emailDto;

        var currentUser = await _userService.GetCurrentUserAsync();
        var user = await _context.Users.Include(u => u.Credentials)
            .FirstOrDefaultAsync(u => u.Uid == currentUser.Uid) ?? throw new KeyNotFoundException("User doesn't exist");

        var credentialsDto = await GetNewCredentials(newCredentialsRequestDto);

        if (user.Credentials.Any(cr => cr.Type == CredentialsType.Zoom))
        {
            var credentials = user.Credentials.First(cr => cr.Type == CredentialsType.Zoom);
            _mapper.Map(credentialsDto, credentials);
            emailDto = new EmailDto() { Email = credentials.UserEmail };
        }
        else
        {
            var credentials = _mapper.Map<Credentials>(credentialsDto, opts => opts.AfterMap((_, dest) =>
            {
                dest.Type = CredentialsType.Zoom;
                dest.UserId = user.Id;
            }));
            await _context.Credentials.AddAsync(credentials);
            await _context.SaveChangesAsync();
            emailDto = await GetZoomUserEmailAsync(credentials);
            credentials.UserEmail = emailDto.Email;
        }
        await _context.SaveChangesAsync();
        return emailDto;
    }

    public async Task<EmailDto> GetZoomUserEmailAsync()
    {
        var currentUser = await _userService.GetCurrentUserAsync();

        var user = await _context.Users.Include(u => u.Credentials)
            .FirstAsync(u => u.Uid == currentUser.Uid);
        var credentials = user.Credentials.FirstOrDefault(cr => cr.Type == CredentialsType.Zoom);

        var emailDto = new EmailDto
        {
            Email = credentials?.UserEmail
        };

        return emailDto;
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

    private async Task<EmailDto> GetZoomUserEmailAsync(Credentials credentials)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, $"{_configuration["Zoom:BaseApiUri"]}/users/me");

        var token = await GetAccessToken(credentials);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
        };

        var emailDto = await response.Content.ReadFromJsonAsync<EmailDto>(options) ?? new EmailDto();

        return emailDto;
    }
}