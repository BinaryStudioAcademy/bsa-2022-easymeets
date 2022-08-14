using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability;

public class AvailabilitySlotDto
{
    public long Id { get; set; }
    public long TeamId { get; set; }
    public long LocationId { get; set; }
    public LocationDto Location { get; set; } 
    public long? AdvancedSlotSettingsId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
    public IEnumerable<UserDto>? Members { get; set; }
}