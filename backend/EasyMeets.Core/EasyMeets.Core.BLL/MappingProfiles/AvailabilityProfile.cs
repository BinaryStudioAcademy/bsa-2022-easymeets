using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class AvailabilityProfile : Profile
{
    public AvailabilityProfile()
    {
        CreateMap<NewAdvancedSlotSettingsDto, AdvancedSlotSettings>();
        CreateMap<NewAvailabilitySlotDto, AvailabilitySlot>()
            .ForMember(s => s.TeamId, opt => opt.MapFrom(src => src.GeneralDetails!.TeamId))
            .ForMember(s => s.LocationId, opt => opt.MapFrom(src => src.GeneralDetails!.LocationId))
            .ForMember(s => s.Name, opt => opt.MapFrom(src => src.GeneralDetails!.Name))
            .ForMember(s => s.WelcomeMessage, opt => opt.MapFrom(src => src.EventDetails!.WelcomeMessage))
            .ForMember(s => s.Link, opt => opt.MapFrom(src => src.EventDetails!.Link))
            .ForMember(s => s.Type, opt => opt.MapFrom(src => src.GeneralDetails!.Type))
            .ForMember(s => s.Size, opt => opt.MapFrom(src => src.GeneralDetails!.Size))
            .ForMember(s => s.Frequency, opt => opt.MapFrom(src => src.GeneralDetails!.Frequency))
            .ForMember(s => s.IsEnabled, opt => opt.MapFrom(src => src.GeneralDetails!.IsEnabled))
            .ForMember(s => s.IsVisible, opt => opt.MapFrom(src => src.GeneralDetails!.IsVisible))
            .ForMember(s => s.Language, opt => opt.MapFrom(src => src.EventDetails!.Language))
            .ForMember(s => s.BookingsPerDay, opt => opt.MapFrom(src => src.EventDetails!.BookingsPerDay))
            .ForMember(s => s.AllowToAddGuests, opt => opt.MapFrom(src => src.EventDetails!.AllowToAddGuests))
            .ForMember(s => s.PasswordProtection, opt => opt.MapFrom(src => src.EventDetails!.PasswordProtection))
            .ForMember(s => s.TimeZoneVisibility, opt => opt.MapFrom(src => src.EventDetails!.TimeZoneVisibility));
        CreateMap<AvailabilitySlot, AvailabilitySlotDto>();
        CreateMap<AvailabilitySlotDto, AvailabilitySlot>();
    }
}