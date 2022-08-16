using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
        Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id);
        Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id, UpdateAvailabilityDto updateAvailabilityDto);
    }
}
