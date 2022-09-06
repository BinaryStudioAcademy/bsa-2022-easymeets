using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services;

public class ExternalAttendeeService : BaseService, IExternalAttendeeService
{
    public ExternalAttendeeService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task SaveExternalAttendeeAsync(ExternalAttendeeAndBookedMeetingDto bookingDto)
    {
        var meeting = _mapper.Map<Meeting>(bookingDto.Meeting);
        var createdMeeting = _context.Meetings.Add(meeting).Entity;
        await _context.SaveChangesAsync();
        
        var attendee = _mapper.Map<ExternalAttendee>(bookingDto.Attendee);
        attendee.MeetingId = createdMeeting.Id;
        await _context.ExternalAttendees.AddAsync(attendee);
        await _context.SaveChangesAsync();
    }
}