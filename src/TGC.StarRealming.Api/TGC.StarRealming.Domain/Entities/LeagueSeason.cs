using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents a season within a league, spanning a defined period with a set of participating players and games.
/// </summary>
public class LeagueSeason : BaseEntity
{
	/// <summary>
	/// Gets or sets the description of this season.
	/// </summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the start date of the season.
	/// </summary>
	public DateTime StartDate { get; set; }

	/// <summary>
	/// Gets or sets the end date of the season.
	/// </summary>
	public DateTime EndDate { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether this season has been completed.
	/// </summary>
	public LeagueSeasonStatus Status { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the league this season belongs to.
	/// </summary>
	public Guid LeagueId { get; set; }

	/// <summary>
	/// Gets or sets the league this season belongs to.
	/// </summary>
	public League? League { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the winning player of this season.
	/// Automatically determined when the season is marked as completed.
	/// </summary>
	public Guid? WinnerId { get; set; }

	/// <summary>
	/// Gets or sets the winning player of this season.
	/// Automatically determined when the season is marked as completed.
	/// </summary>
	public Player? Winner { get; set; }

	/// <summary>
	/// Gets the players participating in this season.
	/// </summary>
	public ICollection<Player> Participants { get; } = [];

	/// <summary>
	/// Gets the non-tournament games played within this season.
	/// </summary>
	public ICollection<Game> Games { get; } = [];

	/// <summary>
	/// Gets the tournaments held within this season.
	/// Tournament games do not count towards the season standings.
	/// </summary>
	public ICollection<Tournament> Tournaments { get; } = [];
}
