namespace EasyMeets.Core.DAL.Entities
{
    public class MeetingMember
    {
        public long TeamMemberId { get; set; }
        public long MeetingId { get; set; }
        public TeamMember TeamMember { get; } = null!;
        public Meeting Meeting { get; set; } = null!;

    }
}
