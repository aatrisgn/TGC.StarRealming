using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.UpdatePlayer;

internal class UpdatePlayerCommandHandler : BaseCommandHandler<UpdatePlayerCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: update player in repository using typedCommand properties
		await Task.CompletedTask.ConfigureAwait(false);

		return new UpdatePlayerCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
