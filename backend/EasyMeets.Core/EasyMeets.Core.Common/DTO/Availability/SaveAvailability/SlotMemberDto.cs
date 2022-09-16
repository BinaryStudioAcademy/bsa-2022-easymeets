namespace EasyMeets.Core.Common.DTO.Availability.SaveAvailability;

public class SlotMemberDto
{
    public long MemberId { get; set; }
    public int Priority { get; set; }
    public long? ScheduleId { get; set; }
}