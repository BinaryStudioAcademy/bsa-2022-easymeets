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
           //TODO
            // var meetings = await _context.Meetings
            // .Include(meeting => meeting.SlotMembers)
            //.ThenInclude(teammeat => teammeat.User)

            var meetings = await _context.Meetings 
            .Include(meeting => meeting.MeetingMembers)
                .ThenInclude(meetingMember => meetingMember.TeamMember)
                .ThenInclude(teamMember => teamMember.User)
            .ToListAsync();

            var mapped = _mapper.Map<List<MeetingThreeMembersDTO>>(meetings);
            ConvertTimeZone(mapped);

            return mapped;
        }

        private void ConvertTimeZone(List<MeetingThreeMembersDTO> meetings)
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
