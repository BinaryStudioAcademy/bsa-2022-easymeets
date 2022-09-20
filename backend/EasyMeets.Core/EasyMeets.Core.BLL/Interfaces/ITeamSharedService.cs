using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamSharedService
{
    Task CreateDefaultUsersTeamAsync(User user);
    Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
    string GenerateInvivationLink(IUrlHelper Url, long? userId, string userEmail, long teamId);
}