namespace EasyMeets.Core.DAL.Entities;

public class Team : Entity<long>
{
    public Team()
    {
        ExportEventsToCalendars = new List<Calendar>();
        TeamMembers = new List<TeamMember>();
        VisibleCalendars = new List<CalendarVisibleForTeam>();
        AvailabilitySlots = new List<AvailabilitySlot>();
        Meetings = new List<Meeting>();
    }
    public string LogoPath { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public string TimeZone { get; set; }  = string.Empty;
    public string Description { get; set; }  = string.Empty;
    
    public ICollection<Calendar> ExportEventsToCalendars { get; set; }
    public ICollection<TeamMember> TeamMembers { get; set; }
    public ICollection<CalendarVisibleForTeam> VisibleCalendars { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
    public ICollection<Meeting> Meetings { get; set; }
}
