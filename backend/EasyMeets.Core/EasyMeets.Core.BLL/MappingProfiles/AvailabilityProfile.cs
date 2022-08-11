using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class AvailabilityProfile : Profile
    {
        public AvailabilityProfile()
        {
            CreateMap<AvailabilitySlot, AvailabilitySlotDto>();
            CreateMap<AvailabilitySlotDto, AvailabilitySlot>();
        }
    }
}
