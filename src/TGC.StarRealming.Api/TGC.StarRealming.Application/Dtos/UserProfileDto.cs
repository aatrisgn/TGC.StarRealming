namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a user profile (Azure B2C shadow copy).
/// </summary>
public class UserProfileDto
{
	/// <summary>Gets or sets the profile identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the Azure B2C object ID.</summary>
	public string AzureB2CId { get; set; } = string.Empty;

	/// <summary>Gets or sets the email address.</summary>
	public string Email { get; set; } = string.Empty;
}
