using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
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
        private readonly IEmailSenderService _emailSender;
        private readonly IGoogleMeetService _googleMeetService;
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IZoomService zoomService, IEmailSenderService emailSender, IGoogleMeetService googleMeetService) : base(context, mapper)
        {
            _userService = userService;
            _zoomService = zoomService;
            _emailSender = emailSender;
            _googleMeetService = googleMeetService;
        }

        public async Task<List<MeetingSlotDTO>> GetMeetingMembersByNumberOfMembersToDisplayAsync(MeetingMemberRequestDto meetingMemberRequestDto)
        {
            var teamId = meetingMemberRequestDto.TeamId;
            if (teamId is null)
            {
                return new List<MeetingSlotDTO>();
            }

            var team = await _context.Teams.FirstOrDefaultAsync(team => team.Id == teamId) ?? throw new KeyNotFoundException("Team doesn't exist");

            var meetings = _context.Meetings
                .Where(meeting => meeting.TeamId == team.Id)
                .Include(m => m.AvailabilitySlot)
                .Include(s => s!.ExternalAttendees)
                .Include(meeting => meeting.MeetingMembers)
                    .ThenInclude(meetingMember => meetingMember.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .AsEnumerable()
                .Where(meeting => meeting.StartTime.Date == meetingMemberRequestDto.Date.Date)
                .Select(x =>
                    new MeetingSlotDTO
                    {
                        Id = x.Id,
                        LocationType = x.LocationType,
                        MeetingCount = x.MeetingMembers.Count,
                        MembersTitle = CreateMemberTitle(x),
                        MeetingTitle = x.Name,
                        MeetingRoom = x.MeetingRoom,
                        MeetingDuration = x.Duration,
                        MeetingTime = x.StartTime,
                        MeetingLink = x.MeetingLink,
                        MeetingMembers = GetAllParticipants(x, meetingMemberRequestDto.NumberOfMembersToDisplay)
                    })
            .ToList();

            return meetings;
        }

        private static List<UserMeetingDTO> GetAllParticipants(Meeting meeting, int numberOfMembers)
        {
            var slotMembers = meeting.MeetingMembers
                .Select(x => new UserMeetingDTO
                {
                    Name = x.TeamMember.User.Name,
                    Email = x.TeamMember.User.Email,
                    TimeZone = new() { NameValue = x.TeamMember.User.TimeZoneName, TimeValue = x.TeamMember.User.TimeZoneValue },
                    Booked = meeting.CreatedAt
                });

            var external = meeting.ExternalAttendees
                .Select(x => new UserMeetingDTO
                {
                    Name = x.Name,
                    Email = x.Email,
                    TimeZone = new() { NameValue = x.TimeZoneName, TimeValue = x.TimeZoneValue },
                    Booked = meeting.CreatedAt
                });

            return slotMembers.Union(external).Take(numberOfMembers).ToList();
        }

        private static string CreateMemberTitle(Meeting meeting)
        {
            return meeting.MeetingMembers.Count() switch
            {
                0 => "Empty meeting.",
                1 => meeting.MeetingMembers.First().TeamMember.User.Name,
                _ => $"{meeting.MeetingMembers.Count()} Team Members"
            };
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

        public async Task<SaveMeetingDto> CreateMeeting(SaveMeetingDto meetingDto)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var meetingMembers = await GetMeetingMembers(meetingDto.MeetingMembers, meetingDto.TeamId);

            var meeting = _mapper.Map<Meeting>(meetingDto, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.CreatedBy = currentUser.Id;
                    dest.MeetingMembers = meetingMembers;
                })
            );

            await _context.Meetings.AddAsync(meeting);

            await _context.SaveChangesAsync();

            await AddMeetingLink(meeting);

            await SendConfirmationEmailsAsync(meeting.Id);

            return _mapper.Map<SaveMeetingDto>(GetByIdInternal(meeting.Id));
        }

        public async Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto)
        {
            var meeting = _mapper.Map<Meeting>(meetingDto);

            await _context.Meetings.AddAsync(meeting);

            await _context.SaveChangesAsync();

            await AddMeetingLink(meeting);

            return meeting.Id;
        }

        public async Task<List<OrderedMeetingTimesDto>> GetOrderedMeetingTimesAsync(long slotId)
        {
            return await _context.Meetings.Where(el => el.AvailabilitySlotId == slotId)
                .Select(el => new OrderedMeetingTimesDto { StartTime = el.StartTime })
                .ToListAsync();
        }

        public async Task SendConfirmationEmailsAsync(long meetingId)
        {
            var meeting = await _context.Meetings
                .Include(m => m.MeetingMembers)
                    .ThenInclude(member => member.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .Include(m => m.ExternalAttendees)
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(slot => slot!.EmailTemplates)
                .FirstOrDefaultAsync(m => m.Id == meetingId);

            var emailTemplate = meeting?
                .AvailabilitySlot?
                .EmailTemplates
                .FirstOrDefault(template => template.TemplateType == TemplateType.Confirmation);

            var recipients = meeting?
                .MeetingMembers
                .Select(meetingMember => meetingMember.TeamMember.User.Email)
                .Concat(meeting.ExternalAttendees.Select(attendee => attendee.Email))
                .ToList();

            if (emailTemplate is null || recipients is null || !recipients.Any())
            {
                return;
            }

            var emailDto = _mapper.Map<EmailDto>(emailTemplate);

            foreach (var recipient in recipients)
            {
                emailDto.Recipient = recipient;

                _emailSender.Send(emailDto);
            }
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
                    await _googleMeetService.CreateGoogleMeet(meeting.Id);
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
                    .ThenInclude(mm => mm.TeamMember)
                    .ThenInclude(tm => tm.User)
                .FirstOrDefault(m => m.Id == id) ?? throw new KeyNotFoundException("Invalid meeting id");
        }

        public async Task DeleteMeeting(long meetingId)
        {
            var meeting = await _context.Meetings.FirstAsync(meeting => meeting.Id == meetingId);
            var members = _context.MeetingMembers.Where(member => member.MeetingId == meetingId);
            _context.RemoveRange(members);
            _context.Remove(meeting);

            await _context.SaveChangesAsync();
        }
    }
}
