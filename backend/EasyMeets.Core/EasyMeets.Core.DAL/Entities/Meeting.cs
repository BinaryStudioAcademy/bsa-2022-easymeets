namespace EasyMeets.Core.DAL.Entities;

public class Meeting : AuditEntity<int>
{
    public int TeamId { get; set; }
    public int LocationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Duration { get; set; }
    public DateTime StartTime { get; set; }
    
    public Team Team { get; set; }
    public User Author { get; set; }
    public Location Location { get; set; }
    public ICollection<TeamMemberMeeting> TeamMeetings { get; set; }
}
