using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvitationController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public InvitationController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("accept/{ecodedTeamData}", Name = "AcceptInvitation")]
        [AllowAnonymous]
        public async Task<ActionResult> AcceptInvitation(string ecodedTeamData)
        {
            var urlDecodedTeamData = HttpUtility.UrlDecode(ecodedTeamData, Encoding.UTF8);
            var teamData = JsonConvert.DeserializeObject<UserInvitationDataDto>(urlDecodedTeamData);

            if (teamData != null)
            {
                if (teamData.UserId != null)
                {
                    await _teamService.CreateTeamMemberAsync((long)teamData.UserId, teamData.TeamId);

                    var absUrl = $"http://localhost:4200/teams/members/{teamData.TeamId}";

                    var uriBuilder = new UriBuilder(absUrl); 
                    var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                    query["teamId"] = $"{teamData?.TeamId}";
                    uriBuilder.Query = query.ToString();
                    absUrl = uriBuilder.ToString();
                    return Redirect(absUrl);
                }
                else
                {
                    var absUrl = "http://localhost:4200/auth/signin";
                    var uriBuilder = new UriBuilder(absUrl);
                    var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                    query["teamId"] = $"{teamData?.TeamId}";
                    uriBuilder.Query = query.ToString();
                    absUrl = uriBuilder.ToString();

                    return Redirect(absUrl);
                };
            }
            return BadRequest();
        }
    }
}
