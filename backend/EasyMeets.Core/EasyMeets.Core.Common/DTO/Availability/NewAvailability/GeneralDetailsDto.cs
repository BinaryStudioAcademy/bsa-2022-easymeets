using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class GeneralDetailsDto
{
    public long TeamId { get; set; }
    public LocationType LocationType { get; set; }
    public string Name { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
}