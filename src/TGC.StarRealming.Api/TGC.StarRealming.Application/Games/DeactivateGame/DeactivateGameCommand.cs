using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.DeactivateGame;

/// <summary>
/// Command to deactivate a game.
/// </summary>
public class DeactivateGameCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the game to deactivate.</summary>
	public Guid GameId { get; set; }
}
