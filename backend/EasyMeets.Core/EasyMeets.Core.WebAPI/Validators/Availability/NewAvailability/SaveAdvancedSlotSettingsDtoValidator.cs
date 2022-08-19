using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability.NewAvailability;

public class SaveAdvancedSlotSettingsDtoValidator : AbstractValidator<SaveAdvancedSlotSettingsDto>
{
    public SaveAdvancedSlotSettingsDtoValidator()
    {
        RuleFor(s => s.Days).Must(d => d is > 0 and < 1000);
        RuleFor(s => s.PaddingMeeting).Must(p => p is < 1 or > 999);
        RuleFor(s => s.MaxNumberOfBookings).Must(n => n > 0);
        RuleFor(s => s.MinBookingMeetingDifference).Must(d => d > 0);
    }
}