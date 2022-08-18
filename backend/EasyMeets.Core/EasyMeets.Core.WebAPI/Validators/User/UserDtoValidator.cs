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
            .Must(p => p.IsValidPhoneNumber());
        RuleFor(u => u.UserName).NotNull().Must(u => u.IsValidUsername());
        RuleFor(u => u.Email).NotNull().Must(u => u.IsValidEmail());
        RuleFor(u => u.Image).NotNull().Must(u => u.IsValidUrl());
        RuleFor(u => u.Country).NotNull().Must(u => u.IsValidCountry());
        RuleFor(u => u.Language).NotNull().Must(u => u.IsValidLanguage());
        RuleFor(u => u.DateFormat).NotNull().Must(u => u.IsValidDateFormat());
        RuleFor(u => u.TimeFormat).NotNull().Must(u => u.IsValidTimeFormat());
    }
}