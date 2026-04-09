using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetMyGames;

/// <summary>
/// Response for the get my games query.
/// </summary>
public class GetMyGamesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the games for the requested page.</summary>
	public IEnumerable<GameDto> Games { get; set; } = [];

	/// <summary>Gets or sets the current page number.</summary>
	public int Page { get; set; }

	/// <summary>Gets or sets the total number of pages.</summary>
	public int TotalPages { get; set; }
}
