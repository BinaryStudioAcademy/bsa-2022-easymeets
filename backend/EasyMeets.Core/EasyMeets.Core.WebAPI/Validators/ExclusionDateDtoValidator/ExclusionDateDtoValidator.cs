using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate;
using EasyMeets.Core.WebAPI.Validators.DayTimeRange;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.ExclusionDateDtoValidator;

public class ExclusionDateDtoValidator : AbstractValidator<ExclusionDateDto>
{
    public ExclusionDateDtoValidator()
    {
        RuleForEach(d => d.DayTimeRanges)
            .SetValidator(new DayTimeRangeDtoValidator());
    }
}