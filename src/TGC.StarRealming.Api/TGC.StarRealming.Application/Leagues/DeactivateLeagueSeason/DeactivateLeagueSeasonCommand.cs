using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.DeactivateLeagueSeason;

/// <summary>
/// Command to deactivate a league season.
/// </summary>
public class DeactivateLeagueSeasonCommand : BaseCommand
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid LeagueId { get; set; }

	/// <summary>Gets or sets the season identifier to deactivate.</summary>
	public Guid SeasonId { get; set; }
}
