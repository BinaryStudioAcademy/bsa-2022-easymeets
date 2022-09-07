using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.UploadImage;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<List<TeamDto>> GetCurrentUserTeams();
    Task<List<TeamDto>> GetCurrentUserAdminTeams();
    Task<TeamDto?> GetTeamAsync(long teamId);
    Task<bool> ValidatePageLinkAsync(long? teamId, string pageLink);
    Task<TeamDto> CreateTeamAsync(NewTeamDto teamDto);
    Task UpdateTeamAsync(UpdateTeamDto team);
    Task DeleteTeamAsync(long teamId);
    Task<ImagePathDto> UploadLogoAsync(IFormFile file, long? teamId);
    Task<ICollection<NewMeetingMemberDto>> GetTeamMembersOfCurrentUserAsync(long? teamId);
    Task<List<TeamMemberDto>> GetTeamMembersAsync(long id);
    Task UpdateTeamMembersAsync(TeamMemberDto teamMemberDto, long teamId);
    Task DeleteTeamMemberAsync(long teamMemberId);
}
