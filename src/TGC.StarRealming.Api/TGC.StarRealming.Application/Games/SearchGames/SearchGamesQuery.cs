using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.SearchGames;

/// <summary>
/// Query to search for games based on optional filter criteria, with paginated results of 100 per page.
/// </summary>
public class SearchGamesQuery : BaseQuery
{
	/// <summary>Gets or sets an optional list of player IDs to filter games by participants.</summary>
	public IEnumerable<Guid>? PlayerIds { get; set; }

	/// <summary>Gets or sets an optional summary text to filter games by.</summary>
	public string? Summary { get; set; }

	/// <summary>Gets or sets an optional date to filter games by.</summary>
	public DateTime? Date { get; set; }

	/// <summary>Gets or sets the page number (1-based) for paginated results.</summary>
	public int Page { get; set; } = 1;
}
