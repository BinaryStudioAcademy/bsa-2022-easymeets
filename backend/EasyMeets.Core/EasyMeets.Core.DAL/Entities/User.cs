namespace EasyMeets.Core.DAL.Entities;

public class User : Entity<long>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? ImagePath { get; set; }
    public string? Language { get; set; }
    public string? TimeFormat { get; set; }
    public string? DateFormat { get; set; }
    public string? Country { get; set; }
    public string? TimeZone { get; set; }
    public bool IsBanned { get; set; }

    public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
    public ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();
    public ICollection<Meeting> CreatedMeetings { get; set; } = new List<Meeting>();
    public ICollection<TeamMemberMeeting> TeamMeetings { get; set; } = new List<TeamMemberMeeting>();
    public ICollection<UserSlot> Slots { get; set; } = new List<UserSlot>();
    public ICollection<AvailabilitySlot> CreatedSlots { get; set; } = new List<AvailabilitySlot>();
}
