using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.AdvancedSlotSettings;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class AvailabilityProfile : Profile
    {
        public AvailabilityProfile()
        { 
            CreateMap<AvailabilitySlot, AvailabilitySlotDto>()
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.SlotMembers.Select(x => x.User)))
                .ForMember(dest => dest.EmailTemplateSettings, opt => opt.MapFrom(src => src.EmailTemplates));
            CreateMap<AvailabilitySlotDto, AvailabilitySlot>();
            CreateMap<SaveAvailabilitySlotDto, AvailabilitySlot>()
                .ForMember(s => s.TeamId, opt => opt.MapFrom((src, dest) => src.TeamId ?? dest.TeamId))
                .ForMember(s => s.LocationType, opt => opt.MapFrom(src => src.GeneralDetails!.LocationType))
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
                .ForMember(s => s.PasswordProtectionIsUsed,
                    opt => opt.MapFrom(src => src.EventDetails!.PasswordProtectionIsUsed))
                .ForMember(s => s.PasswordProtection, opt => opt.MapFrom(src => src.EventDetails!.PasswordProtection))
                .ForMember(s => s.TimeZoneVisibility, opt => opt.MapFrom(src => src.EventDetails!.TimeZoneVisibility))
                .ForMember(s => s.Questions, opt => opt.Ignore());
                
            CreateMap<SaveAdvancedSlotSettingsDto, AdvancedSlotSettings>();
            CreateMap<AdvancedSlotSettings, AdvancedSlotSettingsDto>();
            CreateMap<AdvancedSlotSettingsDto, AdvancedSlotSettings>();
        }
    }
}