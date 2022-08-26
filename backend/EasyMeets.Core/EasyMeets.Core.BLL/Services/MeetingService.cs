using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        private readonly IUserService _userService;
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
        }

        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync()
        {
            var meetings = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(s => s!.ExternalAttendees)
                .Include(meeting => meeting.SlotMembers)
                    .ThenInclude(teammeat => teammeat.User)
                .ToListAsync();

            var mapped = _mapper.Map<List<MeetingThreeMembersDTO>>(meetings);
            ConvertTimeZone(ref mapped);

            return mapped;
        }

        public async Task<List<UserMeetingDTO>> GetAllMembers(int id)
        {
            var meeting = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(s => s!.ExternalAttendees)
                .Include(meeting => meeting.SlotMembers)
                    .ThenInclude(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id) ?? throw new KeyNotFoundException("No meeting found");

            var members = _mapper.Map<List<UserMeetingDTO>>(meeting.SlotMembers.Select(s => s.User));

            if (meeting.AvailabilitySlot is not null)
            {
                members = members.Union(_mapper.Map<List<UserMeetingDTO>>(meeting.AvailabilitySlot.ExternalAttendees)).ToList();
            }

            return members;
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

        public async Task CreateMeeting(SaveMeetingDto meetingDto)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var teamId = await _context.TeamMembers
                .Where(x => x.UserId == currentUser.Id)
                .Select(x => x.Team.Id)
                .FirstOrDefaultAsync();

            var meeting = _mapper.Map<Meeting>(meetingDto, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.CreatedBy = currentUser.Id;
                    dest.CreatedAt = DateTime.Now;
                    dest.TeamId = teamId;
                })
            );

            await _context.Meetings.AddAsync(meeting);

            var slotMembers = _mapper.Map<ICollection<SlotMember>>(meetingDto.MeetingMembers, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.Select(x => x.EventId = meeting.Id);
                    dest.Select(x => x.Priority = default(int));
                    dest.Select(x => x.ScheduleId = default(long)); 
                }));

            await _context.SlotMembers.AddRangeAsync(slotMembers);

            await _context.SaveChangesAsync();
        }
    }
}
