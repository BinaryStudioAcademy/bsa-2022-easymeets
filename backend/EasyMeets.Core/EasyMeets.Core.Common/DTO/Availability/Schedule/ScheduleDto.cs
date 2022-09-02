using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleDto
{
    public TimeZoneDto TimeZone { get; set; } = null!;
    public bool WithTeamMembers { get; set; }
    public bool DefinedExternally { get; set; }
    public string? DefinedBy { get; set; }
    public List<ScheduleItemDto> ScheduleItems { get; set; } = new();
}