using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Team;

public class UpdateTeamDto : EntityDto<long>
{
    public string Image { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public int TimeZone { get; set; }
    public string Description { get; set; } = string.Empty;
}