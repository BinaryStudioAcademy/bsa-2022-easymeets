namespace EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;

public class DayTimeRangeDto
{
    public long Id { get; set; }
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
}