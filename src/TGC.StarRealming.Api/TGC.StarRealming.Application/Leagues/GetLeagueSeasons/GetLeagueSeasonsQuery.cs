using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasons;

/// <summary>
/// Query to retrieve all seasons for a given league.
/// </summary>
public class GetLeagueSeasonsQuery : BaseQuery
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid LeagueId { get; set; }
}
