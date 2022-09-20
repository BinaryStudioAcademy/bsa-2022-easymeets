namespace EasyMeets.Core.Common.DTO.Team
{
    public class CreateTeamMemberDto
    {
        public string UserEmail { get; set; } = string.Empty;
        public long TeamId { get; set; }
    }
}
