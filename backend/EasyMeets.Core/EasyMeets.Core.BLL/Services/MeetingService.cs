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

        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync()
        {
            var meetings = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(s => s.ExternalAttendees)
                .Include(meeting => meeting.SlotMembers)
                    .ThenInclude(teammeat => teammeat.User)
                .ToListAsync();

            var mapped = _mapper.Map<List<MeetingThreeMembersDTO>>(meetings);
            ConvertTimeZone(ref mapped);

            return mapped;
        }

        private void ConvertTimeZone(ref List<MeetingThreeMembersDTO> meetings)
        {
            foreach (var user in meetings.SelectMany(x => x.MeetingMembers ?? new List<UserMeetingDTO>()))
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
