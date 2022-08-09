namespace EasyMeets.Core.DAL.Entities;

public class Team : AuditEntity<int>
{
    public string LogoPath { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public string TimeZone { get; set; }  = string.Empty;
    public string Description { get; set; }  = string.Empty;
}
