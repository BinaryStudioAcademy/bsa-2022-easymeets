using Newtonsoft.Json;

namespace EasyMeets.Core.Common.DTO.Calendar;

public class GoogleCalendarDto
{
    [JsonProperty("id")] 
    public string Id { get; set; } = string.Empty;
    
    [JsonProperty("description")] 
    public string Description { get; set; } = string.Empty;
    
    [JsonProperty("summary")] 
    public string Summary { get; set; } = string.Empty;
    
    [JsonProperty("timeZone")] 
    public string TimeZone { get; set; } = string.Empty;
}