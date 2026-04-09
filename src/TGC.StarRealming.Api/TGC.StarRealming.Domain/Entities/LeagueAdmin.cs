namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents the mapping between a player and a league, granting the player admin privileges for that league.
/// </summary>
public class LeagueAdmin : BaseEntity
{
	/// <summary>
	/// Gets or sets the unique identifier of the player who is an admin.
	/// </summary>
	public Guid PlayerId { get; set; }

	/// <summary>
	/// Gets or sets the admin player.
	/// </summary>
	public Player? Player { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the league being administered.
	/// </summary>
	public Guid LeagueId { get; set; }

	/// <summary>
	/// Gets or sets the league being administered.
	/// </summary>
	public League? League { get; set; }
}
