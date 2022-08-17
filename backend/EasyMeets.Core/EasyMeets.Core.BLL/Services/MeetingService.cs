using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<List<Meeting>> GetMeetingsAsync()
        {
            var meetings = await _context.Meetings.ToListAsync();

            return meetings;
        }
    }
}
