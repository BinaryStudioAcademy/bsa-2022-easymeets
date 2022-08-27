using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class EmailTemplatesSettingsDto
    {
        public bool AllowToSend { get; set; }
        public string? EmailSubject { get; set; }
        public string? EmailBody { get; set; }
        public TemplateType Type { get; set; }
    }
}
