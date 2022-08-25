using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Meeting;
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

        public MeetingController(IMeetingService meetingService)
        {
            _meetingService = meetingService;
        }

        [HttpGet]
        [Route("GetThreeMeetingMembers")]
        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync() => await _meetingService.GetThreeMeetingMembersAsync();

        [HttpGet("{id:int}/members/all")]
        public async Task<ActionResult<List<UserMeetingDTO>>> GetAllMembers(int id)
        {
            return Ok(await _meetingService.GetAllMembers(id));
        }

    }
}
