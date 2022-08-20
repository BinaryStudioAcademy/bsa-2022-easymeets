using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface ITeamService
    {
        Task<ICollection<NewMeetingTeamMemberDto>> GetTeamMembersOfCurrentUserAsync(long userId);
    }
}
