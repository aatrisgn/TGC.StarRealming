using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.CreateGame;

/// <summary>
/// Command to create a new game. Player one is the initiator and is auto-accepted.
/// Player two starts with a pending acceptance status.
/// </summary>
public class CreateGameCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of player one (the game initiator).</summary>
	public Guid PlayerOneId { get; set; }

	/// <summary>Gets or sets the identifier of player two.</summary>
	public Guid PlayerTwoId { get; set; }

	/// <summary>Gets or sets the identifier of the winning player.</summary>
	public Guid WinnerId { get; set; }

	/// <summary>Gets or sets the identifier of the losing player.</summary>
	public Guid LoserId { get; set; }

	/// <summary>Gets or sets the life points the winner had remaining when the game ended.</summary>
	public int WinnerLifeAtEnd { get; set; }

	/// <summary>Gets or sets optional notes about the game.</summary>
	public string? Notes { get; set; }

	/// <summary>Gets or sets an optional summary of the game.</summary>
	public string? Summary { get; set; }

	/// <summary>Gets or sets the identifier of the tournament this game belongs to, if any.</summary>
	public Guid? TournamentId { get; set; }

	/// <summary>Gets or sets the identifier of the league season this game belongs to, if any.</summary>
	public Guid? LeagueSeasonId { get; set; }
}
