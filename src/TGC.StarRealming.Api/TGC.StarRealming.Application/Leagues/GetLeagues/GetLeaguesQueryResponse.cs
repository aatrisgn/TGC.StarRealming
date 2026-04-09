using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagues;

/// <summary>
/// Response for the get leagues query.
/// </summary>
public class GetLeaguesQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the list of leagues.</summary>
	public IEnumerable<LeagueDto> Leagues { get; set; } = [];
}
