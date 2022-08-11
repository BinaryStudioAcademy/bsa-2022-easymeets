using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums; 

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotDto : EntityDto<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public SlotType Type { get; set; }
        public int Size { get; set; }
        public bool IsEnabled { get; set; } 
        public UserDto Author { get; set; } = null!;
        public TeamDto Team { get; set; } = null!;
        public LocationDto Location { get; set; } = null!;
        public ICollection<UserDto> Members { get; set; }
    }
}
