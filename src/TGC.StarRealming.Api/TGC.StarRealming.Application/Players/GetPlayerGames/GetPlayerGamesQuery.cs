using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayerGames;

/// <summary>
/// Query to retrieve all games a given player has participated in.
/// </summary>
public class GetPlayerGamesQuery : BaseQuery
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid PlayerId { get; set; }
}
