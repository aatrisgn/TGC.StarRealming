using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayer;

/// <summary>
/// Response for the get player query.
/// </summary>
public class GetPlayerQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the player, or null if not found.</summary>
	public PlayerDto? Player { get; set; }
}
