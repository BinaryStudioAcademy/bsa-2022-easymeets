using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
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

        public async Task<MeetingSlotDTO> GetMeetingByIdAsync(long id)
        {
            var meeting = await _context.Meetings
                .Include(m => m.ExternalAttendees)
                .Include(m => m.MeetingMembers)
                    .ThenInclude(meetingMember => meetingMember.TeamMember)
                    .ThenInclude(teamMember => teamMember.User)
                .FirstOrDefaultAsync(m => m.Id == id) ?? throw new KeyNotFoundException($"Meeting with id {id} does not exist");

            var meetingDto = _mapper.Map<MeetingSlotDTO>(meeting);

            meetingDto.MembersTitle = CreateMemberTitle(meetingDto);
            
            return meetingDto;
        }

        public async Task<SaveMeetingDto> UpdateMeetingAsync(SaveUpdateMeetingDto updateMeetingDto)
        {
            var meeting = GetByIdInternal(updateMeetingDto.Id) ?? throw new KeyNotFoundException($"The meeting with {updateMeetingDto.Id} id not found");

            var meetingMembers = await GetMeetingMembers(updateMeetingDto.MeetingMembers, updateMeetingDto.TeamId);

            _mapper.Map(updateMeetingDto, meeting, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.MeetingMembers = meetingMembers;
                })
            );

            _context.Meetings.Update(meeting);

            await _context.SaveChangesAsync();

            return _mapper.Map<SaveMeetingDto>(meeting);
        }

        public async Task<List<MeetingSlotDTO>> GetMeetingsAsync(MeetingMemberRequestDto meetingMemberRequestDto)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
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
                                  meeting.MeetingMembers.Any(member => member.TeamMember.UserId == currentUser.Id) &&
                                  meeting.StartTime >= startRestriction &&
                                  meeting.StartTime.AddMinutes(meeting.Duration) <= endRestriction)
                .OrderBy(m => m.StartTime)
                .ToListAsync();

            var meetingsDto = _mapper.Map<IEnumerable<MeetingSlotDTO>>(meetings)
                .Select(dto =>
                {
                    dto.MembersTitle = CreateMemberTitle(dto);
                    
                    return dto;
                })
                .ToList();

            return meetingsDto;
        }

        private static string CreateMemberTitle(MeetingSlotDTO meeting)
        {
            return meeting.MeetingMembers?.Count switch
            {
                0 => "Empty meeting.",
                1 => meeting.MeetingMembers.First().Name ?? string.Empty,
                _ => $"{meeting.MeetingMembers?.Count} Team Members"
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

            await SendEmailsAsync(meeting.Id, TemplateType.Confirmation);

            await AddMeetingToMembersVisibleCalendars(meetingDto);

            return _mapper.Map<SaveMeetingDto>(GetByIdInternal(meeting.Id));
        }

        public async Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto)
        {
            var members = await GetFromSlotMembers(meetingDto.Members, meetingDto.TeamId);
            var meeting = _mapper.Map<Meeting>(meetingDto, opts =>
                opts.AfterMap((_, dest) =>
                {
                    dest.MeetingMembers = members;
                }));

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

        public async Task SendEmailsAsync(long meetingId, TemplateType type)
        {
            var emailDto = new EmailDto();

            var meeting = await _context.Meetings
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

            var emailTemplate = meeting?
                .AvailabilitySlot?
                .EmailTemplates
                .FirstOrDefault(template => template.TemplateType == type && template.IsSend);

            foreach (var recipient in recipients)
            {
                emailDto = GenerateEmailTemplate(meeting, recipient, emailTemplate);

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

        private Task<List<MeetingMember>> GetFromSlotMembers(List<SlotMemberDto> slotMembers, long teamId)
        {
            var memberIds = slotMembers.Select(x => x.MemberId);
            return _context.TeamMembers
                .Where(x => memberIds.Contains(x.UserId) && x.TeamId == teamId)
                .Select(x => new MeetingMember { TeamMemberId = x.Id })
                .ToListAsync();
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
            var members = _context.MeetingMembers.Where(member => member.MeetingId == meetingId);
            _context.RemoveRange(members);
            _context.Remove(meeting);

            await _context.SaveChangesAsync();
        }

        private MeetingEmailTemplateDto GenerateEmailParameters(Meeting meeting, string invitee)
        {
            return new MeetingEmailTemplateDto()
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
            return new EmailDto()
            {
                Subject = $"New Event: {parameters.MeetingName} - {parameters.StartTime} - {parameters.LocationType}",
                Body = $"Hi, {parameters.MemberName}!\n\n" +
                $"A new event has been scheduled.\n" +
                $"Event Type: {parameters.LocationType}\n" +
                $"Invitee: {parameters.AuthorName}\n" +
                $"Invitee Email: {parameters.AuthorEmail}\n" +
                $"Event Date/Time: {parameters.StartTime}\n\n" +
                $"View event in Easymeets: {parameters.Uri}{parameters.MeetingLink}"
            };
        }

        private EmailDto GenerateEmailTemplate(Meeting meeting, string invitee, EmailTemplate? emailTemplate)
        {
            var emailParameters = GenerateEmailParameters(meeting, invitee);
            if (emailTemplate is not null)
            {
                return _mapper.Map<EmailDto>(emailTemplate);
            }
            else
            {
                return GenerateNewMeetingEmailTemplate(emailParameters);
            }
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
