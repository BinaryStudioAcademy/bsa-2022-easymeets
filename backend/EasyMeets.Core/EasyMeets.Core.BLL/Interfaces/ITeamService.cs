using EasyMeets.Core.Common.DTO.Team;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<TeamDto?> GetTeam(long teamId);
    Task UpdateTeam(TeamDto team);
}
