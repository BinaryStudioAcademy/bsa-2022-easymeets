using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IUserService _userService;
        public MeetingController(ITeamService teamService, IUserService userService)
        {
            _teamService = teamService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<NewMeetingTeamMemberDto>>> GetTeamMembersOfCurrentUser()
        {
            var email = _userService.GetCurrentUserEmail();
            var user = await _userService.GetCurrentUserAsync(email);
            var teamMembers = await _teamService.GetTeamMembersOfCurrentUserAsync(user.Id);
            return Ok(teamMembers);
        }
    }
}
