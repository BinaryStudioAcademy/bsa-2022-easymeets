using EasyMeets.Core.Common.DTO.Availability; 

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        public Task<ICollection<AvailabilitySlotDto>> GetAllAvailabilitySlotsAsync();
    }
}
