using EasyMeets.Core.Common.DTO.Availability.Schedule;

namespace EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

public class SlotMemberDto
{
    public long MemberId { get; set; }
    public int Priority { get; set; }
    public string Name { get; set; } = string.Empty;
    public ScheduleDto Schedule { get; set; } = null!;
}