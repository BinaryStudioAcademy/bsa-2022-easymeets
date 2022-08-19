using MediatR;

namespace EasyMeets.Watcher.BLL.Commands;

public record InsertValueCommand(string Value) : IRequest<string>;