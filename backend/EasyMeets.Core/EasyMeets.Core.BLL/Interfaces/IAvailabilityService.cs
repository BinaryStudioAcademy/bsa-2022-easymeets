using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        public Task<ICollection<AvailabilitySlotDto>> GetAllAvailabilitySlotsForTeamAsync();
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
