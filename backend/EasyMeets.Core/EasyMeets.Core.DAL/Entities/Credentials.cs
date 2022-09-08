using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities;

public class Credentials : Entity<long>
{
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public int LifeCycle { get; set; }
    public long UserId { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public CredentialsType Type { get; set; }
    public string? UserEmail { get; set; } = null;

    public User User { get; set; } = null!;
}