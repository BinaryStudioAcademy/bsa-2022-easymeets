using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Validation;
using FluentValidation;
namespace EasyMeets.Core.WebAPI.Validators.Team;

public class NewTeamDtoValidator: AbstractValidator<NewTeamDto>
{
    public NewTeamDtoValidator()
    {
        RuleFor(u => u.Description)
            .NotNull()
            .Must(p => p!.IsValidDescription());

        RuleFor(u => u.Name)
            .NotNull()
            .MinimumLength(2)
            .MaximumLength(50)
            .Must(u => u!.IsValidTeamName());

        RuleFor(u => u.PageLink)
            .Must(u => u!.IsValidTeamLink());
    }
}
