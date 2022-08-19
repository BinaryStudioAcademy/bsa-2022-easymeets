using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.Common.Validation;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability.NewAvailability;

public class GeneralDetailsDtoValidator : AbstractValidator<GeneralDetailsDto>
{
    public GeneralDetailsDtoValidator()
    {
        RuleFor(g => g.Frequency).Must(f => f > 0);
        RuleFor(g => g.Name)
            .MinimumLength(1)
            .MaximumLength(50)
            .Must(n => n.IsValidUsername());
        RuleFor(g => g.Size).Must(s => s > 0);
    }
}