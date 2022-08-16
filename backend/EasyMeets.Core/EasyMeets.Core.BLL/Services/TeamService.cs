using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace EasyMeets.Core.BLL.Services;

public class TeamService: BaseService, ITeamService
{
    public TeamService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) {}

    public async Task<TeamDto?> GetTeamPreferences(long teamId)
    {
        var teanEntity = await _context.Teams.FirstOrDefaultAsync(_ => _.Id == teamId);
        if (teanEntity is null)
        {
            throw new KeyNotFoundException("User doesn't exist");
        }
        return _mapper.Map<TeamDto>(teanEntity);
    }

    public async Task UpdateTeamPreferences(TeamDto teamDto)
    {
        var teamEntity = await GetTeamById(teamDto.Id);
        teamEntity = _mapper.Map(teamDto, teamEntity);
        _context.Teams.Update(teamEntity);
        await _context.SaveChangesAsync();
    }

    private async Task<Team> GetTeamById(long id)
    {
        return await _context.Teams.FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("Team doesn't exist");
    }
}
