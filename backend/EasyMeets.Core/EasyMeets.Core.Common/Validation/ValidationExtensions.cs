namespace EasyMeets.Core.Common.Validation;

public static class ValidationExtensions
{
    public static bool IsValidMeetingLocation(this string value)
    {
        string[] validLocations = { "Google Meet", "Zoom", "Offline" };
        return validLocations.Contains(value);
    }
}