using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetMyTournaments;

/// <summary>
/// Query to retrieve all tournaments associated with a given player.
/// </summary>
public class GetMyTournamentsQuery : BaseQuery
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid PlayerId { get; set; }
}
