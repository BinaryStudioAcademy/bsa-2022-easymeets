using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using Microsoft.AspNetCore.Mvc;
namespace EasyMeets.Core.WebAPI.Controllers;

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
    public async Task<ActionResult<TeamDto>> GetPreferencesById(long id)
    {
        var teamDto = await _teamService.GetTeamPreferences(id);
        if (teamDto is null)
        {
            return NotFound();
        }
        return Ok(teamDto);
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePreferences([FromBody] TeamDto teamDto)
    {
        await _teamService.UpdateTeamPreferences(teamDto);
        return Ok();
    }
}
