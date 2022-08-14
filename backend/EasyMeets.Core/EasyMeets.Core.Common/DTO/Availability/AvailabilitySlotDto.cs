using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotDto : EntityDto<long>
    {
        public string Name { get; set; } = string.Empty; 
        public SlotType Type { get; set; }
        public int Size { get; set; }
        public bool IsEnabled { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string TeamName { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
        public ICollection<AvailabilitySlotMemberDto> Members { get; set; } = null!;
    }
}
