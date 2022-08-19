using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<List<MeetingBookingsDTO>> GetThreeMeetingsForBookingsAsync()
        {
            var meetings = await _context.Meetings.
            Include(meeting => meeting.TeamMeetings).
            ThenInclude(teammeat => teammeat.User).
            ToListAsync();

            var mapped = _mapper.Map<List<MeetingBookingsDTO>>(meetings);
            ConvertTimeZone(ref mapped);

            return mapped;
        }

        private void ConvertTimeZone(ref List<MeetingBookingsDTO> meetings)
        {
            foreach (var meeting in meetings)
            {
                foreach (var user in meeting.MeetingMembers)
                {
                    switch (user.TimeZone)
                    {
                        case "0":
                            user.TimeZone = "Eastern Europe (GMT -0:00)";
                            break;
                    }
                }
            }
        }
    }
}
