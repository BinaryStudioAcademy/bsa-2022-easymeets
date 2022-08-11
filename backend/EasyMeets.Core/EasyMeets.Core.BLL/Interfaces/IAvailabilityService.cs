using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync(int id);
        Task<ICollection<AvailabilitySlotDto>> GetAllUserAvailabilitySlotsAsync(int id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
