using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleDto
{
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }
    public bool DefinedExternally { get; set; }
    public string? DefinedBy { get; set; }
    public List<ScheduleItemDto> ScheduleItems { get; set; } = new();
    public List<ExclusionDateDto> ExclusionDates { get; set; } = new();
}