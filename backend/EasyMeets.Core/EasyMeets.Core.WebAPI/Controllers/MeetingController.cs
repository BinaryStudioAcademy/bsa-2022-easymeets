using EasyMeets.Core.BLL.Interfaces;
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

        [HttpGet("GetThreeMeetingMembers/{teamId?}")]
        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync(long? teamId) => await _meetingService.GetThreeMeetingMembersAsync(teamId);

        [HttpGet("{id:int}/members/all")]
        public async Task<ActionResult<List<UserMeetingDTO>>> GetAllMembers(int id)
        {
            return Ok(await _meetingService.GetAllMembers(id));
        }

        [HttpGet("ordered-times/{slotId}")]
        public async Task<ActionResult<List<OrderedMeetingTimesDto>>> GetOrderedMeetingTimes(long slotId)
        {
            return Ok(await _meetingService.GetOrderedMeetingTimesAsync(slotId));
        }

        [HttpGet]
        [Route("getTeamMembersOfCurrentUser/{teamId?}")]
        public async Task<ActionResult<ICollection<NewMeetingMemberDto>>> GetTeamMembersOfCurrentUser(long? teamId)
        {
            var teamMembers = await _teamService.GetTeamMembersOfCurrentUserAsync(teamId);
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
