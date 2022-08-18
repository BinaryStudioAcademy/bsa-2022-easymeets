namespace EasyMeets.Core.Common.DTO.Availability.NewAvailability;

public class NewScheduleDto
{
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }
    public List<NewScheduleItemDto> Items { get; set; } = new();
}