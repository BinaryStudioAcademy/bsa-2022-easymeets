using System.ComponentModel.DataAnnotations;
using EasyMeets.Core.Common.Validation;

namespace EasyMeets.Core.DAL.Entities;

public class Schedule : Entity<long>, IValidatableObject
{
    /// <summary>
    /// Represents difference with GMT in minutes
    /// </summary>
    public int TimeZone { get; set; }
    public bool WithTeamMembers { get; set; }
    public bool DefinedExternally { get; set; }
    public string? DefinedBy { get; set; }

    public ICollection<SlotMember> Members { get; set; } = new List<SlotMember>();
    public ICollection<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (DefinedExternally && (DefinedBy is null || !DefinedBy.IsValidEmail()))
        {
            yield return new ValidationResult("Schedule definer's email isn't valid");
        }
    }
}