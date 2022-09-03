using EasyMeets.Core.BLL.Helpers;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services;

public class GoogleOAuthService : IGoogleOAuthService
{
    private readonly IConfiguration _configuration;
    
    public GoogleOAuthService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string GetAuthorizationUrl()
    {
        var codeVerifier = Guid.NewGuid().ToString();
        Environment.SetEnvironmentVariable("codeVerifier", codeVerifier);

        var codeChallenge = Sha256Helper.ComputeHash(codeVerifier);
        
        var url = GenerateOAuthRequestUrl(_configuration["GoogleCalendar:CalendarScope"], _configuration["GoogleCalendar:RedirectUrl"], codeChallenge);

        return url;
    }
    
    public string GenerateOAuthRequestUrl(string scope, string redirectUrl, string codeChallenge)
    {
        var queryParams = new Dictionary<string, string>
        {
            {"client_id", Environment.GetEnvironmentVariable("google_calendar_client_id")!},
            {"redirect_uri", redirectUrl},
            {"response_type", "code"},
            {"scope", scope},
            {"code_challenge", codeChallenge},
            {"code_challenge_method", "S256"},
            {"access_type", "offline"},
            {"prompt", "consent"}
        };

        var url = QueryHelpers.AddQueryString(_configuration["GoogleCalendar:OAuthServer"], queryParams);

        return url;
    }

    public async Task<TokenResultDto> ExchangeCodeOnToken(string code, string codeVerifier, string redirectUrl)
    {
        var authParams = new Dictionary<string, string>
        {
            {"client_id", Environment.GetEnvironmentVariable("google_calendar_client_id")!},
            {"client_secret", Environment.GetEnvironmentVariable("google_calendar_client_secret")!},
            {"code", code},
            {"code_verifier", codeVerifier},
            {"grant_type", "authorization_code"},
            {"redirect_uri", redirectUrl},
            {"crossDomain", "true"}
        };

        var tokenResult = await HttpClientHelper.SendPostRequest<TokenResultDto>(_configuration["GoogleCalendar:TokenEndpoint"], authParams);

        return tokenResult;
    }
    
    public async Task<TokenResultDto> RefreshToken(string refreshToken)
    {
        var authParams = new Dictionary<string, string>
        {
            {"client_id", Environment.GetEnvironmentVariable("google_calendar_client_id")!},
            {"client_secret", Environment.GetEnvironmentVariable("google_calendar_client_secret")!},
            {"grant_type", "refresh_token"},
            {"refresh_token", refreshToken}
        };
        
        var tokenResult = await HttpClientHelper.SendPostRequest<TokenResultDto>(_configuration["GoogleCalendar:TokenEndpoint"], authParams);

        return tokenResult;
    }
}