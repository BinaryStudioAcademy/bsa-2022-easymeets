using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class GeneralDetailsDto
{
    public string MeetingLocation { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public SlotType Type { get; set; }
    public int Size { get; set; }
    public int Frequency { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsVisible { get; set; }
}