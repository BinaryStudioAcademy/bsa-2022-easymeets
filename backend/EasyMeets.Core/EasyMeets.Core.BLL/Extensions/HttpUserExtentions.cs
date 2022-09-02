using System.Security.Claims;

namespace EasyMeets.Core.BLL.Extentions;

public static class HttpUserExtensions {
    public static string? GetUid(this ClaimsPrincipal user)
    {
        return user.Claims
            .FirstOrDefault(claim => claim.Type == "user_id")?
            .Value;
    }

    public static long GetId(this ClaimsPrincipal user)
    {
        var stringId = user.Claims
            .FirstOrDefault(claim => claim.Type == "id")?
            .Value;

        if (stringId is null)
        {
            throw new KeyNotFoundException("Id not found in user's claims");
        }
        
        return long.Parse(stringId);
    }
}