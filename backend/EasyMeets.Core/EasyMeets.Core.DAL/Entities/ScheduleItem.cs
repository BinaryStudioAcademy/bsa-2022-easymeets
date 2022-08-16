using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class ScheduleItem : Entity<long>
{
    public long ScheduleId { get; set; }
    public TimeOnly Start { get; set; }
    public TimeOnly End { get; set; }
    public WeedDay WeedDay { get; set; }
    public bool IsEnabled { get; set; }

    public Schedule Schedule { get; set; } = null!;
}