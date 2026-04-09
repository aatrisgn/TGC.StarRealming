namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents the game-side identity of a user, containing domain-relevant player information.
/// </summary>
public class Player : BaseEntity
{
	/// <summary>
	/// Gets or sets the display name of the player.
	/// </summary>
	public string PlayerName { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the player's personal catch phrase.
	/// </summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the URL to the player's profile picture.
	/// </summary>
	public Uri? ProfilePictureUrl { get; set; }

	/// <summary>
	/// Gets or sets the unique identifier of the associated profile.
	/// </summary>
	public Guid ProfileId { get; set; }

	/// <summary>
	/// Gets or sets the technical profile associated with this player.
	/// </summary>
	public UserProfile? Profile { get; set; }
}
