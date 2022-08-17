using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace EasyMeets.Core.BLL.Services;

public class TeamService : BaseService, ITeamService
{
    public TeamService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) {}

    public async Task<TeamDto?> GetTeamAsync(long teamId)
    {
        var teamEntity = await GetTeamById(teamId);
        return _mapper.Map<TeamDto>(teamEntity);
    }

    public async Task<TeamDto> CreateTeamAsync(NewTeamDto newTeamDto)
    {
        var team = _mapper.Map<Team>(newTeamDto);

        var createdTeam = _context.Add(team).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<TeamDto>(createdTeam);
    }

    public async Task UpdateTeamAsync(TeamDto teamDto)
    {
        var teamEntity = await GetTeamById(teamDto.Id);
        teamEntity = _mapper.Map(teamDto, teamEntity);
        _context.Teams.Update(teamEntity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTeamAsync(int teamId)
    {
        var teamEntity = await GetTeamById(teamId);
        _context.Teams.Remove(teamEntity);
        await _context.SaveChangesAsync();
    }

    private async Task<Team> GetTeamById(long id)
    {
        return await _context.Teams
            .FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("Team doesn't exist");
    }
}
