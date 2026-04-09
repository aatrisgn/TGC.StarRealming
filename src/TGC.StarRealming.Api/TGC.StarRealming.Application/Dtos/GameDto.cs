using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a game.
/// </summary>
public class GameDto
{
	/// <summary>Gets or sets the game identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the identifier of player one.</summary>
	public Guid PlayerOneId { get; set; }

	/// <summary>Gets or sets the identifier of player two.</summary>
	public Guid PlayerTwoId { get; set; }

	/// <summary>Gets or sets the identifier of the winning player.</summary>
	public Guid WinnerId { get; set; }

	/// <summary>Gets or sets the identifier of the losing player.</summary>
	public Guid LoserId { get; set; }

	/// <summary>Gets or sets the life points the winner had remaining when the game ended.</summary>
	public int WinnerLifeAtEnd { get; set; }

	/// <summary>Gets or sets the acceptance status of player one.</summary>
	public GameAcceptanceStatus PlayerOneAcceptanceStatus { get; set; }

	/// <summary>Gets or sets the acceptance status of player two.</summary>
	public GameAcceptanceStatus PlayerTwoAcceptanceStatus { get; set; }

	/// <summary>Gets or sets optional notes about the game.</summary>
	public string? Notes { get; set; }

	/// <summary>Gets or sets an optional summary of the game.</summary>
	public string? Summary { get; set; }

	/// <summary>Gets or sets the identifier of the tournament this game belongs to, if any.</summary>
	public Guid? TournamentId { get; set; }

	/// <summary>Gets or sets the identifier of the league season this game belongs to, if any.</summary>
	public Guid? LeagueSeasonId { get; set; }
}
