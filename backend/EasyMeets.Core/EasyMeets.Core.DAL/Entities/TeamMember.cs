using EasyMeets.Core.DAL.Entities.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class TeamMember
{
    public int UserId { get; set; }
    public int TeamId { get; set; }
    public Role Role { get; set; }
    public int Status { get; set; }
    public bool IsDeleted { get; set; }

    public User User { get; set; }
    public Team Team { get; set; }
}
