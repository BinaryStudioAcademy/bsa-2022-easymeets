using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        public Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync();
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
