using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Email;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services
{
    public class MeetingService : BaseService, IMeetingService
    {
        private readonly IUserService _userService;
        private readonly IZoomService _zoomService;
        private readonly IEmailSenderService _emailSender;
        private readonly IGoogleMeetService _googleMeetService;
        private readonly IGoogleOAuthService _googleOAuthService;
        private readonly ICalendarsService _calendarsService;
        private readonly IConfiguration _configuration;
        public MeetingService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IZoomService zoomService,
            IEmailSenderService emailSender, IGoogleMeetService googleMeetService, IGoogleOAuthService googleOAuthService,
            ICalendarsService calendarsService, IConfiguration configuration) : base(context, mapper)
        {
            _userService = userService;
            _zoomService = zoomService;
            _emailSender = emailSender;
            _googleMeetService = googleMeetService;
            _googleOAuthService = googleOAuthService;
            _calendarsService = calendarsService;
            _configuration = configuration;
        }

        public async Task<List<MeetingSlotDTO>> GetMeetingsAsync(MeetingMemberRequestDto meetingMemberRequestDto)
        {
            var teamId = meetingMemberRequestDto.TeamId;
            if (teamId is null)
            {
                return new List<MeetingSlotDTO>();
            }

            var team = await _context.Teams.FirstOrDefaultAsync(team => team.Id == teamId) ?? throw new KeyNotFoundException("Team doesn't exist");

            var startRestriction = meetingMemberRequestDto.Start ?? DateTimeOffset.MinValue;
            var endRestriction = meetingMemberRequestDto.End ?? DateTimeOffset.MaxValue;

            var meetings = await _context.Meetings
                .Include(m => m.AvailabilitySlot)
                .Include(s => s.ExternalAttendees)
                .Include(meeting => meeting.MeetingMembers)
                    .ThenInclude(meetingMember => meetingMember.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .Where(meeting => meeting.TeamId == team.Id &&
                                  meeting.StartTime >= startRestriction &&
                                  meeting.StartTime.AddMinutes(meeting.Duration) <= endRestriction)
                .OrderBy(m => m.StartTime)
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
                        MeetingMembers = GetAllParticipants(x)
                    })
            .ToListAsync();

            return meetings;
        }

        private static List<UserMeetingDTO> GetAllParticipants(Meeting meeting)
        {
            var slotMembers = meeting.MeetingMembers
                .Select(x => new UserMeetingDTO
                {
                    Name = x.TeamMember.User.Name,
                    Email = x.TeamMember.User.Email,
                    Image = x.TeamMember.User.ImagePath,
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

            return slotMembers.Union(external).ToList();
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

        public async Task<List<UserMeetingDTO>> GetAllMembers(long id)
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

            await SendEmailsAsync(meeting.Id, TemplateType.Confirmation);

            await AddMeetingToMembersVisibleCalendars(meetingDto);

            return _mapper.Map<SaveMeetingDto>(GetByIdInternal(meeting.Id));
        }

        public async Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto)
        {
            var meeting = _mapper.Map<Meeting>(meetingDto);

            await _context.Meetings.AddAsync(meeting);
            await _context.SaveChangesAsync();
            
            var organizer = await _context.TeamMembers.FirstOrDefaultAsync(el => el.UserId == meeting.CreatedBy) 
                            ?? throw new KeyNotFoundException("Team member not found");

            await _context.MeetingMembers.AddAsync(new MeetingMember { TeamMemberId = organizer.Id, MeetingId = meeting.Id });
            await _context.SaveChangesAsync();
            
            var calendar = await _context.Calendars.FirstOrDefaultAsync(el => el.UserId == meeting.CreatedBy && el.AddEventsFromTeamId == meeting.TeamId);

            if (calendar is not null)
            {
                await _calendarsService.AddMeetingsToCalendar(meeting.TeamId, calendar.ConnectedCalendar);
            }

            await AddMeetingLink(meeting);

            return meeting.Id;
        }

        public async Task<List<OrderedMeetingTimesDto>> GetOrderedMeetingTimesAsync(long slotId)
        {
            return await _context.Meetings.Where(el => el.AvailabilitySlotId == slotId)
                .Select(el => new OrderedMeetingTimesDto { StartTime = el.StartTime })
                .ToListAsync();
        }

        public async Task SendEmailsAsync(long meetingId, TemplateType type)
        {
            var meeting = await _context.Meetings
                .Include(m => m.Author)
                .Include(m => m.MeetingMembers)
                    .ThenInclude(member => member.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .Include(m => m.ExternalAttendees)
                .Include(m => m.AvailabilitySlot)
                    .ThenInclude(slot => slot!.EmailTemplates)
                .FirstOrDefaultAsync(m => m.Id == meetingId);

            var recipients = meeting?
                .MeetingMembers
                .Select(meetingMember => meetingMember.TeamMember.User.Email)
                .Concat(meeting.ExternalAttendees.Select(attendee => attendee.Email))
                .ToList();

            if (recipients is null || !recipients.Any() || meeting is null)
            {
                return;
            }

            var emailTemplate = meeting
                .AvailabilitySlot?
                .EmailTemplates
                .FirstOrDefault(template => template.TemplateType == type && template.IsSend);

            foreach (var recipient in recipients)
            {
                var emailDto = GenerateEmailTemplate(meeting, recipient, type, emailTemplate);

                emailDto.Recipient = recipient;

                _emailSender.Send(emailDto);
            }
        }

        private async Task<ICollection<MeetingMember>> GetMeetingMembers(List<NewMeetingMemberDto> meetingMembers, long teamId)
        {
            var usersIds = meetingMembers.Select(x => x.Id);
            var teamMembers = await _context.TeamMembers
                .Where(x => usersIds.Contains(x.Id) && x.TeamId == teamId)
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
            await SendEmailsAsync(meetingId, TemplateType.Cancellation);
            
            var meeting = await _context.Meetings.FirstAsync(meeting => meeting.Id == meetingId);
            await CancelMeetingsInCalendars(meeting);
            var members = _context.MeetingMembers.Where(member => member.MeetingId == meetingId);
            _context.RemoveRange(members);
            _context.Remove(meeting);

            await _context.SaveChangesAsync();
        }
        
        private async Task CancelMeetingsInCalendars(Meeting meeting)
        {
            var recipients = meeting
                .MeetingMembers
                .Select(meetingMember => meetingMember.TeamMember.User.Email);

            foreach (var recipient in recipients)
            {
                var user = await _context.Users.FirstOrDefaultAsync(el => el.Email == recipient);
                
                if (user is not null)
                {
                    var calendar = await _context.Calendars.FirstOrDefaultAsync(el => el.AddEventsFromTeamId == meeting.TeamId && el.UserId == user.Id);
                    if (calendar is not null)
                    {
                        await _calendarsService.CancelMeetingInGoogleCalendar(meeting.Name, calendar);
                    }
                }
            }
        }

        private MeetingEmailTemplateDto GenerateEmailParameters(Meeting meeting, string invitee)
        {
            return new MeetingEmailTemplateDto
            {
                MeetingName = meeting.Name,
                StartTime = meeting.StartTime,
                LocationType = meeting.LocationType,
                AuthorName = meeting.Author.Name,
                AuthorEmail = meeting.Author.Email,
                MeetingLink = meeting.MeetingLink,
                MemberName = invitee,
                Uri = _configuration["ApplicationUri"],
            };
        }

        private EmailDto GenerateNewMeetingEmailTemplate(MeetingEmailTemplateDto parameters)
        {
            return new EmailDto
            {
                Subject = $"New Event: {parameters.MeetingName} - {parameters.StartTime} - {parameters.LocationType}",
                Body = $"Hi, {parameters.MemberName}!\n\n" +
                "A new event has been scheduled.\n" +
                $"Event Type: {parameters.LocationType}\n" +
                $"Invitee: {parameters.AuthorName}\n" +
                $"Invitee Email: {parameters.AuthorEmail}\n" +
                $"Event Date/Time: {parameters.StartTime}\n\n" +
                $"View event in Easymeets: {parameters.Uri}{parameters.MeetingLink}"
            };
        }
        
        private EmailDto GenerateCancelledMeetingTemplate(MeetingEmailTemplateDto parameters)
        {
            return new EmailDto
            {
                Subject = $"Cancelled: {parameters.LocationType} with {parameters.AuthorName} on {parameters.StartTime.Date}",
                Body = $"Hi, {parameters.MemberName},\n\n" +
                "The event below has been canceled.\n" +
                $"Invitee: {parameters.AuthorName}\n" +
                $"Invitee Email: {parameters.AuthorEmail}\n" +
                $"Event Date/Time: {parameters.StartTime}\n\n" +
                $"Cancelled by: {parameters.AuthorName}"
            };
        }

        private EmailDto GenerateEmailTemplate(Meeting meeting, string invitee, TemplateType type, EmailTemplate? emailTemplate)
        {
            var emailParameters = GenerateEmailParameters(meeting, invitee);
            if (emailTemplate is not null)
            {
                return _mapper.Map<EmailDto>(emailTemplate);
            }

            return type switch
            {
                TemplateType.Confirmation => GenerateNewMeetingEmailTemplate(emailParameters),
                TemplateType.Cancellation => GenerateCancelledMeetingTemplate(emailParameters),
                _ => new EmailDto()
            };
        }

        private async Task AddMeetingToMembersVisibleCalendars(SaveMeetingDto meeting)
        {
            var visibleCalendars = await _context.CalendarVisibleForTeams
                .Include(g => g.Calendar)
                .Where(x => x.TeamId == meeting.TeamId).ToListAsync();

            foreach (var calendar in visibleCalendars)
            {
                var tokenResultDto = await _googleOAuthService.RefreshToken(calendar.Calendar.RefreshToken);

                if (tokenResultDto is not null)
                {
                    await _calendarsService.AddMeetingToCalendar(_mapper.Map<SaveMeetingDto>(meeting), tokenResultDto);
                }
            }
        }
    }
}
