using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetMyGames;

/// <summary>
/// Query to retrieve paginated games for a given player, with 100 games per page.
/// </summary>
public class GetMyGamesQuery : BaseQuery
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid PlayerId { get; set; }

	/// <summary>Gets or sets the page number (1-based) for paginated results.</summary>
	public int Page { get; set; } = 1;
}
