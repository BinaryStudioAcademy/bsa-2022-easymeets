using EasyMeets.Core.Common.DTO.Team;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<TeamDto?> GetTeamPreferences(long teamId);
    Task UpdateTeamPreferences(TeamDto team);
}
