using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.DayTimeRange;

public class DayTimeRangeDtoValidator : AbstractValidator<DayTimeRangeDto>
{
    public DayTimeRangeDtoValidator()
    {
        RuleFor(d => d.Start)
            .Must((d, t) => TimeSpan.Compare(d.Start, d.End) < 0)
            .WithMessage("Time start should be smaller than end");
    }
}