namespace EasyMeets.Core.Common.DTO.Availability.AvailabilitySlotsResponse;

public class AvailabilitySlotsResponseDto
{
    public IEnumerable<AuthorSlotsDto> PersonalAvailabilitySlotsWithAuthors { get; set; }
    public IEnumerable<TeamSlotsDto> TeamAvailabilitySlotsWithTeams { get; set; }
}