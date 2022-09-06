namespace EasyMeets.Core.DAL.Entities;

public class CalendarEvent : Entity<long>
{
    public long UserId { get; set; }
    public string Summary { get; set; } = string.Empty;
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string TimeZone { get; set; } = string.Empty;

    public User User { get; set; } = null!;
}