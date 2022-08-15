namespace EasyMeets.Core.DAL.Entities;

public class ScheduleItem
{
    public long ScheduleId { get; set; }
    public DateTimeOffset Start { get; set; }
    public int Duration { get; set; }

    public Schedule Schedule { get; set; } = null!;
}