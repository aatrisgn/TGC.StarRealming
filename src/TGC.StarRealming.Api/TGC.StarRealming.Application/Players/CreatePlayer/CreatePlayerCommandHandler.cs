using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.CreatePlayer;

internal class CreatePlayerCommandHandler : BaseCommandHandler<CreatePlayerCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: create player in repository using typedCommand properties
		await Task.CompletedTask.ConfigureAwait(false);

		return new CreatePlayerCommandResponse
		{
			StatusCode = HttpStatusCode.OK,
			PlayerId = Guid.NewGuid()
		};
	}
}
