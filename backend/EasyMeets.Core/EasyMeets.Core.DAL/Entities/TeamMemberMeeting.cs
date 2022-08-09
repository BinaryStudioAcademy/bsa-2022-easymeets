namespace EasyMeets.Core.DAL.Entities;

public class TeamMemberMeeting : Entity<long>
{
    public long MemberId { get; set; }
    public long EventId { get; set; }
    public int Priority { get; set; }
    
    public User User { get; }
    public Meeting Event { get; set; }
}
