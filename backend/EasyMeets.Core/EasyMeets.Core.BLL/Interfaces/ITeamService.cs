using EasyMeets.Core.Common.DTO.Team;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<List<TeamDto>> GetCurrentUserTeams();
    Task<List<TeamDto>> GetCurrentUserAdminTeams();
    Task<TeamDto?> GetTeamAsync(long teamId);
    Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
    Task<bool> ValidatePageLinkAsync(long? teamId, string pageLink);
    Task<TeamDto> CreateTeamAsync(NewTeamDto teamDto);
    Task UpdateTeamAsync(TeamDto team);
    Task DeleteTeamAsync(long teamId);
}
