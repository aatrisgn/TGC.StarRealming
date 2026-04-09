using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.DeactivateLeagueSeason;

internal class DeactivateLeagueSeasonCommandHandler : BaseCommandHandler<DeactivateLeagueSeasonCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: set Active = false on season with typedCommand.SeasonId within typedCommand.LeagueId
		await Task.CompletedTask.ConfigureAwait(false);

		return new DeactivateLeagueSeasonCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
