using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionTImeRange;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.ExclusionTimeRange;

public class ExclusionTimeRangeValidator : AbstractValidator<ExclusionTimeRangeDto>
{
    public ExclusionTimeRangeValidator()
    {
        RuleFor(d => d.Start)
            .Must((d, t) => d.Start < d.End)
            .WithMessage("Time start should be smaller than end");
    }
}