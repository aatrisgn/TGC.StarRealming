using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.UpdateGame;

internal class UpdateGameCommandHandler : BaseCommandHandler<UpdateGameCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: update game in repository using typedCommand properties
		await Task.CompletedTask.ConfigureAwait(false);

		return new UpdateGameCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
