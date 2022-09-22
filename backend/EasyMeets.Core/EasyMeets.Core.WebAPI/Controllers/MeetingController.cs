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

        [HttpPost("GetThreeMeetingMembers")]
        public async Task<List<MeetingSlotDTO>> GetMeetingMembersByCountAsync(MeetingMemberRequestDto meetingMemberRequestDto) =>
            await _meetingService.GetMeetingsAsync(meetingMemberRequestDto);

        [HttpGet("{id:long}/members/all")]
        public async Task<ActionResult<List<UserMeetingDTO>>> GetAllMembers(long id)
        {
            return Ok(await _meetingService.GetAllMembers(id));
        }

        [HttpGet]
        [Route("getTeamMembersByName/{searchName}/{teamId?}")]
        public async Task<ActionResult<ICollection<NewMeetingMemberDto>>> GetTeamMembersByName(string searchName, long? teamId)
        {
            return Ok(await _teamService.GetTeamMembersByNameAsync(searchName, teamId));
        }
        
        [HttpGet]
        [Route("getTeamMembersById/{userId}/{teamId}")]
        public async Task<ActionResult<NewMeetingMemberDto>> GetTeamMembersByName(long userId, long teamId)
        {
            return Ok(await _teamService.GetTeamMembersByIdAsync(userId, teamId));
        }

        [HttpGet("getTeamMembers/{teamId:long}/{count:int}")]
        public async Task<ActionResult<ICollection<NewMeetingMemberDto>>> GetTeamMembers(long teamId, int count)
        {
            return Ok(await _teamService.GetNewTeamMembersAsync(teamId, count));
        }
        
        [HttpGet("ordered-times/{slotId}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<OrderedMeetingTimesDto>>> GetOrderedMeetingTimes(long slotId)
        {
            return Ok(await _meetingService.GetOrderedMeetingTimesAsync(slotId));
        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<MeetingSlotDTO>> GetMeetingById(long id)
        {
            var result = await _meetingService.GetMeetingByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SaveMeetingDto>> SaveNewMeeting([FromBody] SaveMeetingDto newMeetingDto)
        {
            return Ok(await _meetingService.CreateMeeting(newMeetingDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMeeting([FromBody] SaveUpdateMeetingDto meeting)
        {
            return Ok(await _meetingService.UpdateMeetingAsync(meeting));
        }

        [HttpDelete]
        [Route("{meetingId}")]
        public async Task<ActionResult<SaveMeetingDto>> DeleteMeeting(long meetingId)
        {
            await _meetingService.DeleteMeeting(meetingId);
            return NoContent();
        }
    }
}
