namespace EasyMeets.Core.DAL.Entities;

public class ExclusionTimeRange : Entity<long>
{
    public long ScheduleId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Schedule Schedule { get; set; } = null!;
}