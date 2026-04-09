using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.DeactivateLeague;

/// <summary>
/// Command to deactivate a league.
/// </summary>
public class DeactivateLeagueCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the league to deactivate.</summary>
	public Guid LeagueId { get; set; }
}
