using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

public class GeneralDetailsDto
{
    public LocationType LocationType { get; set; }
    public string Name { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public Color Color { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
}