using EasyMeets.Core.Common.Enums;
using System.Text.RegularExpressions;

namespace EasyMeets.Core.Common.Validation;

public static class ValidationExtensions
{
    public static IReadOnlyDictionary<string, string> RegularExpressions = new Dictionary<string, string>
    {
        { "Email", @"^([a-zA-z0-9]+([._\-][a-zA-z0-9]+)?)+@([a-zA-z0-9]+([.\-][a-zA-Z0-9]+)?)+\.[a-zA-Z]{2,4}$" },
        { "Username", @"^[\w\d]+[\w\d\- ]+$" },
        { "PhoneNumber", @"^\+\d{10,13}$" },
        { "TeamLink", @"^/[a-zA-Z\d\-]+\d*$" },
        { "Password", @"^[^ ]+$" },
        { "Url", @"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?"}
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

    public static bool IsValidCountry(this Country value)
    {
        var countries = Enum.GetValues(typeof(Country)).Cast<Country>().ToList();
        return countries.Contains(value);
    }

    public static bool IsValidTimeFormat(this TimeFormat value)
    {
        var timeFormats = Enum.GetValues(typeof(TimeFormat)).Cast<TimeFormat>().ToList();
        return timeFormats.Contains(value);
    }

    public static bool IsValidLanguage(this Language value)
    {
        var languages = Enum.GetValues(typeof(Language)).Cast<Language>().ToList();
        return languages.Contains(value);
    }

    public static bool IsValidDateFormat(this DateFormat value)
    {
        var dateFormats = Enum.GetValues(typeof(DateFormat)).Cast<DateFormat>().ToList();
        return dateFormats.Contains(value);
    }

    public static bool IsValidUrl(this string value)
    {
        var pattern = RegularExpressions["Url"];
        return Regex.IsMatch(value, pattern);
    }
}