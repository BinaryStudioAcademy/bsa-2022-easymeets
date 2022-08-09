namespace EasyMeets.Core.DAL.Entities;

public class CalendarVisibleForTeam : Entity<long>
{
    public long CalendarId { get; set; }
    public long TeamId { get; set; }

    public Calendar Calendar { get; set; }
    public Team Team { get; set; }
}