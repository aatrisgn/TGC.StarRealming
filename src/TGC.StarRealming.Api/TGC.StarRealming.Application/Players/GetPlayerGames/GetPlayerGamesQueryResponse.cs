using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayerGames;

/// <summary>
/// Response for the get player games query.
/// </summary>
public class GetPlayerGamesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the games the player has participated in.</summary>
	public IEnumerable<GameDto> Games { get; set; } = [];
}
