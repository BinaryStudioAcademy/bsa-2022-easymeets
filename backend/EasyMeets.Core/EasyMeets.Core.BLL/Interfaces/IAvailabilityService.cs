using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
