using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents a 1v1 match between two players.
/// </summary>
public class Game : BaseEntity
{
	/// <summary>
	/// Gets or sets the unique identifier of the winning player.
	/// </summary>
	public Guid WinnerId { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of player one.
	/// </summary>
	public Guid PlayerOneId { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of player two.
	/// </summary>
	public Guid PlayerTwoId { get; set; }

	/// <summary>
	/// Gets or sets the winning player.
	/// </summary>
	public Player? Winner { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the losing player.
	/// </summary>
	public Guid LoserId { get; set; }

	/// <summary>
	/// Gets or sets the losing player.
	/// </summary>
	public Player? Loser { get; set; }

	/// <summary>
	/// Gets or sets the life points the winner had remaining when the match ended.
	/// </summary>
	public int WinnerLifeAtEnd { get; set; }

	/// <summary>
	/// Gets or sets the acceptance status of the winner for this game result.
	/// </summary>
	public GameAcceptanceStatus PlayerOneAcceptanceStatus { get; set; }

	/// <summary>
	/// Gets or sets the acceptance status of the loser for this game result.
	/// </summary>
	public GameAcceptanceStatus PlayerTwoAcceptanceStatus { get; set; }

	/// <summary>
	/// Gets or sets optional notes about the game.
	/// </summary>
	public string? Notes { get; set; }

	/// <summary>
	/// Gets or sets an optional summary of the game.
	/// </summary>
	public string? Summary { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the tournament this game belongs to, if any.
	/// </summary>
	public Guid? TournamentId { get; set; }

	/// <summary>
	/// Gets or sets the tournament this game belongs to, if any.
	/// </summary>
	public Tournament? Tournament { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the league season this game belongs to.
	/// Only set when the game is not part of a tournament.
	/// </summary>
	public Guid? LeagueSeasonId { get; set; }

	/// <summary>
	/// Gets or sets the league season this game belongs to.
	/// Only set when the game is not part of a tournament.
	/// </summary>
	public LeagueSeason? LeagueSeason { get; set; }
}
