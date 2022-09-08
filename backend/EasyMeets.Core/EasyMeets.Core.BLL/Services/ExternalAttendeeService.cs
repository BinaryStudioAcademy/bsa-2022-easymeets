using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

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
    }

    public async Task<ExternalAttendeeBookingInfoDto> GetOrganizerAndPersonalSlotsAsync(string personalUrl)
    {
        var user = await _context.Users.Include(u => u.CreatedSlots).FirstOrDefaultAsync(u => u.PersonalUrl == personalUrl)
            ?? throw new KeyNotFoundException("User doesn't exist");

        var infoDto = new ExternalAttendeeBookingInfoDto
        {
            User = _mapper.Map<ExternalUserDto>(user),
            PersonalSlots = _mapper.Map<List<ExternalAvailabilitySlotDto>>(user.CreatedSlots.Where(el => el.IsEnabled))
        };

        return infoDto;
    }

    public async Task<ExternalUserDto> GetOrganizerBySlotLinkAsync(string slotLink)
    {
        var slot = await _context.AvailabilitySlots.Include(s => s.Author)
            .FirstOrDefaultAsync(s => s.Link == slotLink) ?? throw new KeyNotFoundException("Availability Slot doesn't exist");

        return _mapper.Map<ExternalUserDto>(slot.Author);
    }
}