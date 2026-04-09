using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.CreatePlayer;

/// <summary>
/// Command to create a new player linked to an existing profile.
/// </summary>
public class CreatePlayerCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the profile to link to the new player.</summary>
	public Guid ProfileId { get; set; }

	/// <summary>Gets or sets the player display name.</summary>
	public string PlayerName { get; set; } = string.Empty;

	/// <summary>Gets or sets the player's catch phrase.</summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>Gets or sets the URL to the player's profile picture.</summary>
	public Uri? ProfilePictureUrl { get; set; }
}
