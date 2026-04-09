using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.DeactivateLeague;

internal class DeactivateLeagueCommandHandler : BaseCommandHandler<DeactivateLeagueCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: set Active = false on league with typedCommand.LeagueId in repository
		await Task.CompletedTask.ConfigureAwait(false);

		return new DeactivateLeagueCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
