namespace EasyMeets.Core.DAL.Entities;

public class DayTimeRange : Entity<long>
{
    public long ExclusionDateId { get; set; }
    /// <summary>
    /// Represents start of time range
    /// </summary>
    public TimeSpan Start { get; set; }
    /// <summary>
    /// Represents end of time range
    /// </summary>
    public TimeSpan End { get; set; }
    public ExclusionDate ExclusionDate { get; set; } = null!;
}