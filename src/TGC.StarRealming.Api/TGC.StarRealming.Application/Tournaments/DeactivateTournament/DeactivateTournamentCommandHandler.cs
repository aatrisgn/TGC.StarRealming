using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.DeactivateTournament;

internal class DeactivateTournamentCommandHandler : BaseCommandHandler<DeactivateTournamentCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: set Active = false on tournament with typedCommand.TournamentId in repository
		await Task.CompletedTask.ConfigureAwait(false);

		return new DeactivateTournamentCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
