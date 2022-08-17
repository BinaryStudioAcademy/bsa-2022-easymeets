using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;

public class EventDetailsUpdateDto
{
    public bool ZoneChoice { get; set; }
    public string LinkChoice { get; set; } = string.Empty;
    public string WelcomeMessage { get; set; } = string.Empty;
    public string LanguageSelect { get; set; } = string.Empty;
    public int AllowBookingSelect { get; set; }
    public bool IsAllowBooker { get; set; }
    public bool PasswordProtect { get; set; }
    public string PasswordInput { get; set; } = string.Empty;
}