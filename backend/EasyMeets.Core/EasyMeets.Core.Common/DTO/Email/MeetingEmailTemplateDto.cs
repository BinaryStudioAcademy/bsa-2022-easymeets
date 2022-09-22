using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Email
{
    public class MeetingEmailTemplateDto
    {
        public string MeetingName { get; set; } = String.Empty;
        public string MeetingRoom { get; set; } = String.Empty;
        public DateTimeOffset StartTime { get; set; }
        public LocationType LocationType { get; set; }
        public string AuthorName { get; set; } = String.Empty;
        public string AuthorEmail { get; set; } = String.Empty;
        public string MeetingLink { get; set; } = String.Empty;
        public string MemberName { get; set; } = String.Empty;
        public string Uri { get; set; } = String.Empty;
    }
}
