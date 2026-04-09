using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournament;

/// <summary>
/// Response for the get league season tournament query.
/// </summary>
public class GetLeagueSeasonTournamentQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the tournament, or null if not found.</summary>
	public TournamentDto? Tournament { get; set; }
}
