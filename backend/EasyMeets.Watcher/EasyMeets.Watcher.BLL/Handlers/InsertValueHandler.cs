using EasyMeets.Watcher.BLL.Commands;
using MediatR;

namespace EasyMeets.Watcher.BLL.Handlers;

public class InsertValueHandler : IRequestHandler<InsertValueCommand, string>
{
    public Task<string> Handle(InsertValueCommand request, CancellationToken cancellationToken)
        => Task.FromResult(request.Value);
}