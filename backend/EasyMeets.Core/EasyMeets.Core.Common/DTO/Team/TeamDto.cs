namespace EasyMeets.Core.Common.DTO.Team;

public class TeamDto
{
    public long Id { get; set; }
    public string LogoPath { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public int TimeZone { get; set; }
    public string Description { get; set; }  = string.Empty;
}