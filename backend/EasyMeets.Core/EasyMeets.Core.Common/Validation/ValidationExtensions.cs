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
        return Regex.IsMatch(value, @"^([a-zA-z0-9]+([._\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\-][a-zA-Z0-9]+)?)+\.[a-zA-Z]{2,4}$");
    }
}