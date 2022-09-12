using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.Availability;

public class ExternalAvailabilitySlotDto : EntityDto<long>
{
    public long TeamId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Size { get; set; }
    public LocationType LocationType { get; set; }
    public string? MeetingRoom { get; set; }
    public string Link { get; set; } = string.Empty;
}