namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class EventWithMeetDto
{
    public string Summary { get; set; } = string.Empty;
    public string Status { get; set; } = "confirmed";
    public EventTimeDto End { get; set; } = new();
    public EventTimeDto Start { get; set; } = new();
    public ConferenceDataDto ConferenceData { get; set; } = new();
}