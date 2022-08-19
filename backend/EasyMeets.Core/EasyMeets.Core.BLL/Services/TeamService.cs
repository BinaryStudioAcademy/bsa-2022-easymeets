using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace EasyMeets.Core.BLL.Services;

public class TeamService : BaseService, ITeamService
{
    private IUserService _userService;
    public TeamService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService) : base(context, mapper)
    {
        _userService = userService;
    }

    public async Task<TeamDto?> GetTeamAsync(long teamId)
    {
        var teamEntity = await GetTeamByIdAsync(teamId);
        return _mapper.Map<TeamDto>(teamEntity);
    }

    public async Task<string> GenerateNewPageLinkAsync(long teamId, string teamName)
    {
        var pageLinks = _context.Teams.Where(t => t.Id != teamId).Select(t => t.PageLink);
        var pageLink = teamName;

        if (!pageLinks.Any(t => t == pageLink))
        {
            return await Task.FromResult(pageLink);
        }

        int index = 1;

        while (pageLinks.Any(t => t == $"{pageLink}{index}"))
        {
            index++;
        }

        return await Task.FromResult($"{pageLink}{index}");
    }

    public Task<bool> ValidatePageLinkAsync(long teamId, string pageLink)
    {
        var teams = _context.Teams.Where(t => t.Id != teamId && t.PageLink == pageLink);
        return Task.FromResult(!teams.Any());
    }

    public async Task<TeamDto> CreateTeamAsync(NewTeamDto newTeamDto)
    {
        var team = _mapper.Map<Team>(newTeamDto);
        var createdTeam = _context.Teams.Add(team).Entity;
        var user = await _userService.GetCurrentUserAsync();
        await _context.SaveChangesAsync();

        var member = new TeamMember()
        {
            Role = Role.Admin,
            TeamId = createdTeam.Id,
            UserId = user.Id,
        };

        _context.TeamMembers.Add(member);
        await _context.SaveChangesAsync();

        return _mapper.Map<TeamDto>(createdTeam);
    }

    public async Task UpdateTeamAsync(TeamDto teamDto)
    {
        if (await UserIsAdmin(teamDto.Id))
        {
            var teamEntity = await GetTeamByIdAsync(teamDto.Id);
            teamEntity = _mapper.Map(teamDto, teamEntity);
            _context.Teams.Update(teamEntity);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("User is not allowed enough access");
        }
    }

    public async Task DeleteTeamAsync(long teamId)
    {
        if (await UserIsAdmin(teamId))
        {
            var teamEntity = await GetTeamByIdAsync(teamId);
            _context.Teams.Remove(teamEntity);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("User is not allowed enough access");
        }
    }

    private async Task<bool> UserIsAdmin(long teamId)
    {
        var user = await _userService.GetCurrentUserAsync();
        var isAdmin = await _context.Teams.Where(t => t.Id == teamId)
            .Include(t => t.TeamMembers)
            .SelectMany(t => t.TeamMembers)
            .AnyAsync(m => m.UserId == user.Id && m.Role == Role.Admin);

        return isAdmin;
    }

    private async Task<Team> GetTeamByIdAsync(long id)
    {
        return await _context.Teams
            .FirstOrDefaultAsync(t => t.Id == id) ?? throw new KeyNotFoundException("Team doesn't exist");
    }
}
