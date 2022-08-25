using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.UploadImage;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamService
{
    Task<TeamDto?> GetTeamAsync(long teamId);
    Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
    Task<bool> ValidatePageLinkAsync(long teamId, string pageLink);
    Task<TeamDto> CreateTeamAsync(NewTeamDto teamDto);
    Task UpdateTeamAsync(TeamDto team);
    Task DeleteTeamAsync(long teamId);
    Task<ImagePathDto> UploadLogoAsync(IFormFile file, long teamId);
}
