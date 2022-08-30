namespace EasyMeets.Core.DAL.Entities;

public class Schedule : Entity<long>
{
    /// <summary>
    /// Represents difference with GMT in minutes
    /// </summary>
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }

    public ICollection<SlotMember> Members { get; set; } = new List<SlotMember>();
    public ICollection<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();
}