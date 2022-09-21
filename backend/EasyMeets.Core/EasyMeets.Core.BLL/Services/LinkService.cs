using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.BLL.Services
{
    public class LinkService : BaseService, ILinkService
    {
        private readonly IConfiguration _config;
        private string _applicationUri;
        public LinkService(EasyMeetsCoreContext context, IMapper mapper, IConfiguration configuration) : base(context, mapper)
        {
            _config = configuration;
            _applicationUri = _config["ApplicationUri"];
        }

        public async Task<string> GenerateNewPageLinkAsync(long teamId, string teamName)
        {
            if (!await _context.Teams.AnyAsync(t => t.Id != teamId && t.PageLink == teamName))
            {
                return teamName;
            }
            int index = 1;

            while (await _context.Teams.AnyAsync(t => t.Id != teamId && t.PageLink == $"{teamName}{index}"))
            {
                index++;
            }

            return $"{teamName}{index}";
        }

        public string GenerateInvivationLink(IUrlHelper Url, long? userId, string userEmail, long teamId)
        {
            var teamDataJson = userId == null ?
                    JsonConvert.SerializeObject(new UserInvitationDataDto { UserEmail = userEmail, TeamId = teamId }) :
                    JsonConvert.SerializeObject(new UserInvitationDataDto { UserId = userId, UserEmail = userEmail, TeamId = teamId });

            string urlEncodedTeamData = HttpUtility.UrlEncode(teamDataJson, Encoding.UTF8);

            var url = Url.Link("AcceptInvitation", new { ecodedTeamData = urlEncodedTeamData });

            return url;
        }

        public string GenerateRedirectLinkForResigteredUser(long teamId)
        {

            var actionPath = $"settings/teams/members/{teamId}";

            var redirectionLink = $"{_applicationUri}{actionPath}";

            return redirectionLink;
        }

        public string GenerateRedirectLinkForNewUser(long teamId)
        {
            var pagePath = "auth/signup";

            var redirectionLink = $"{_applicationUri}{pagePath}";

            var uriBuilder = new UriBuilder(redirectionLink);

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["teamId"] = $"{teamId}";

            uriBuilder.Query = query.ToString();

            redirectionLink = uriBuilder.ToString();


            return redirectionLink;
        }
    }
}
