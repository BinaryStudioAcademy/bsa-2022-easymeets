using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.UploadImage;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EasyMeets.Core.BLL.Services;

public class TeamService : BaseService, ITeamService
{
    private readonly IUserService _userService;
    private readonly IUploadFileService _uploadFileService;
    public TeamService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService, IUploadFileService uploadFileService) : base(context, mapper)
    {
        _userService = userService;
        _uploadFileService = uploadFileService;
    }

    public async Task<TeamDto?> GetTeamAsync(long teamId)
    {
        var teamEntity = await GetTeamByIdAsync(teamId);
        return _mapper.Map<TeamDto>(teamEntity);
    }

    public async Task<bool> ValidatePageLinkAsync(long? teamId, string pageLink)
    {
        return !await _context.Teams.AnyAsync(t => t.Id != teamId && t.PageLink == pageLink);
    }

    public async Task<TeamDto> CreateTeamAsync(NewTeamDto newTeamDto)
    {
        var team = _mapper.Map<Team>(newTeamDto);
        var createdTeam = _context.Teams.Add(team).Entity;
        await _context.SaveChangesAsync();
        var user = await _userService.GetCurrentUserAsync();

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

    public async Task UpdateTeamAsync(UpdateTeamDto teamDto)
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

    public async Task<ImagePathDto> UploadLogoAsync(IFormFile file, long? teamId)
    {
        var imagePath = await _uploadFileService.UploadFileBlobAsync(file);

        if (teamId is null)
        {
            return new ImagePathDto() { Path = imagePath };
        }

        var teamEntity = await GetTeamByIdAsync(teamId.Value);
        teamEntity.LogoPath = imagePath;
        _context.Teams.Update(teamEntity);
        await _context.SaveChangesAsync();

        return new ImagePathDto() { Path = imagePath };
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

    public async Task<List<TeamDto>> GetCurrentUserTeams()
    {
        var currentUser = await _userService.GetCurrentUserAsync();
        var teams = await _context.TeamMembers.Where(el => el.UserId == currentUser!.Id)
            .Include(el => el.Team)
            .Select(el => el.Team)
            .ToListAsync();

        return _mapper.Map<List<TeamDto>>(teams);
    }
    public async Task<ICollection<NewMeetingMemberDto>> GetTeamMembersOfCurrentUserAsync(long? teamId)
    {
        var teamMembers = await _context.TeamMembers
            .Where(x => x.TeamId == teamId)
            .Include(x => x.User)
            .Select(a => _mapper.Map<NewMeetingMemberDto>(a))
            .ToListAsync();

        return teamMembers;
    }

    public async Task<List<TeamDto>> GetCurrentUserAdminTeams()
    {
        var currentUser = await _userService.GetCurrentUserAsync();
        var teams = await _context.TeamMembers.Where(el => el.UserId == currentUser.Id && el.Role == Role.Admin)
            .Include(el => el.Team)
            .Select(el => el.Team)
            .ToListAsync();

        return _mapper.Map<List<TeamDto>>(teams);
    }
}
