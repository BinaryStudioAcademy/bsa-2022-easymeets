using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync(long id);
        Task<ICollection<AvailabilitySlotDto>> GetAllUserAvailabilitySlotsAsync(long id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
