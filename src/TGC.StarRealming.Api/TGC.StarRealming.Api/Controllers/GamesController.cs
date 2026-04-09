using Microsoft.AspNetCore.Mvc;
using TGC.StarRealming.Application.Games.CreateGame;
using TGC.StarRealming.Application.Games.DeactivateGame;
using TGC.StarRealming.Application.Games.GetGame;
using TGC.StarRealming.Application.Games.GetMyGames;
using TGC.StarRealming.Application.Games.SearchGames;
using TGC.StarRealming.Application.Games.UpdateGame;
using TGC.WebApi.Communication;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Api.Controllers;

/// <summary>
/// Manages game resources.
/// </summary>
[ApiController]
[Route("games")]
public class GamesController : ControllerBase
{
	private readonly IMediator _mediator;

	/// <summary>
	/// Initializes a new instance of <see cref="GamesController"/>.
	/// </summary>
	public GamesController(IMediator mediator)
	{
		_mediator = mediator;
	}

	/// <summary>
	/// Searches for games based on optional filter criteria. Results are paginated with 100 games per page.
	/// </summary>
	[HttpGet("search")]
	public async Task<IActionResult> SearchGames(
		[FromQuery] IEnumerable<Guid>? playerIds,
		[FromQuery] string? summary,
		[FromQuery] DateTime? date,
		[FromQuery] int page = 1)
	{
		var response = await _mediator.HandleQueryAsync<SearchGamesQuery, SearchGamesQueryResponse>(
			new SearchGamesQuery { PlayerIds = playerIds, Summary = summary, Date = date, Page = page });

		return ApiResult<object?>.AsOk(response).ToActionResult();
	}

	/// <summary>
	/// Gets paginated games for a given player. Results are paginated with 100 games per page.
	/// </summary>
	[HttpGet("my/{playerId:guid}")]
	public async Task<IActionResult> GetMyGames([FromRoute] Guid playerId, [FromQuery] int page = 1)
	{
		var response = await _mediator.HandleQueryAsync<GetMyGamesQuery, GetMyGamesQueryResponse>(
			new GetMyGamesQuery { PlayerId = playerId, Page = page });

		return ApiResult<object?>.AsOk(response).ToActionResult();
	}

	/// <summary>
	/// Gets a specific game by ID.
	/// </summary>
	[HttpGet("{gameId:guid}")]
	public async Task<IActionResult> GetGame([FromRoute] Guid gameId)
	{
		var response = await _mediator.HandleQueryAsync<GetGameQuery, GetGameQueryResponse>(
			new GetGameQuery { GameId = gameId });

		return ApiResult<object?>.AsOk(response.Game).ToActionResult();
	}

	/// <summary>
	/// Creates a new game. Player one is the initiator and is automatically set to accepted.
	/// </summary>
	[HttpPost]
	public async Task<IActionResult> CreateGame([FromBody] CreateGameCommand command)
	{
		var response = await _mediator.HandleCommandAsync<CreateGameCommand, CreateGameCommandResponse>(command);

		return ApiResult<object?>.AsOk(new { response.GameId }).ToActionResult();
	}

	/// <summary>
	/// Updates an existing game including acceptance statuses, result, and score.
	/// </summary>
	[HttpPut("{gameId:guid}")]
	public async Task<IActionResult> UpdateGame([FromRoute] Guid gameId, [FromBody] UpdateGameCommand command)
	{
		command.GameId = gameId;
		await _mediator.HandleCommandAsync<UpdateGameCommand, UpdateGameCommandResponse>(command);

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}

	/// <summary>
	/// Deactivates a game.
	/// </summary>
	[HttpDelete("{gameId:guid}")]
	public async Task<IActionResult> DeactivateGame([FromRoute] Guid gameId)
	{
		await _mediator.HandleCommandAsync<DeactivateGameCommand, DeactivateGameCommandResponse>(
			new DeactivateGameCommand { GameId = gameId });

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}
}
