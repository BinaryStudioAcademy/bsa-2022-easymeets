namespace EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

public class EventDetailsDto
{
    public string Link { get; set; } = string.Empty;
    public string WelcomeMessage { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public int BookingsPerDay { get; set; }
    public bool PasswordProtectionIsUsed { get; set; }
    public string? PasswordProtection { get; set; }
    public bool TimeZoneVisibility { get; set; }
}