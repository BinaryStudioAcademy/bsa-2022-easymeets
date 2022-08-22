using System.Security.Claims;

namespace EasyMeets.Core.BLL.Extentions;

public static class HttpUserExtensions {
    public static string? GetUid(this ClaimsPrincipal user)
    {
        return user.Claims
            .FirstOrDefault(claim => claim.Type == "user_id")?
            .Value;
    }
}