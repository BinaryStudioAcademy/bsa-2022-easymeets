namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleDto
{
    public string TimeZoneValue { get; set; } = string.Empty;
    public string TimeZoneName { get; set; } = string.Empty;
    public bool WithTeamMembers { get; set; }
    public List<ScheduleItemDto> ScheduleItems { get; set; } = new();
}