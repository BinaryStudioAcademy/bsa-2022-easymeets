using EasyMeets.Core.Common.DTO.Availability.AdvancedSlotSettings;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotDto : EntityDto<long>
    {
        public string Name { get; set; } = string.Empty;
        public SlotType Type { get; set; }
        public int Size { get; set; }
        public bool IsEnabled { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string TeamName { get; set; } = string.Empty;
        public LocationType LocationType { get; set; }
        public ICollection<AvailabilitySlotMemberDto> Members { get; set; } = null!;
        public long? AdvancedSlotSettingsId { get; set; }
        public AdvancedSlotSettingsDto? AdvancedSlotSettings { get; set; }
        public List<EmailTemplatesSettingsDto>? EmailTemplateSettings { get; set; }
        public ICollection<QuestionDto> Questions { get; set; } = null!;
        public ScheduleDto Schedule { get; set; } = null!;
        public string WelcomeMessage { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public Color Color { get; set; }
        public bool IsVisible { get; set; }
        public string Language { get; set; } = string.Empty;
        public int BookingsPerDay { get; set; }
        public bool PasswordProtectionIsUsed { get; set; }
        public string? PasswordProtection { get; set; }
        public bool TimeZoneVisibility { get; set; }
    }
}
