using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class AvailabilityProfile : Profile
{
    public AvailabilityProfile()
    {
        CreateMap<NewAdvancedSlotSettingsDto, AdvancedSlotSettings>();
        CreateMap<NewAvailabilitySlotDto, AvailabilitySlot>();
    }
}