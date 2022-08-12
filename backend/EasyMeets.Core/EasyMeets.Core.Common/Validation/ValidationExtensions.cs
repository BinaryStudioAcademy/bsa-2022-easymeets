using System.Text.RegularExpressions;

namespace EasyMeets.Core.Common.Validation;

public static class ValidationExtensions
{
    public static bool IsValidMeetingLocation(this string value)
    {
        string[] validLocations = { "Google Meet", "Zoom", "Offline" };
        return validLocations.Contains(value);
    }

    public static bool IsValidEmail(this string value)
    {
        var pattern = @"^([a-zA-z0-9]+([._\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\-][a-zA-Z0-9]+)?)+\.[a-zA-Z]{2,4}$";
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidUsername(this string value)
    {
        var pattern = @"^[\w\d]+[\w\d\- ]+$";
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidPhoneNumber(this string value)
    {
        var pattern = @"^\+\d{1,2} \(\d{3}\) \d{3} \d{2} \d{2}$";
        return Regex.IsMatch(value, pattern);
    }
}