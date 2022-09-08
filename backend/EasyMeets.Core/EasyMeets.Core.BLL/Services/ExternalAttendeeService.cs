using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services;

public class ExternalAttendeeService : BaseService, IExternalAttendeeService
{
    private readonly IMeetingService _meetingService;

    public ExternalAttendeeService(EasyMeetsCoreContext context, IMapper mapper, IMeetingService meetingService) : base(
        context, mapper)
    {
        _meetingService = meetingService;
    }

    public async Task SaveExternalAttendeeAsync(ExternalAttendeeAndBookedMeetingDto bookingDto)
    {
        var meetingId = await _meetingService.CreateExternalAttendeeMeeting(bookingDto.Meeting);
        
        var attendee = _mapper.Map<ExternalAttendee>(bookingDto.Attendee);
        attendee.MeetingId = meetingId;
        await _context.ExternalAttendees.AddAsync(attendee);
        await _context.SaveChangesAsync();

        await _meetingService.SendConfirmationEmailsAsync(meetingId);
    }
}