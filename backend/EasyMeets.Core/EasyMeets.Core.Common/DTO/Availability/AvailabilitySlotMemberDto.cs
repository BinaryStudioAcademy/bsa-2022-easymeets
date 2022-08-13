using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.Availability
{
    public class AvailabilitySlotMemberDto:EntityDto<long>
    {
        public string? MemberImage { get; set; }
        public string? MemberUserName { get; set; }
    }
}
