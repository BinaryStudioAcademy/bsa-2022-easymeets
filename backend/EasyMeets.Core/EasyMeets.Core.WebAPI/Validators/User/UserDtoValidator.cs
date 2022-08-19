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
        RuleFor(u => u.UserName).NotNull().Must(n => n.IsValidUsername());
        RuleFor(u => u.Email).NotNull().Must(e => e.IsValidEmail());
        RuleFor(u => u.Image).NotNull().Must(i => i != null && i.IsValidUrl()).When(u => u.Image is not null);
        RuleFor(u => u.Country).NotNull().Must(c => c != null && c.Value.IsValidCountry()).When(u => u.Country.HasValue);
        RuleFor(u => u.Language).NotNull().Must(l => l.IsValidLanguage());
        RuleFor(u => u.DateFormat).NotNull().Must(d => d.IsValidDateFormat());
        RuleFor(u => u.TimeFormat).NotNull().Must(t => t.IsValidTimeFormat());
    }
}