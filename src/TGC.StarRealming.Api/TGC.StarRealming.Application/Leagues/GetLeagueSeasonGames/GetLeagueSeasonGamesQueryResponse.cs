using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonGames;

/// <summary>
/// Response for the get league season games query.
/// </summary>
public class GetLeagueSeasonGamesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the games belonging to the league season.</summary>
	public IEnumerable<GameDto> Games { get; set; } = [];
}
