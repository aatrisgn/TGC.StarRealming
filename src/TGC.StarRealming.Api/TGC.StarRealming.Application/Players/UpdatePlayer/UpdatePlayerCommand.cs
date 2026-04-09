using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.UpdatePlayer;

/// <summary>
/// Command to update an existing player.
/// </summary>
public class UpdatePlayerCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the player to update.</summary>
	public Guid PlayerId { get; set; }

	/// <summary>Gets or sets the updated player display name.</summary>
	public string PlayerName { get; set; } = string.Empty;

	/// <summary>Gets or sets the updated catch phrase.</summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>Gets or sets the updated URL to the player's profile picture.</summary>
	public Uri? ProfilePictureUrl { get; set; }
}
