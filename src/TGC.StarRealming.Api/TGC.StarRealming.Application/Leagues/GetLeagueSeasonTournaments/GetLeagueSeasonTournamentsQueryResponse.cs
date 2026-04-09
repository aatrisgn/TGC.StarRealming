using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournaments;

/// <summary>
/// Response for the get league season tournaments query.
/// </summary>
public class GetLeagueSeasonTournamentsQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the tournaments belonging to the league season.</summary>
	public IEnumerable<TournamentDto> Tournaments { get; set; } = [];
}
