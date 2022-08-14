using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.Common.Validation;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.User;

public class UserDtoValidator : AbstractValidator<UserDto>
{
    public UserDtoValidator()
    {
        RuleFor(u => u.Phone)
            .NotNull()
            .MinimumLength(2)
            .MaximumLength(50)
            .Must(p => p!.IsValidPhoneNumber());
        RuleFor(u => u.UserName).NotNull().Must(u => u!.IsValidUsername());
    }
}