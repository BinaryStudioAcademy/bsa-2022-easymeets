using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability;

public class SaveAvailabilitySlotDtoValidator : AbstractValidator<SlotMemberDto>
{
    public SaveAvailabilitySlotDtoValidator()
    {
        RuleForEach(s => s.Schedule.ExclusionDates)
            .SetValidator(new ExclusionDateDtoValidator.ExclusionDateDtoValidator());
    }
}