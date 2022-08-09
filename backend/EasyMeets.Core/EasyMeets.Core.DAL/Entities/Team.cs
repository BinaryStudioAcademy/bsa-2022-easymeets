namespace EasyMeets.Core.DAL.Entities;

public class Team : Entity<int>
{
    public string LogoPath { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string PageLink { get; set; } = string.Empty;
    public string TimeZone { get; set; }  = string.Empty;
    public string Description { get; set; }  = string.Empty;
    
    public ICollection<Calendar> ExportEventsToCalendars { get; set; }
    public ICollection<TeamMember> TeamMembers { get; set; }
    public ICollection<Calendar> VisibleCalendars { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
    public ICollection<Meeting> Meetings { get; set; }
}
