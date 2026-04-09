using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.DeactivateTournament;

/// <summary>
/// Command to deactivate a tournament.
/// </summary>
public class DeactivateTournamentCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the tournament to deactivate.</summary>
	public Guid TournamentId { get; set; }
}
