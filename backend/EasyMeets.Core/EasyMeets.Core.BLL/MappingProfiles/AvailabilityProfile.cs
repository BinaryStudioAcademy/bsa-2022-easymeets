using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.AdvancedSlotSettings;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class AvailabilityProfile : Profile
    {
        public AvailabilityProfile()
        {
            CreateMap<AvailabilitySlot, AvailabilitySlotDto>()
                .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members.Select(x => x.User)))
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.Name));
            CreateMap<AvailabilitySlotDto, AvailabilitySlot>();
            CreateMap<NewAvailabilitySlotDto, AvailabilitySlot>()
            .ForMember(s => s.TeamId, opt => opt.MapFrom(src => src.GeneralDetails!.TeamId))
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
            .ForMember(s => s.PasswordProtectionIsUsed, opt => opt.MapFrom(src => src.EventDetails!.PasswordProtectionIsUsed))
            .ForMember(s => s.PasswordProtection, opt => opt.MapFrom(src => src.EventDetails!.PasswordProtection))
            .ForMember(s => s.TimeZoneVisibility, opt => opt.MapFrom(src => src.EventDetails!.TimeZoneVisibility));
            
            CreateMap<NewAdvancedSlotSettingsDto, AdvancedSlotSettings>();
            CreateMap<AdvancedSlotSettings, AdvancedSlotSettingsDto>();
            CreateMap<AdvancedSlotSettingsDto, AdvancedSlotSettings>();

            CreateMap<UpdateAvailabilityDto, AvailabilitySlot>()
                .ForMember(s => s.Frequency, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.SlotFrequency))
                .ForMember(s => s.Size, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.SlotSize))
                .ForMember(s => s.Name, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.MeetingName))
                .ForMember(s => s.IsVisible, opt => opt.MapFrom(src => !src.GeneralDetailsUpdate.HideFromCommon))
                .ForMember(s => s.IsEnabled, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(s => s.TimeZoneVisibility, opt => opt.MapFrom(src => src.EventDetailsUpdate.ZoneChoice))
                .ForMember(s => s.Link, opt => opt.MapFrom(src => src.EventDetailsUpdate.LinkChoice))
                .ForMember(s => s.WelcomeMessage, opt => opt.MapFrom(src => src.EventDetailsUpdate.WelcomeMessage))
                .ForMember(s => s.Language, opt => opt.MapFrom(src => src.EventDetailsUpdate.LanguageSelect))
                .ForMember(s => s.BookingsPerDay, opt => opt.MapFrom(src => src.EventDetailsUpdate.AllowBookingSelect))
                .ForMember(s => s.AllowToAddGuests, opt => opt.MapFrom(src => src.EventDetailsUpdate.IsAllowBooker))
                .ForMember(s => s.PasswordProtectionIsUsed, opt => opt.MapFrom(src => src.EventDetailsUpdate.PasswordProtect))
                .ForMember(s => s.PasswordProtection, opt => opt.MapFrom(src => src.EventDetailsUpdate.PasswordInput));

            CreateMap<UpdateAvailabilityDto, AdvancedSlotSettings>()
                .ForMember(s => s.ActivityType, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.SlotActivityOption))
                .ForMember(s => s.Days, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.SlotActivityValue))
                .ForMember(s => s.MaxNumberOfBookings, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.MaxBookings))
                .ForMember(s => s.PaddingMeeting, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.MeetingPadding))
                .ForMember(s => s.MinBookingMeetingDifference, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.MinBookingMeetingDifference))
                .ForMember(s => s.Color, opt => opt.MapFrom(src => src.GeneralDetailsUpdate.Color));
        }
    }
}