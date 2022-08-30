using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.DAL.Entities
{
    public class EmailTemplate : Entity<long>
    {
        public long AvailabilitySlotId { get; set; }
        public TemplateType TemplateType { get; set; }
        public bool IsSend { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;

        public AvailabilitySlot AvailabilitySlot { get; set; } = null!;
    }
}
