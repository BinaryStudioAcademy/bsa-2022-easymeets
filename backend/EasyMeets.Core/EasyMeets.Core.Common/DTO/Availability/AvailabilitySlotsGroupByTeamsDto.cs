namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotsGroupByTeamsDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public ICollection<AvailabilitySlotDto> AvailabilitySlots { get; set; } = null!;
    }
}
