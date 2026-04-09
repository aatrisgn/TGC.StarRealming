using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetGame;

/// <summary>
/// Query to retrieve a specific game by ID.
/// </summary>
public class GetGameQuery : BaseQuery
{
	/// <summary>Gets or sets the game identifier.</summary>
	public Guid GameId { get; set; }
}
