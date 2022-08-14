namespace EasyMeets.Core.Common.DTO.Availability
{
    public class UserPersonalAndTeamSlotsDto
    {
        public UserPersonalAndTeamSlotsDto(ICollection<AvailabilitySlotDto> userSlots, ICollection<AvailabilitySlotsGroupByTeamsDto> teamsSlots)
        {
            UserSlots = userSlots;
            TeamSlots = teamsSlots;
        }
        public ICollection<AvailabilitySlotDto> UserSlots { get; set; }
        public ICollection<AvailabilitySlotsGroupByTeamsDto> TeamSlots { get; set; }
    }
}
