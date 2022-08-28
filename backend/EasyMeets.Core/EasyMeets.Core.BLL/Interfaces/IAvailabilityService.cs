using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id);
        Task CreateAvailabilitySlot(SaveAvailabilitySlotDto slotDto);
        Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id);
        Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id, SaveAvailabilitySlotDto updateAvailabilityDto);
        Task<bool> UpdateAvailabilitySlotEnablingAsync(long id);
        Task DeleteAvailabilitySlot(long slotId);
    }
}
