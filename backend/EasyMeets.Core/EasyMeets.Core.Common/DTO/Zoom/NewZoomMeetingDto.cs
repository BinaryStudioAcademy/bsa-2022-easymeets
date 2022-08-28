namespace EasyMeets.Core.Common.DTO.Zoom;

public class NewZoomMeetingDto
{
    public string Agenda { get; set; } = string.Empty;
    public int Duration { get; set; }
    public string ScheduleFor { get; set; } = string.Empty;
    public NewMeetingSettingsDto Settings { get; set; } = new();
    public DateTimeOffset StartTime { get; set; }
    public string TimeZone { get; set; } = "UTC";
    public string Topic { get; set; } = string.Empty;
    public int Type { get; set; } = 2;
}