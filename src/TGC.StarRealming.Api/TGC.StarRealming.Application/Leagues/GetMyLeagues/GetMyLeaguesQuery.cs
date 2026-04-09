using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetMyLeagues;

/// <summary>
/// Query to retrieve all leagues associated with a given player.
/// </summary>
public class GetMyLeaguesQuery : BaseQuery
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid PlayerId { get; set; }
}
