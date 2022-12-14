using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.UploadImage;
using EasyMeets.Core.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace EasyMeets.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class TeamController : ControllerBase
{
    private readonly ITeamService _teamService;
    private readonly ITeamSharedService _sharedService;
    public TeamController(ITeamService teamService, ITeamSharedService sharedService)
    {
        _teamService = teamService;
        _sharedService = sharedService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TeamDto>> GetTeamById(long id)
    {
        return Ok(await _teamService.GetTeamAsync(id));
    }

    [HttpGet("newpagelink")]
    public async Task<ActionResult<string>> GenerateNewPageLinkAsync(long id, string teamname)
    {
        return Ok(await _sharedService.GenerateNewPageLinkAsync(id, teamname));
    }

    [HttpGet("user-teams")]
    public async Task<ActionResult<List<TeamDto>>> GetCurrentUserTeams()
    {
        return Ok(await _teamService.GetCurrentUserTeams());
    }

    [HttpGet("team-members/{teamId}")]
    public async Task<ActionResult<List<TeamMemberDto>>> GetTeamMembersAsync(long teamId)
    {
        return Ok(await _teamService.GetTeamMembersAsync(teamId));
    }

    [HttpGet("validatepagelink")]
    public async Task<ActionResult<bool>> ValidatePageLinkAsync(long? id, string pagelink)
    {
        return Ok(await _teamService.ValidatePageLinkAsync(id, pagelink));
    }

    [HttpPost]
    public async Task<ActionResult<TeamDto>> CreateAsync(NewTeamDto newTeamDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        return Ok(await _teamService.CreateTeamAsync(newTeamDto));
    }

    [HttpPost("members/{teamId?}")]
    public async Task<IActionResult> UpdateTeamMembersAsync([FromBody] TeamMemberDto[] teamMembersDto, long teamId)
    {
        await _teamService.CreateTeamMembersAsync(teamMembersDto, teamId);
        return Ok();
    }

    [HttpPut("members")]
    public async Task<IActionResult> UpdateTeamMemberRoleAsync([FromBody] TeamMemberDto teamMemberDto)
    {
        await _teamService.UpdateTeamMemberRoleAsync(teamMemberDto);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTeam([FromBody] UpdateTeamDto teamDto)
    {
        await _teamService.UpdateTeamAsync(teamDto);
        return Ok();
    }

    [HttpPut("uploadlogo/{teamId?}")]
    public async Task<ActionResult<ImagePathDto>> UploadImageAsync([FromForm] IFormFile file, [FromRoute] long? teamId)
    {
        return Ok(await _teamService.UploadLogoAsync(file, teamId));
    }

    [HttpDelete("{teamId:long}/logo")]
    public async Task<ActionResult> DeleteLogo(long teamId)
    {
        await _teamService.DeleteLogo(teamId);
        return NoContent();
    }

    [HttpDelete("{teamId}")]
    public async Task<ActionResult> DeleteAsync(int teamId)
    {
        await _teamService.DeleteTeamAsync(teamId);
        return NoContent();
    }

    [HttpDelete("deleteMember/{teamMemberId}")]
    public async Task<ActionResult> DeleteTeamMemberAsync(int teamMemberId)
    {
        await _teamService.DeleteTeamMemberAsync(teamMemberId);
        return NoContent();
    }
}
