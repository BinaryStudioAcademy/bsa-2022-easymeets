using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.WebAPI.Validators.ExclusionTimeRange;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability;

public class SaveAvailabilitySlotDtoValidator : AbstractValidator<SlotMemberDto>
{
    public SaveAvailabilitySlotDtoValidator()
    {
        RuleForEach(s => s.Schedule.ExclusionTimeRanges)
            .SetValidator(new ExclusionTimeRangeValidator());
    }
}