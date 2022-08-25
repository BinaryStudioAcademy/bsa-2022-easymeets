using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.DTO.Team;

namespace EasyMeets.Core.Common.DTO.Calendar;

public class UserCalendarDto : EntityDto<long>
{
    public string ConnectedCalendar { get; set; } = string.Empty;
    public TeamDto? ImportEventsFromTeam { get; set; }
    public List<TeamDto>? VisibleForTeams { get; set; }
    public bool CheckForConflicts { get; set; }
}