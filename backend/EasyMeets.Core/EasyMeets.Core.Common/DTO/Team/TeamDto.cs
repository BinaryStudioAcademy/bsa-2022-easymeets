using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.Common.DTO.Team;

public class TeamDto
{
    public long Id { get; set; }
    public string LogoPath { get; set; }
    public string Name { get; set; }
    public string PageLink { get; set; }
    public string TimeZone { get; set; }
    public string Description { get; set; }
    public IEnumerable<UserDto>? Members { get; set; }
}