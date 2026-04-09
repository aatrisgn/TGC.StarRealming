using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.CreateGame;

internal class CreateGameCommandHandler : BaseCommandHandler<CreateGameCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: create game in repository
		// PlayerOneAcceptanceStatus = GameAcceptanceStatus.Accepted (initiator auto-accepts)
		// PlayerTwoAcceptanceStatus = GameAcceptanceStatus.Pending
		await Task.CompletedTask.ConfigureAwait(false);

		return new CreateGameCommandResponse
		{
			StatusCode = HttpStatusCode.OK,
			GameId = Guid.NewGuid()
		};
	}
}
