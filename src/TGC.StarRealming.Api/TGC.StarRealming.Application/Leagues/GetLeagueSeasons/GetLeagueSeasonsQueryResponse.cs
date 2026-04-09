using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasons;

/// <summary>
/// Response for the get league seasons query.
/// </summary>
public class GetLeagueSeasonsQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the seasons belonging to the league.</summary>
	public IEnumerable<LeagueSeasonDto> Seasons { get; set; } = [];
}
