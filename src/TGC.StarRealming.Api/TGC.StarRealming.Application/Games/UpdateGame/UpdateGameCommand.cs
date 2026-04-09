using TGC.StarRealming.Domain.Enums;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.UpdateGame;

/// <summary>
/// Command to update an existing game, including acceptance statuses, score, and result.
/// </summary>
public class UpdateGameCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the game to update.</summary>
	public Guid GameId { get; set; }

	/// <summary>Gets or sets the identifier of the winning player.</summary>
	public Guid WinnerId { get; set; }

	/// <summary>Gets or sets the identifier of the losing player.</summary>
	public Guid LoserId { get; set; }

	/// <summary>Gets or sets the life points the winner had remaining when the game ended.</summary>
	public int WinnerLifeAtEnd { get; set; }

	/// <summary>Gets or sets the updated acceptance status of player one.</summary>
	public GameAcceptanceStatus PlayerOneAcceptanceStatus { get; set; }

	/// <summary>Gets or sets the updated acceptance status of player two.</summary>
	public GameAcceptanceStatus PlayerTwoAcceptanceStatus { get; set; }

	/// <summary>Gets or sets updated notes about the game.</summary>
	public string? Notes { get; set; }

	/// <summary>Gets or sets an updated summary of the game.</summary>
	public string? Summary { get; set; }
}
