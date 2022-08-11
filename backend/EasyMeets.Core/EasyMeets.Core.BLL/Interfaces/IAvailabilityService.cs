using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        public Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync(int id);
        public Task<ICollection<AvailabilitySlotDto>> GetAllUserAvailabilitySlotsAsync(int id);
        public Task<UserDto> GetCurrentUserForAvailabilityPageAsync(int id);
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
