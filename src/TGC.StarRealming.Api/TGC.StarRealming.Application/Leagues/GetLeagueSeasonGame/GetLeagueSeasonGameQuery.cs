using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonGame;

/// <summary>
/// Query to retrieve a specific game from a league season.
/// </summary>
public class GetLeagueSeasonGameQuery : BaseQuery
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid LeagueId { get; set; }

	/// <summary>Gets or sets the season identifier.</summary>
	public Guid SeasonId { get; set; }

	/// <summary>Gets or sets the game identifier.</summary>
	public Guid GameId { get; set; }
}
