using EasyMeets.Core.Common.DTO.Team;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<TeamDto?> GetTeamAsync(long teamId);
    Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
    Task<TeamDto> CreateTeamAsync(NewTeamDto teamDto);
    Task UpdateTeamAsync(TeamDto team);
    Task DeleteTeamAsync(int teamId);
}
