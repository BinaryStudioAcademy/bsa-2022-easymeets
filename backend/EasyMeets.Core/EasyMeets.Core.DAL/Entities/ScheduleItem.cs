using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class ScheduleItem : Entity<long>
{
    public long ScheduleId { get; set; }
    /// <summary>
    /// Represents time of the day
    /// </summary>
    public TimeSpan Start { get; set; }
    /// <summary>
    /// Represents time of the day
    /// </summary>
    public TimeSpan End { get; set; }
    public WeekDay WeekDay { get; set; }
    public bool IsEnabled { get; set; }

    public Schedule Schedule { get; set; } = null!;
}