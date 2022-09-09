using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Team;

public class TeamMemberDto : EntityDto<long>
{
    public string? Image { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public Role Role { get; set; }
    public Status Status { get; set; }
    public List<string>? ConnectedCalendars { get; set; } = new List<string>();
}