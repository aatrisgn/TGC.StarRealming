using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetTournament;

/// <summary>
/// Response for the get tournament query.
/// </summary>
public class GetTournamentQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the tournament, or null if not found.</summary>
	public TournamentDto? Tournament { get; set; }
}
