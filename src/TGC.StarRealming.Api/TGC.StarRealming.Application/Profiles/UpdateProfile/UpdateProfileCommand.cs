using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.UpdateProfile;

/// <summary>
/// Command to update an existing user profile.
/// </summary>
public class UpdateProfileCommand : BaseCommand
{
	/// <summary>Gets or sets the identifier of the profile to update.</summary>
	public Guid ProfileId { get; set; }

	/// <summary>Gets or sets the updated email address.</summary>
	public string Email { get; set; } = string.Empty;
}
