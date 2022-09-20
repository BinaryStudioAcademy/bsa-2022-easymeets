using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using System.Web;

namespace EasyMeets.Core.BLL.Services;

public class TeamSharedService : BaseService, ITeamSharedService
{
    public TeamSharedService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task CreateDefaultUsersTeamAsync(User user)
    {
        var teamName = $"{user.Name.Trim()} Team";
        var teamDto = new TeamDto
        {
            Name = teamName,
            PageLink = await GenerateNewPageLinkAsync(0, teamName),
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

    public async Task<string> GenerateNewPageLinkAsync(long teamId, string teamName)
    {
        if (!await _context.Teams.AnyAsync(t => t.Id != teamId && t.PageLink == teamName))
        {
            return teamName;
        }

        int index = 1;

        while (await _context.Teams.AnyAsync(t => t.Id != teamId && t.PageLink == $"{teamName}{index}"))
        {
            index++;
        }

        return $"{teamName}{index}";
    }
    public string GenerateInvivationLink(IUrlHelper Url, long? userId, string userEmail, long teamId)
    {
        var teamDataJson = userId == null ?
                JsonConvert.SerializeObject(new UserInvitationDataDto { UserEmail = userEmail, TeamId = teamId }) :
                JsonConvert.SerializeObject(new UserInvitationDataDto { UserId = userId, UserEmail = userEmail, TeamId = teamId });

        string urlEncodedTeamData = HttpUtility.UrlEncode(teamDataJson, Encoding.UTF8);

        var url = Url.Link("AcceptInvitation", new { ecodedTeamData = urlEncodedTeamData });

        return url;
    }
}