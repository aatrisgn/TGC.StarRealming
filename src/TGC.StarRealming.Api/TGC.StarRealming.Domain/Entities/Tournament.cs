using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents a tournament within a league season, consisting of a fixed set of games determined by its type and player count.
/// </summary>
public class Tournament : BaseEntity
{
	/// <summary>
	/// Gets or sets the name of the tournament.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the format type of the tournament.
	/// </summary>
	public TournamentType Type { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the league season this tournament belongs to.
	/// </summary>
	public Guid LeagueSeasonId { get; set; }

	/// <summary>
	/// Gets or sets the league season this tournament belongs to.
	/// </summary>
	public LeagueSeason? LeagueSeason { get; set; }

	/// <summary>
	/// Gets the players participating in this tournament.
	/// </summary>
	public ICollection<Player> Participants { get; } = [];

	/// <summary>
	/// Gets the games played within this tournament.
	/// </summary>
	public ICollection<Game> Games { get; } = [];
}
