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
        public MeetingController(IMeetingService meetingService, ITeamService teamService)
        {
            _meetingService = meetingService;
            _teamService = teamService; 
        }

        [HttpGet]
        [Route("GetThreeMeetingMembers")]
        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync() => await _meetingService.GetThreeMeetingMembersAsync();

        [HttpGet("{id:int}/members/all")]
        public async Task<ActionResult<List<UserMeetingDTO>>> GetAllMembers(int id)
        {
            return Ok(await _meetingService.GetAllMembers(id));
        }

        [HttpGet]
        [Route("getTeamMembersOfCurrentUser")]
        public async Task<ActionResult<ICollection<NewMeetingMemberDto>>> GetTeamMembersOfCurrentUser()
        { 
            var teamMembers = await _teamService.GetTeamMembersOfCurrentUserAsync();
            return Ok(teamMembers);
        }

        [HttpPost] 
        public async Task<ActionResult> SaveNewMeeting([FromBody] SaveMeetingDto newMeetingDto)
        {
            await _meetingService.CreateMeeting(newMeetingDto);
            return Ok();
        } 
    }
}
