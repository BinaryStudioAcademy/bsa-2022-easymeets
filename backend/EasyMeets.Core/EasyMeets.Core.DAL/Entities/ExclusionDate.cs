namespace EasyMeets.Core.DAL.Entities;

public class ExclusionDate : Entity<long>
{
    public long ScheduleId { get; set; }
    public DateTime SelectedDate { get; set; }
    public ICollection<DayTimeRange> DayTimeRanges { get; set; } = new List<DayTimeRange>();
    public Schedule Schedule { get; set; } = null!;
}