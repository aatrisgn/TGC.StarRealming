namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a player.
/// </summary>
public class PlayerDto
{
	/// <summary>Gets or sets the player identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the player display name.</summary>
	public string PlayerName { get; set; } = string.Empty;

	/// <summary>Gets or sets the player's catch phrase.</summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>Gets or sets the URL to the player's profile picture.</summary>
	public Uri? ProfilePictureUrl { get; set; }

	/// <summary>Gets or sets the identifier of the associated profile.</summary>
	public Guid ProfileId { get; set; }
}
