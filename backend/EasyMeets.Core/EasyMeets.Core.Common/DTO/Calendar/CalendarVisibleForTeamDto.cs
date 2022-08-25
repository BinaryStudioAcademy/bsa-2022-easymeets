using EasyMeets.Core.Common.DTO.Team;

namespace EasyMeets.Core.Common.DTO.Calendar;

public class CalendarVisibleForTeamDto
{
    public long CalendarId { get; set; }
    public long TeamId { get; set; }
    
    public TeamDto Team { get; set; } = null!;
}