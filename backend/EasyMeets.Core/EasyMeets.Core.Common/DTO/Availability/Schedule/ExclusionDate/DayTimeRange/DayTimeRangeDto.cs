namespace EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;

public class DayTimeRangeDto
{
    public long Id { get; set; }
    public TimeOnly Start { get; set; }
    public TimeOnly End { get; set; }
}