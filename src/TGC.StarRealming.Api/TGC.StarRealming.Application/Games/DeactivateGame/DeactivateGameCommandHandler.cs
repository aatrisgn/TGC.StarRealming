using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.DeactivateGame;

internal class DeactivateGameCommandHandler : BaseCommandHandler<DeactivateGameCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: set Active = false on game with typedCommand.GameId in repository
		await Task.CompletedTask.ConfigureAwait(false);

		return new DeactivateGameCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
