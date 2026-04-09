using Microsoft.AspNetCore.Mvc;
using TGC.StarRealming.Application.Players.CreatePlayer;
using TGC.StarRealming.Application.Players.GetPlayer;
using TGC.StarRealming.Application.Players.GetPlayerGames;
using TGC.StarRealming.Application.Players.UpdatePlayer;
using TGC.WebApi.Communication;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Api.Controllers;

/// <summary>
/// Manages player resources.
/// </summary>
[ApiController]
[Route("players")]
public class PlayersController : ControllerBase
{
	private readonly IMediator _mediator;

	/// <summary>
	/// Initializes a new instance of <see cref="PlayersController"/>.
	/// </summary>
	public PlayersController(IMediator mediator)
	{
		_mediator = mediator;
	}

	/// <summary>
	/// Gets a specific player by ID.
	/// </summary>
	[HttpGet("{playerId:guid}")]
	public async Task<IActionResult> GetPlayer([FromRoute] Guid playerId)
	{
		var response = await _mediator.HandleQueryAsync<GetPlayerQuery, GetPlayerQueryResponse>(
			new GetPlayerQuery { PlayerId = playerId });

		return ApiResult<object?>.AsOk(response.Player).ToActionResult();
	}

	/// <summary>
	/// Gets all games a given player has participated in.
	/// </summary>
	[HttpGet("{playerId:guid}/games")]
	public async Task<IActionResult> GetPlayerGames([FromRoute] Guid playerId)
	{
		var response = await _mediator.HandleQueryAsync<GetPlayerGamesQuery, GetPlayerGamesQueryResponse>(
			new GetPlayerGamesQuery { PlayerId = playerId });

		return ApiResult<object?>.AsOk(response.Games).ToActionResult();
	}

	/// <summary>
	/// Creates a new player linked to an existing profile.
	/// </summary>
	[HttpPost]
	public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerCommand command)
	{
		var response = await _mediator.HandleCommandAsync<CreatePlayerCommand, CreatePlayerCommandResponse>(command);

		return ApiResult<object?>.AsOk(new { response.PlayerId }).ToActionResult();
	}

	/// <summary>
	/// Updates an existing player.
	/// </summary>
	[HttpPut("{playerId:guid}")]
	public async Task<IActionResult> UpdatePlayer([FromRoute] Guid playerId, [FromBody] UpdatePlayerCommand command)
	{
		command.PlayerId = playerId;
		await _mediator.HandleCommandAsync<UpdatePlayerCommand, UpdatePlayerCommandResponse>(command);

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}
}
