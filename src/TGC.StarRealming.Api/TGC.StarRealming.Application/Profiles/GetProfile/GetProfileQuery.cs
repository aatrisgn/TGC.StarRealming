using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.GetProfile;

/// <summary>
/// Query to retrieve a specific user profile by ID.
/// </summary>
public class GetProfileQuery : BaseQuery
{
	/// <summary>Gets or sets the profile identifier.</summary>
	public Guid ProfileId { get; set; }
}
