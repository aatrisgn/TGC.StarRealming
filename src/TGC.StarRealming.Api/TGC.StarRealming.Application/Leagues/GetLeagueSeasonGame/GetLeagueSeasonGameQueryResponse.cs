using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonGame;

/// <summary>
/// Response for the get league season game query.
/// </summary>
public class GetLeagueSeasonGameQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the game, or null if not found.</summary>
	public GameDto? Game { get; set; }
}
