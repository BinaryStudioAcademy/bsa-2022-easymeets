using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.BLL.Services;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.Team;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService _meetingService;
        private readonly ITeamService _teamService;
        private readonly IUserService _userService;

        public MeetingController(IMeetingService meetingService, ITeamService teamService, IUserService userService)
        {
            _meetingService = meetingService;
            _userService = userService;
            _teamService = teamService;
        }

        [HttpGet]
        [Route("GetThreeMeetingMembers")]
        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync() => await _meetingService.GetThreeMeetingMembersAsync();

        [HttpGet]
        public async Task<ActionResult<ICollection<NewMeetingTeamMemberDto>>> GetTeamMembersOfCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            var teamMembers = await _teamService.GetTeamMembersOfCurrentUserAsync(user.Id);
            return Ok(teamMembers);
        }  
    }
}
