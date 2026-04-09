using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetGame;

/// <summary>
/// Response for the get game query.
/// </summary>
public class GetGameQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the game, or null if not found.</summary>
	public GameDto? Game { get; set; }
}
