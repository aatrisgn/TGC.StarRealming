using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.CreateProfile;

/// <summary>
/// Response for the create profile command.
/// </summary>
public class CreateProfileCommandResponse : BaseResponse
{
	/// <summary>Gets or sets the identifier of the newly created profile.</summary>
	public Guid ProfileId { get; set; }
}
