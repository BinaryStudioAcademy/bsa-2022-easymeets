using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Team
{
    public class NewMeetingTeamMemberDto : EntityDto<long>
    {
        public string Name { get; set; } = string.Empty!;
    }
}
