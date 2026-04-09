using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetMyLeagues;

/// <summary>
/// Response for the get my leagues query.
/// </summary>
public class GetMyLeaguesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the leagues associated with the player.</summary>
	public IEnumerable<LeagueDto> Leagues { get; set; } = [];
}
