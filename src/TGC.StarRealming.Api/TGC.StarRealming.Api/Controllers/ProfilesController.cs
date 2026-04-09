using Microsoft.AspNetCore.Mvc;
using TGC.StarRealming.Application.Profiles.CreateProfile;
using TGC.StarRealming.Application.Profiles.GetProfile;
using TGC.StarRealming.Application.Profiles.UpdateProfile;
using TGC.WebApi.Communication;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Api.Controllers;

/// <summary>
/// Manages user profile resources.
/// </summary>
[ApiController]
[Route("profiles")]
public class ProfilesController : ControllerBase
{
	private readonly IMediator _mediator;

	/// <summary>
	/// Initializes a new instance of <see cref="ProfilesController"/>.
	/// </summary>
	public ProfilesController(IMediator mediator)
	{
		_mediator = mediator;
	}

	/// <summary>
	/// Creates a new user profile.
	/// </summary>
	[HttpPost]
	public async Task<IActionResult> CreateProfile([FromBody] CreateProfileCommand command)
	{
		var response = await _mediator.HandleCommandAsync<CreateProfileCommand, CreateProfileCommandResponse>(command);

		return ApiResult<object?>.AsOk(new { response.ProfileId }).ToActionResult();
	}

	/// <summary>
	/// Gets a specific profile by ID.
	/// </summary>
	[HttpGet("{profileId:guid}")]
	public async Task<IActionResult> GetProfile([FromRoute] Guid profileId)
	{
		var response = await _mediator.HandleQueryAsync<GetProfileQuery, GetProfileQueryResponse>(
			new GetProfileQuery { ProfileId = profileId });

		return ApiResult<object?>.AsOk(response.Profile).ToActionResult();
	}

	/// <summary>
	/// Updates an existing profile.
	/// </summary>
	[HttpPut("{profileId:guid}")]
	public async Task<IActionResult> UpdateProfile([FromRoute] Guid profileId, [FromBody] UpdateProfileCommand command)
	{
		command.ProfileId = profileId;
		await _mediator.HandleCommandAsync<UpdateProfileCommand, UpdateProfileCommandResponse>(command);

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}
}
