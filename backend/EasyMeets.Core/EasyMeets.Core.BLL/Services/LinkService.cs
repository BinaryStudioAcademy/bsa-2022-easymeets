using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.BLL.Services
{
    public class LinkService : BaseService, ILinkService
    {
        public LinkService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        { }

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
    }
}
