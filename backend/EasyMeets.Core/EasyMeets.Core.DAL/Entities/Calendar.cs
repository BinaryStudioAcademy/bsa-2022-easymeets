namespace EasyMeets.Core.DAL.Entities;

public class Calendar : AuditEntity<int>
{
    public int UserId { get; set; }
    public int AddEventsFromTeamId { get; set; }
    public bool CheckForConflicts { get; set; }
}
