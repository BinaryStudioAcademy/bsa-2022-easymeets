using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class TeamMember : Entity<long>
{
    public long UserId { get; set; }
    public long TeamId { get; set; }
    public Role Role { get; set; }
    public Status Status { get; set; }

    public User User { get; set; } = null!;
    public Team Team { get; set; } = null!;

    public ICollection<MeetingMember> MeetingMembers { get; set; } = new List<MeetingMember>();
}
