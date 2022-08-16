using System.Text.RegularExpressions;

namespace EasyMeets.Core.Common.Validation;

public static class ValidationExtensions
{
    private const string Email = @"^([a-zA-z0-9]+([._\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\-][a-zA-Z0-9]+)?)+\.[a-zA-Z]{2,4}$";
    private const string Username = @"^[\w\d]+[\w\d\- ]+$";
    private const string TeamName = @"^[a-zA-Z\d- ]+$";
    private const string Description = @"^[.,іІїЇa-zA-Z\dа-яА-Я- ]+$";
    private const string PhoneNumber = @"^\+\d{10,13}$";
    private const string TeamLink = @"^/[a-zA-Z\d\-]+\d*$";
    private const string Password = @"^[^ ]+$";
    private const string Url = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";

    public static bool IsValidMeetingLocation(this string value)
    {
        string[] validLocations = { "Google Meet", "Zoom", "Offline" };
        return validLocations.Contains(value);
    }

    public static bool IsValidEmail(this string value)
    {
        return Regex.IsMatch(value, Email);
    }

    public static bool IsValidUsername(this string value)
    {
        return Regex.IsMatch(value, Username);
    }

    public static bool IsValidTeamName(this string value)
    {
        return Regex.IsMatch(value, TeamName);
    }

    public static bool IsValidDescription(this string value)
    {
        return Regex.IsMatch(value, Description);
    }

    public static bool IsValidPhoneNumber(this string value)
    {
        return Regex.IsMatch(value, PhoneNumber);
    }

    public static bool IsValidTeamLink(this string value)
    {
        return Regex.IsMatch(value, TeamLink);
    }

    public static bool IsValidPassword(this string value)
    {
        return Regex.IsMatch(value, Password);
    }

    public static bool IsValidUrl(this string value)
    {
        return Regex.IsMatch(value, Url);
    }
}