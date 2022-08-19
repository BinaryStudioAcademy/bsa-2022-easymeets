using EasyMeets.Watcher.BLL.Commands;
using EasyMeets.Watcher.BLL.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Watcher.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExampleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<string>> GetExampleText()
        => await _mediator.Send(new GetExampleTextListQuery());

    [HttpPost]
    public async Task<string> Post([FromBody] string value)
        => await _mediator.Send(new InsertValueCommand(value));
}