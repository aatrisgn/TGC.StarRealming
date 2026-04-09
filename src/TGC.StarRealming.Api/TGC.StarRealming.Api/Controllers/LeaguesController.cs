using Microsoft.AspNetCore.Mvc;
using TGC.StarRealming.Application.Leagues.DeactivateLeague;
using TGC.StarRealming.Application.Leagues.DeactivateLeagueSeason;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonGame;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonGames;
using TGC.StarRealming.Application.Leagues.GetLeagues;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasons;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournament;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournaments;
using TGC.StarRealming.Application.Leagues.GetMyLeagues;
using TGC.WebApi.Communication;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Api.Controllers;

/// <summary>
/// Manages league, season, tournament, and game resources scoped to leagues.
/// </summary>
[ApiController]
[Route("leagues")]
public class LeaguesController : ControllerBase
{
	private readonly IMediator _mediator;

	/// <summary>
	/// Initializes a new instance of <see cref="LeaguesController"/>.
	/// </summary>
	public LeaguesController(IMediator mediator)
	{
		_mediator = mediator;
	}

	/// <summary>
	/// Gets all leagues.
	/// </summary>
	[HttpGet]
	public async Task<IActionResult> GetLeagues()
	{
		var response = await _mediator.HandleQueryAsync<GetLeaguesQuery, GetLeaguesQueryResponse>(
			new GetLeaguesQuery());

		return ApiResult<object?>.AsOk(response.Leagues).ToActionResult();
	}

	/// <summary>
	/// Gets all leagues associated with a given player.
	/// </summary>
	[HttpGet("my/{playerId:guid}")]
	public async Task<IActionResult> GetMyLeagues([FromRoute] Guid playerId)
	{
		var response = await _mediator.HandleQueryAsync<GetMyLeaguesQuery, GetMyLeaguesQueryResponse>(
			new GetMyLeaguesQuery { PlayerId = playerId });

		return ApiResult<object?>.AsOk(response.Leagues).ToActionResult();
	}

	/// <summary>
	/// Deactivates a league.
	/// </summary>
	[HttpDelete("{leagueId:guid}")]
	public async Task<IActionResult> DeactivateLeague([FromRoute] Guid leagueId)
	{
		await _mediator.HandleCommandAsync<DeactivateLeagueCommand, DeactivateLeagueCommandResponse>(
			new DeactivateLeagueCommand { LeagueId = leagueId });

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}

	/// <summary>
	/// Gets all seasons for a given league.
	/// </summary>
	[HttpGet("{leagueId:guid}/seasons")]
	public async Task<IActionResult> GetLeagueSeasons([FromRoute] Guid leagueId)
	{
		var response = await _mediator.HandleQueryAsync<GetLeagueSeasonsQuery, GetLeagueSeasonsQueryResponse>(
			new GetLeagueSeasonsQuery { LeagueId = leagueId });

		return ApiResult<object?>.AsOk(response.Seasons).ToActionResult();
	}

	/// <summary>
	/// Deactivates a league season.
	/// </summary>
	[HttpDelete("{leagueId:guid}/seasons/{seasonId:guid}")]
	public async Task<IActionResult> DeactivateLeagueSeason([FromRoute] Guid leagueId, [FromRoute] Guid seasonId)
	{
		await _mediator.HandleCommandAsync<DeactivateLeagueSeasonCommand, DeactivateLeagueSeasonCommandResponse>(
			new DeactivateLeagueSeasonCommand { LeagueId = leagueId, SeasonId = seasonId });

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}

	/// <summary>
	/// Gets all tournaments for a given league season.
	/// </summary>
	[HttpGet("{leagueId:guid}/seasons/{seasonId:guid}/tournaments")]
	public async Task<IActionResult> GetLeagueSeasonTournaments([FromRoute] Guid leagueId, [FromRoute] Guid seasonId)
	{
		var response = await _mediator.HandleQueryAsync<GetLeagueSeasonTournamentsQuery, GetLeagueSeasonTournamentsQueryResponse>(
			new GetLeagueSeasonTournamentsQuery { LeagueId = leagueId, SeasonId = seasonId });

		return ApiResult<object?>.AsOk(response.Tournaments).ToActionResult();
	}

	/// <summary>
	/// Gets a specific tournament from a league season.
	/// </summary>
	[HttpGet("{leagueId:guid}/seasons/{seasonId:guid}/tournaments/{tournamentId:guid}")]
	public async Task<IActionResult> GetLeagueSeasonTournament(
		[FromRoute] Guid leagueId,
		[FromRoute] Guid seasonId,
		[FromRoute] Guid tournamentId)
	{
		var response = await _mediator.HandleQueryAsync<GetLeagueSeasonTournamentQuery, GetLeagueSeasonTournamentQueryResponse>(
			new GetLeagueSeasonTournamentQuery { LeagueId = leagueId, SeasonId = seasonId, TournamentId = tournamentId });

		return ApiResult<object?>.AsOk(response.Tournament).ToActionResult();
	}

	/// <summary>
	/// Gets all games for a given league season.
	/// </summary>
	[HttpGet("{leagueId:guid}/seasons/{seasonId:guid}/games")]
	public async Task<IActionResult> GetLeagueSeasonGames([FromRoute] Guid leagueId, [FromRoute] Guid seasonId)
	{
		var response = await _mediator.HandleQueryAsync<GetLeagueSeasonGamesQuery, GetLeagueSeasonGamesQueryResponse>(
			new GetLeagueSeasonGamesQuery { LeagueId = leagueId, SeasonId = seasonId });

		return ApiResult<object?>.AsOk(response.Games).ToActionResult();
	}

	/// <summary>
	/// Gets a specific game from a league season.
	/// </summary>
	[HttpGet("{leagueId:guid}/seasons/{seasonId:guid}/games/{gameId:guid}")]
	public async Task<IActionResult> GetLeagueSeasonGame(
		[FromRoute] Guid leagueId,
		[FromRoute] Guid seasonId,
		[FromRoute] Guid gameId)
	{
		var response = await _mediator.HandleQueryAsync<GetLeagueSeasonGameQuery, GetLeagueSeasonGameQueryResponse>(
			new GetLeagueSeasonGameQuery { LeagueId = leagueId, SeasonId = seasonId, GameId = gameId });

		return ApiResult<object?>.AsOk(response.Game).ToActionResult();
	}
}
