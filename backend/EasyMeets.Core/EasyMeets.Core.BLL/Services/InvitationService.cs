using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.BLL.Services
{
    public class InvitationService : BaseService, IInvitationService
    {
        private readonly ITeamService _teamService;
        private readonly ILinkService _linkService;
        public InvitationService(EasyMeetsCoreContext context, IMapper mapper, ITeamService teamService, ILinkService linkService) : base(context, mapper)
        {
            _teamService = teamService;
            _linkService = linkService;
        }

        public async Task<string> AcceptInvitationAndReturRedirectionLink(UserInvitationDataDto teamData)
        {
            if (teamData.UserId != null)
            {
                await _teamService.CreateTeamMemberAsync(teamData.UserId.Value, teamData.TeamId);

                var redirectionLink = _linkService.GenerateRedirectLinkForResigteredUser(teamData.TeamId);

                return redirectionLink;
            }
            else
            {
                var redirectionLink = _linkService.GenerateRedirectLinkForNewUser(teamData.TeamId);

                return redirectionLink;
            };
        }
    }
}
