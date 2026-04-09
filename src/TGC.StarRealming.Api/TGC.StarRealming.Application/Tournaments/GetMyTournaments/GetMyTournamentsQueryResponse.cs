using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetMyTournaments;

/// <summary>
/// Response for the get my tournaments query.
/// </summary>
public class GetMyTournamentsQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the tournaments associated with the player.</summary>
	public IEnumerable<TournamentDto> Tournaments { get; set; } = [];
}
