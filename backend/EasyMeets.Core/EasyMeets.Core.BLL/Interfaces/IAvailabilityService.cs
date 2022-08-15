using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
        Task DeleteAvailabilitySlot(long slotId);
    }
}
