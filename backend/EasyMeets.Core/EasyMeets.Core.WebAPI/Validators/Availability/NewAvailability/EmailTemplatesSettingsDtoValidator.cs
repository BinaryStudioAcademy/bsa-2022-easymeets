using EasyMeets.Core.Common.DTO.Availability;
using FluentValidation;

namespace EasyMeets.Core.WebAPI.Validators.Availability.NewAvailability
{
    public class EmailTemplatesSettingsDtoValidator : AbstractValidator<EmailTemplatesSettingsDto>
    {
        public EmailTemplatesSettingsDtoValidator()
        {
            RuleFor(g => g.EmailSubject)
                .MinimumLength(5)
                .MaximumLength(30);
            RuleFor(g => g.EmailSubject)
                .MaximumLength(300);
        }
    }
}
