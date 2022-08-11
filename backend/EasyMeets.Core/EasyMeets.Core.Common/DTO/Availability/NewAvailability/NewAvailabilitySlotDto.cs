using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class NewAvailabilitySlotDto
{
    public long TeamId { get; set; }
    public long LocationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
    public NewAdvancedSlotSettingsDto? AdvancedSettings { get; set; }
}