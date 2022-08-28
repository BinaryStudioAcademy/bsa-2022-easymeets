using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.UploadImage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace EasyMeets.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class TeamController : ControllerBase
{
    private readonly ITeamService _teamService;
    public TeamController(ITeamService teamService)
    {
        _teamService = teamService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TeamDto>> GetTeamById(long id)
    {
        return Ok(await _teamService.GetTeamAsync(id));
    }

    [HttpGet("newpagelink")]
    public async Task<ActionResult<string>> GenerateNewPageLinkAsync(long id, string teamname)
    {
        return Ok(await _teamService.GenerateNewPageLinkAsync(id, teamname));
    }
    
    [HttpGet("user-teams")]
    public async Task<ActionResult<List<TeamDto>>> GetCurrentUserTeams()
    {
        return Ok(await _teamService.GetCurrentUserTeams());
    }
    
    [HttpGet("user-teams-admin")]
    public async Task<ActionResult<List<TeamDto>>> GetCurrentUserAdminTeams()
    {
        return Ok(await _teamService.GetCurrentUserAdminTeams());
    }

    [HttpGet("validatepagelink")]
    public async Task<ActionResult<bool>> ValidatePageLinkAsync(long id, string pagelink)
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

    [HttpPut]
    public async Task<IActionResult> UpdateTeam([FromBody] UpdateTeamDto teamDto)
    {
        await _teamService.UpdateTeamAsync(teamDto);
        return Ok();
    }

    [HttpPut("uploadlogo/{teamId}")]
    public async Task<ActionResult<ImagePathDto>> UploadImageAsync([FromForm] IFormFile file, [FromRoute] long teamId)
    {
        return Ok(await _teamService.UploadLogoAsync(file, teamId));
    }

    [HttpDelete("{teamId}")]
    public async Task<ActionResult> DeleteAsync(int teamId)
    {
        await _teamService.DeleteTeamAsync(teamId);
        return NoContent();
    }
}
