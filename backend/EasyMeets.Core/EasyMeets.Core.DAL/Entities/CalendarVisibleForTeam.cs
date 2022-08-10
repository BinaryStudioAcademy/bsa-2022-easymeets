namespace EasyMeets.Core.DAL.Entities;

public class CalendarVisibleForTeam : Entity<long>
{
    public CalendarVisibleForTeam()
    {
    }
    public long CalendarId { get; set; }
    public long TeamId { get; set; }

    public Calendar Calendar { get; set; } = null!;
    public Team Team { get; set; } = null!;
}