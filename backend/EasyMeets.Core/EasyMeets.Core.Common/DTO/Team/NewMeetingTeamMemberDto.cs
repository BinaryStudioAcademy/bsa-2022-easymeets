using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Team
{
    public class NewMeetingMemberDto : EntityDto<long>
    {
        public string Name { get; set; } = string.Empty!;
        public string? Image { get; set; }
        public List<UnavailabilityItemDto> UnavailabilityItems { get; set; } = new List<UnavailabilityItemDto>();
    }
}
