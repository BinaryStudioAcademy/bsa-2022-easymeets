namespace EasyMeets.Core.DAL.Entities;

public class TeamMemberMeeting : Entity<long>
{
    public int MemberId { get; set; }
    public int EventId { get; set; }
    public int Priority { get; set; }
    
    public User User { get; }
    public Meeting Event { get; set; }
}
