namespace EasyMeets.Core.DAL.Entities;

public class Meeting : AuditEntity<long>
{
    public Meeting()
    {
        TeamMeetings = new List<TeamMemberMeeting>();
    }
    public long TeamId { get; set; }
    public long LocationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Duration { get; set; }
    public DateTimeOffset StartTime { get; set; }
    
    public Team Team { get; set; } = null!;
    public User Author { get; set; } = null!;
    public Location Location { get; set; } = null!;
    public ICollection<TeamMemberMeeting> TeamMeetings { get; set; }
}
