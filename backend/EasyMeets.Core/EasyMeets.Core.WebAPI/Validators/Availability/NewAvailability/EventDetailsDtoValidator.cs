using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability.NewAvailability;

public class EventDetailsDtoValidator : AbstractValidator<EventDetailsDto>
{
    public EventDetailsDtoValidator()
    {
        RuleFor(d => d.PasswordProtection).Must(p => p is null || p.Length is > 2 and < 9);
    }
}