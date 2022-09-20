using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public InvitationController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("accept/{ecodedTeamData}", Name = "AcceptInvitation")]
        public async Task<ActionResult<bool>> AcceptInvitation(string ecodedTeamData)
        {
            var urlDecodedTeamData = HttpUtility.UrlDecode(ecodedTeamData, Encoding.UTF8);
            var teamData = JsonConvert.DeserializeObject<TeamMemberInvitationDataDto>(urlDecodedTeamData);

            if (teamData != null)
            {
                if (teamData.UserId != null)
                {
                    await _teamService.CreateTeamMemberAsync((long)teamData.UserId, teamData.TeamId);
                    return Ok();
                }
                else { };
            }
            return BadRequest();
        }
    }
}
