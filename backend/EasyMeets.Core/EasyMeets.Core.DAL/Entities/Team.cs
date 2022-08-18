using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class Team : Entity<long>, IValidatableObject
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
    public int TimeZone { get; set; }
    public string Description { get; set; }  = string.Empty;

    public ICollection<Calendar> ExportEventsToCalendars { get; set; }
    public ICollection<TeamMember> TeamMembers { get; set; }
    public ICollection<CalendarVisibleForTeam> VisibleCalendars { get; set; }
    public ICollection<AvailabilitySlot> AvailabilitySlots { get; set; }
    public ICollection<Meeting> Meetings { get; set; }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!Name.IsValidUsername() || Name.Length is < 3 or > 50)
        {
            yield return new ValidationResult("Invalid team name");
        }

        if (!PageLink.IsValidTeamLink())
        {
            yield return new ValidationResult("Invalid team link");
        }

        if (!string.IsNullOrEmpty(Description) && Description.Length > 300)
        {
            yield return new ValidationResult("Too long team description");
        }
    }
}
