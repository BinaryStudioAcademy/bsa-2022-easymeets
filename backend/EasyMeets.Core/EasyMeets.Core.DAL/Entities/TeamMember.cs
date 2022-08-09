using EasyMeets.Core.DAL.Entities.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class TeamMember : Entity<long>
{
    public TeamMember()
    {
        User = new User();
        Team = new Team();
    }
    
    public long UserId { get; set; }
    public long TeamId { get; set; }
    public Role Role { get; set; }
    public Status Status { get; set; }

    public User User { get; set; }
    public Team Team { get; set; }
}
