using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability.NewAvailability;

public class NewAdvancedSlotSettingsDtoValidator : AbstractValidator<NewAdvancedSlotSettingsDto>
{
    public NewAdvancedSlotSettingsDtoValidator()
    {
        RuleFor(s => s.Days).Must(d => d > 0);
        RuleFor(s => s.PaddingMeeting).Must(p => p > 0);
        RuleFor(s => s.MaxNumberOfBookings).Must(n => n > 0);
        RuleFor(s => s.MinBookingMeetingDifference).Must(d => d > 0);
    }
}