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
            Role = Role.Owner,
            TeamId = createdTeam.Id,
            UserId = user.Id,
        };

        _context.TeamMembers.Add(member);
        await _context.SaveChangesAsync();

        return _mapper.Map<TeamDto>(createdTeam);
    }

    public async Task<List<TeamMemberDto>> GetTeamMembersAsync(long teamId)
    {
        var members = await _context.TeamMembers
           .Where(t => t.TeamId == teamId)
           .Include(t => t.User)
           .Select(y =>
                new TeamMemberDto()
                {
                    Id = y.Id,
                    Name = y.User.Name,
                    Email = y.User.Email,
                    Image = y.User.ImagePath,
                    Role = y.Role,
                    ConnectedCalendar = _context.Calendars.Where(p => p.UserId == y.Id).Select(p => p.ConnectedCalendar).FirstOrDefault(),
                    PageLink = y.User.PersonalUrl,
                }
           ).ToListAsync();

        return members;
    }

    public async Task UpdateTeamAsync(UpdateTeamDto teamDto)
    {
        if (await UserHasRole(teamDto.Id, Role.Admin) || await UserHasRole(teamDto.Id, Role.Owner))
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

    public async Task CreateTeamMemberAsync(TeamMemberDto teamMemberDto, long teamId)
    {
        var team = await GetTeamByIdAsync(teamId) ?? throw new KeyNotFoundException("Team doesn't exist");
        if (team is not null)
        {
            var member = new TeamMember()
            {
                Role = Role.Member,
                TeamId = team.Id,
                UserId = teamMemberDto.Id,
            };

            _context.TeamMembers.Add(member);
            await _context.SaveChangesAsync();
        }
    }

    public async Task UpdateTeamMemberRoleAsync(TeamMemberDto teamMemberDto)
    {
        var teamMember = await _context.TeamMembers.FirstOrDefaultAsync(s => s.Id == teamMemberDto.Id) ??
            throw new KeyNotFoundException("Team member doesn't exist");
        teamMember.Role = teamMemberDto.Role;

        _context.TeamMembers.Update(teamMember);
        await _context.SaveChangesAsync();
    }


    public async Task DeleteTeamAsync(long teamId)
    {
        if (await UserHasRole(teamId, Role.Admin))
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

    public async Task DeleteTeamMemberAsync(long teamMemberId)
    {
        var teamMember = await _context.TeamMembers.FirstAsync(s => s.Id == teamMemberId);
        _context.TeamMembers.Remove(teamMember);
        await _context.SaveChangesAsync();
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

    private async Task<bool> UserHasRole(long teamId, Role role)
    {
        var user = await _userService.GetCurrentUserAsync();
        var hasRole = await _context.Teams.Where(t => t.Id == teamId)
            .Include(t => t.TeamMembers)
            .SelectMany(t => t.TeamMembers)
            .AnyAsync(m => m.UserId == user.Id && m.Role == role);

        return hasRole;
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

        foreach (var teamMember in teamMembers)
        {
            teamMember.UnavailabilityItems = await GetMemberUnavailability(teamMember.Id);
        }

        return teamMembers;
    }

    public async Task<List<TeamDto>> GetCurrentUserAdminAndOwnerTeams()
    {
        var currentUser = await _userService.GetCurrentUserAsync();
        var teams = await _context.TeamMembers.Where(el => el.UserId == currentUser.Id && (el.Role == Role.Admin || el.Role == Role.Owner))
            .Include(el => el.Team)
            .Select(el => el.Team)
            .ToListAsync();

        return _mapper.Map<List<TeamDto>>(teams);
    }

    private async Task<List<UnavailabilityItemDto>> GetMemberUnavailability(long teamMemberId)
    {
        var member = await _context.TeamMembers
            .FirstOrDefaultAsync(m => m.Id == teamMemberId) ?? throw new KeyNotFoundException("Invalid team member id");

        var meetings = await _context.Meetings
            .Include(m => m.MeetingMembers)
                .ThenInclude(mm => mm.TeamMember)
            .Where(m => m.MeetingMembers.Any(mm => mm.TeamMember.Id == teamMemberId))
            .ToListAsync();

        var calendarEvents = await _context.CalendarVisibleForTeams
            .Include(c => c.Calendar)
                .ThenInclude(c => c.CalendarEvents)
            .Where(c => c.Team.Id == member.TeamId && c.Calendar.UserId == member.UserId)
            .SelectMany(c => c.Calendar.CalendarEvents)
            .ToListAsync();

        return _mapper.Map<List<UnavailabilityItemDto>>(meetings)
            .Union(_mapper.Map<List<UnavailabilityItemDto>>(calendarEvents))
            .Distinct()
            .ToList();
    }
}
