using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule;

public class ScheduleItemDto : EntityDto<long>
{
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
}