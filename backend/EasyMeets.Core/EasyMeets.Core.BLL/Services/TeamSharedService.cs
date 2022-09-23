using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
namespace EasyMeets.Core.BLL.Services;

public class TeamSharedService : BaseService, ITeamSharedService
{
    private readonly ILinkService _linkService;
    public TeamSharedService(EasyMeetsCoreContext context, IMapper mapper, ILinkService linkService) : base(context, mapper)
    {
        _linkService = linkService;
    }

    public async Task CreateDefaultUsersTeamAsync(User user)
    {
        var teamName = $"{user.Name.Trim()} Team";
        var teamDto = new TeamDto
        {
            Name = teamName,
            PageLink = await _linkService.GenerateNewPageLinkAsync(0, teamName),
        };

        var team = _mapper.Map<Team>(teamDto);
        var createdTeam = _context.Teams.Add(team).Entity;
        await _context.SaveChangesAsync();

        var member = new TeamMember
        {
            Role = Role.Owner,
            TeamId = createdTeam.Id,
            UserId = user.Id,
        };

        _context.TeamMembers.Add(member);
        await _context.SaveChangesAsync();
    }
}