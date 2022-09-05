using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        private readonly IUserService _userService;
        private readonly IZoomService _zoomService;
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IZoomService zoomService) : base(context, mapper)
        {
            _userService = userService;
            _zoomService = zoomService;
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

            await AddMeetingLink(meeting);
            
            return _mapper.Map<SaveMeetingDto>(GetByIdInternal(meeting.Id));
        }

        private async Task<ICollection<MeetingMember>> GetMeetingMembers(List<NewMeetingMemberDto> meetingMembers, long teamId)
        {
            var usersIds = meetingMembers.Select(x => x.Id);
            var teamMembers = await _context.TeamMembers
                .Where(x => usersIds.Contains(x.UserId) && x.TeamId == teamId)
                .Select(x => new MeetingMember { TeamMemberId = x.Id })
                .ToListAsync();

            return teamMembers;
        }

        private async Task AddMeetingLink(Meeting meeting)
        {
            switch (meeting.LocationType)
            {
                case LocationType.Zoom:
                    await _zoomService.CreateZoomMeeting(meeting.Id);
                    break;
                case LocationType.GoogleMeet:
                    break;
                case LocationType.Office:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private Meeting GetByIdInternal(long id)
        {
            return _context.Meetings
                .Include(m => m.MeetingMembers)
                .FirstOrDefault(m => m.Id == id) ?? throw new KeyNotFoundException("Invalid meeting id");
        }
    }
}
