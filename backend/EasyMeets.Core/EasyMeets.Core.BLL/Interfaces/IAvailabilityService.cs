using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task<UserPersonalAndTeamSlots> GetUserPersonalAndTeamSlotsAsync(long id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
