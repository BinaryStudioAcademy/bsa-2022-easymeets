namespace EasyMeets.Core.DAL.Entities;

public class Calendar : AuditEntity<long>
{
    public Calendar()
    {
        VisibleForTeams = new List<CalendarVisibleForTeam>();
    }
    
    public long UserId { get; set; }
    public long? AddEventsFromTeamId { get; set; }
    public bool CheckForConflicts { get; set; }
    public string ConnectedCalendar { get; set; } = string.Empty;
    public string AccessToken { get; set; }  = string.Empty;
    public string RefreshToken { get; set; }  = string.Empty;
    public string Uid { get; set; }  = string.Empty;

    public User User { get; set; } = null!;
    public Team? ImportEventsFromTeam { get; set; }
    public ICollection<CalendarVisibleForTeam> VisibleForTeams { get; set; }

}
