namespace EasyMeets.Core.Common.DTO.Team
{
    public class TeamMemberInvitationDataDto
    {
        public long? UserId { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public long TeamId { get; set; }
    }
}
