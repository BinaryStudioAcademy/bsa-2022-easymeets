using MediatR;

namespace EasyMeets.Watcher.BLL.Queries;

public record GetExampleTextListQuery : IRequest<List<string>>;