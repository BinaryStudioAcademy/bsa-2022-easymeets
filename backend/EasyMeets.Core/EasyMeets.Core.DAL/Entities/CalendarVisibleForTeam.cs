namespace EasyMeets.Core.DAL.Entities;

public class CalendarVisibleForTeam
{
    public int CalendarId { get; set; }
    public int TeamId { get; set; }

    public Calendar Calendar { get; set; }
    public Team Team { get; set; }
}