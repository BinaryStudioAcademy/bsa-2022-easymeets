using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ITeamSharedService
{
    Task CreateDefaultUsersTeamAsync(User user);
}