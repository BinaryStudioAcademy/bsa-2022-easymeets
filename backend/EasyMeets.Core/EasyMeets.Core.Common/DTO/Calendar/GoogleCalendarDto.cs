namespace EasyMeets.Core.Common.DTO.Calendar;

public class GoogleCalendarDto
{
    public string? Summary { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}