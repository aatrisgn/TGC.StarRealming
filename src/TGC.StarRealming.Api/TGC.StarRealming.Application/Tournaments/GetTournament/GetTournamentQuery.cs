using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetTournament;

/// <summary>
/// Query to retrieve a specific tournament by ID.
/// </summary>
public class GetTournamentQuery : BaseQuery
{
	/// <summary>Gets or sets the tournament identifier.</summary>
	public Guid TournamentId { get; set; }
}
