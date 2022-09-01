using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamSharedService
{
    Task CreateDefaultUsersTeamAsync(User user);
    Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
}