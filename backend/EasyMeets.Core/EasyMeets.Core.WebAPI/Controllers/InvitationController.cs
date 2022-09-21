using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IInvitationService _invitationService;
        public InvitationController(IInvitationService invitationService)
        {
            _invitationService = invitationService;
        }

        [HttpGet("accept/{ecodedTeamData}", Name = "AcceptInvitation")]
        [AllowAnonymous]
        public async Task<ActionResult> AcceptInvitation(string ecodedTeamData)
        {
            var urlDecodedTeamData = HttpUtility.UrlDecode(ecodedTeamData, Encoding.UTF8);

            var teamData = JsonConvert.DeserializeObject<UserInvitationDataDto>(urlDecodedTeamData);

            if (teamData != null)
            {
                var redirectionLink = await _invitationService.AcceptInvitationAndReturRedirectionLink(teamData);
                return Redirect(redirectionLink);
            }

            return BadRequest();
        }
    }
}
