using System.Text.RegularExpressions;

namespace EasyMeets.Core.Common.Validation;

public static class ValidationExtensions
{
    public static IReadOnlyDictionary<string, string> RegularExpressions = new Dictionary<string, string>
    {
        { "Email", @"^([a-zA-z0-9]+([._\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\-][a-zA-Z0-9]+)?)+\.[a-zA-Z]{2,4}$" },
        { "Username", @"^[\w\d]+[\w\d\- ]+$" },
        { "PhoneNumber", @"^\+\d{1,2} \(\d{3}\) \d{3} \d{2} \d{2}$" },
        { "TeamLink", @"^/[a-zA-Z\d\-]+\d*$" },
        { "Password", @"^[^ ]+$" }
    };
    public static bool IsValidMeetingLocation(this string value)
    {
        string[] validLocations = { "Google Meet", "Zoom", "Offline" };
        return validLocations.Contains(value);
    }

    public static bool IsValidEmail(this string value)
    {
        var pattern = RegularExpressions["Email"];
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidUsername(this string value)
    {
        var pattern = RegularExpressions["Username"];
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidPhoneNumber(this string value)
    {
        var pattern = RegularExpressions["PhoneNumber"];
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidTeamLink(this string value)
    {
        var pattern = RegularExpressions["TeamLink"];
        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidPassword(this string value)
    {
        var pattern = RegularExpressions["Password"];
        return Regex.IsMatch(value, pattern);
    }
}