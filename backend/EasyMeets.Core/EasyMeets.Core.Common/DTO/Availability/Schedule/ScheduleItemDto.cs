using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleItemDto
{
    /// <summary>
    /// Represents time of the day
    /// </summary>
    public TimeSpanDto Start { get; set; } = new();
    /// <summary>
    /// Represents time of the day
    /// </summary>
    public TimeSpanDto End { get; set; } = new();
    public WeekDay WeekDay { get; set; }
    public bool IsEnabled { get; set; }
}