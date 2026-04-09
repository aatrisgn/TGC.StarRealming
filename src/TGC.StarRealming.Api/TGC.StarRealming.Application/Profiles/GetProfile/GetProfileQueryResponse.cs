using TGC.StarRealming.Application.Dtos;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.GetProfile;

/// <summary>
/// Response for the get profile query.
/// </summary>
public class GetProfileQueryResponse : BaseResponse
{
	/// <summary>Gets or sets the profile, or null if not found.</summary>
	public UserProfileDto? Profile { get; set; }
}
