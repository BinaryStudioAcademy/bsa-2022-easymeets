using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.AvailabilitySlotsResponse;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
        Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id);
        Task<AvailabilitySlotsResponseDto> GetAvailabilitySlotsResponseDto();
    }
}
