using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.CreateProfile;

/// <summary>
/// Command to create a new user profile.
/// </summary>
public class CreateProfileCommand : BaseCommand
{
	/// <summary>Gets or sets the Azure B2C object ID.</summary>
	public string AzureB2CId { get; set; } = string.Empty;

	/// <summary>Gets or sets the email address.</summary>
	public string Email { get; set; } = string.Empty;
}
