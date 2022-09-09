using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IExternalAttendeeService
{
    Task SaveExternalAttendeeAsync(ExternalAttendeeAndBookedMeetingDto bookingDto);
    Task<ExternalAttendeeBookingInfoDto> GetOrganizerAndPersonalSlotsAsync(string personalUrl);
    Task<ExternalUserDto> GetOrganizerBySlotLinkAsync(string slotLink);
}