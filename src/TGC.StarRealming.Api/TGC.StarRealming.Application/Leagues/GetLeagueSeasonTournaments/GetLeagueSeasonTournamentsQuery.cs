using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournaments;

/// <summary>
/// Query to retrieve all tournaments for a given league season.
/// </summary>
public class GetLeagueSeasonTournamentsQuery : BaseQuery
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid LeagueId { get; set; }

	/// <summary>Gets or sets the season identifier.</summary>
	public Guid SeasonId { get; set; }
}
