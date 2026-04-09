using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayer;

/// <summary>
/// Query to retrieve a specific player by ID.
/// </summary>
public class GetPlayerQuery : BaseQuery
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid PlayerId { get; set; }
}
