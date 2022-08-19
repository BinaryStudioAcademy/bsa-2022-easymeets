using EasyMeets.Watcher.BLL.Queries;
using MediatR;

namespace EasyMeets.Watcher.BLL.Handlers;

public class GetExampleTextListHandler : IRequestHandler<GetExampleTextListQuery, List<string>>
{
    private readonly List<string> _exampleTextList = new()
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<List<string>> Handle(GetExampleTextListQuery request, CancellationToken cancellationToken)
        => Task.FromResult(_exampleTextList);
}