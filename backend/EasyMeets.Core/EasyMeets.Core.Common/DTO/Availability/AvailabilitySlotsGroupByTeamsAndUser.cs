namespace EasyMeets.Core.Common.DTO.Availability
{
    public class UserPersonalAndTeamSlots
    {
        public UserPersonalAndTeamSlots(ICollection<AvailabilitySlotDto> userSlots, ICollection<AvailabilitySlotsGroupByTeamsDto> teamsSlots)
        {
            UserSlots = userSlots;
            TeamSlots = teamsSlots;
        }
        public ICollection<AvailabilitySlotDto> UserSlots { get; set; }
        public ICollection<AvailabilitySlotsGroupByTeamsDto> TeamSlots { get; set; }
    }
}
