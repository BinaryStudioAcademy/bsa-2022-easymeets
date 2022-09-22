using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class EmailTemplatesSettingsDto
    {
        public bool AllowToSend { get; set; }
        public string EmailSubject { get; set; } = String.Empty;
        public string EmailBody { get; set; } = String.Empty;
        public TemplateType Type { get; set; }
        public string TimeValue { get; set; } = String.Empty;
    }
}
