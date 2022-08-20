using EasyMeets.Core.Common.DTO.Team;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface ITeamService
    {
        Task<List<TeamDto>> GetCurrentUserTeams();
    }
}