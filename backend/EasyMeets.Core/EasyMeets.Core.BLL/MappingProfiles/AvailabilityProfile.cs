using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class AvailabilityProfile : Profile
    {
        public AvailabilityProfile()
        {
            CreateMap<AvailabilitySlot, AvailabilitySlotDto>()
                .ForMember(dest => dest.Members,opt=> opt.MapFrom(src => src.Members.Select(x=>x.User)));
            CreateMap<AvailabilitySlotDto, AvailabilitySlot>();
            CreateMap<NewAdvancedSlotSettingsDto, AdvancedSlotSettings>();
            CreateMap<NewAvailabilitySlotDto, AvailabilitySlot>();
        }
    }
} 