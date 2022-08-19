namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleDto
{
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }
    public List<ScheduleItemDto> ScheduleItems { get; set; } = new();
}