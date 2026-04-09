namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents the technical profile of a user, containing authentication-related information mirrored from Azure B2C.
/// </summary>
public class UserProfile : BaseEntity
{
	/// <summary>
	/// Gets or sets the Azure B2C object ID for this profile.
	/// </summary>
	public string AzureB2CId { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the email address mirrored from Azure B2C.
	/// </summary>
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the player associated with this profile.
	/// </summary>
	public Player? Player { get; set; }
}
