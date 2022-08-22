namespace EasyMeets.Core.Common.DTO.Team;

public class NewTeamDto
{
    public string Image { get; set; } = string.Empty;
    public string Name { get; set; }
    public string PageLink { get; set; }
    public int TimeZone { get; set; }
    public string Description { get; set; }
}
