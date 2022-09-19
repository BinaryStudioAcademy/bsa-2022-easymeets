using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.DayTimeRange;

public class DayTimeRangeDtoValidator : AbstractValidator<DayTimeRangeDto>
{
    public DayTimeRangeDtoValidator()
    {
        RuleFor(d => d.Start)
            .Must((d, t) => d.Start.Hour < d.End.Hour || (d.Start.Hour == d.End.Hour && d.Start.Minute < d.End.Minute))
            .WithMessage("Time start should be smaller than end");
    }
}