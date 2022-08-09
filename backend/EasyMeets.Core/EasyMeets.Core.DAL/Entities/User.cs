namespace EasyMeets.Core.DAL.Entities;

public class User : AuditEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? ImagePath { get; set; }
    public string? Country { get; set; }
    public string? TimeZone { get; set; }
    public bool IsBanned { get; set; }
}
