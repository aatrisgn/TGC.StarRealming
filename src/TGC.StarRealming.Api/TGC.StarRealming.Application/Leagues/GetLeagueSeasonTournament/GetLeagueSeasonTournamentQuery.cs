using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournament;

/// <summary>
/// Query to retrieve a specific tournament from a league season.
/// </summary>
public class GetLeagueSeasonTournamentQuery : BaseQuery
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid LeagueId { get; set; }

	/// <summary>Gets or sets the season identifier.</summary>
	public Guid SeasonId { get; set; }

	/// <summary>Gets or sets the tournament identifier.</summary>
	public Guid TournamentId { get; set; }
}
