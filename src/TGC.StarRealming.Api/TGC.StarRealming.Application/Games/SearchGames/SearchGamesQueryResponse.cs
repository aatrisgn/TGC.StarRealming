using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.SearchGames;

/// <summary>
/// Response for the search games query.
/// </summary>
public class SearchGamesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the games matching the search criteria for the requested page.</summary>
	public IEnumerable<GameDto> Games { get; set; } = [];

	/// <summary>Gets or sets the current page number.</summary>
	public int Page { get; set; }

	/// <summary>Gets or sets the total number of pages.</summary>
	public int TotalPages { get; set; }
}
