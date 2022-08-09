namespace EasyMeets.Core.DAL.Entities;

public class Calendar : AuditEntity<long>
{
    public long UserId { get; set; }
    public long? AddEventsFromTeamId { get; set; }
    public bool CheckForConflicts { get; set; }
    
    public User User { get; set; }
    public Team? ImportEventsFromTeam { get; set; }
    public ICollection<CalendarVisibleForTeam> VisibleForTeams { get; set; }
    
}
