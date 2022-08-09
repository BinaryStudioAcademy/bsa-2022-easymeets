namespace EasyMeets.Core.DAL.Entities;

public class User : Entity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? ImagePath { get; set; }
    public string? Country { get; set; }
    public string? TimeZone { get; set; }
    public bool IsBanned { get; set; }

    public ICollection<TeamMember> TeamMembers { get; set; }
    public ICollection<Calendar> Calendars { get; set; }
    public ICollection<Meeting> CreatedMeetings { get; set; }
    public ICollection<TeamMemberMeeting> TeamMeetings { get; set; }
    public ICollection<UserSlot> Slots { get; set; }
    public ICollection<AvailabilitySlot> CreatedSlots { get; set; }
}
