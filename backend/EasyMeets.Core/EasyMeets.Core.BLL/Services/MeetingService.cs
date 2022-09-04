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

        public async Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync(long? teamId)
        {
            if (teamId is null)
            {
                return new List<MeetingThreeMembersDTO>();
            }

            var team = await _context.Teams.FirstOrDefaultAsync(team => team.Id == teamId) ?? throw new KeyNotFoundException("Team doesn't exist");

            var meetings = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(s => s!.ExternalAttendees)
                .Include(meeting => meeting.MeetingMembers)
                    .ThenInclude(meetingMember => meetingMember.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .Where(meeting => meeting.TeamId == team.Id)
                .ToListAsync();

            var mapped = _mapper.Map<List<MeetingThreeMembersDTO>>(meetings);
            ConvertTimeZone(mapped);
            return mapped;
        }

        public async Task<List<UserMeetingDTO>> GetAllMembers(int id)
        {
            var meeting = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(s => s!.ExternalAttendees)
                .Include(meeting => meeting.MeetingMembers)
                    .ThenInclude(meetingMember => meetingMember.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .FirstOrDefaultAsync(m => m.Id == id) ?? throw new KeyNotFoundException("No meeting found");

            var members = _mapper.Map<List<UserMeetingDTO>>(meeting.MeetingMembers.Select(s => s.TeamMember.User));

            if (meeting.AvailabilitySlot is not null)
            {
                members = members.Union(_mapper.Map<List<UserMeetingDTO>>(meeting.AvailabilitySlot.ExternalAttendees)).ToList();
            }

            return members;
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
        public async Task CreateMeeting(SaveMeetingDto meetingDto)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var teamId = await _context.TeamMembers
                .Where(x => x.UserId == currentUser.Id)
                .Select(x => x.Team.Id)
                .FirstOrDefaultAsync();

            var meetingMembers = await GetMeetingMembers(meetingDto.MeetingMembers, teamId);

            var meeting = _mapper.Map<Meeting>(meetingDto, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.CreatedBy = currentUser.Id;
                    dest.TeamId = teamId;
                    dest.MeetingMembers = meetingMembers;
                })
            );

            await _context.Meetings.AddAsync(meeting);

            await _context.SaveChangesAsync();
        }

        private async Task<ICollection<MeetingMember>> GetMeetingMembers(List<NewMeetingMemberDto> meetingMembers, long teamId)
        {
            var usersIds = meetingMembers.Select(x => x.Id).ToList();
            var teamMembers = await _context.TeamMembers
                .Where(x => usersIds.Contains(x.UserId) && x.TeamId == teamId)
                .Select(x => new MeetingMember { TeamMemberId = x.Id })
                .ToListAsync();

            return teamMembers;
        }
    }
}
