namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotsGroupByTeamsDto
    {
        public string Name { get; set; } = string.Empty;
        public string PageLink { get; set; } = string.Empty;
        public ICollection<AvailabilitySlotDto> AvailabilitySlots { get; set; } = null!;
    }
}
