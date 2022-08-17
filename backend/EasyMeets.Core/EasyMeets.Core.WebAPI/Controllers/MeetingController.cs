using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    //[Authorize]
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
        public async Task<List<Meeting>> GetAllMeetingsAsync()
        {
            var samples = await _meetingService.GetMeetingsAsync();

            return samples;
        }
    }
}
