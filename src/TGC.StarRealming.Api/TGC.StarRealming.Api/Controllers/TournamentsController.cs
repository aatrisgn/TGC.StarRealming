using Microsoft.AspNetCore.Mvc;
using TGC.StarRealming.Application.Tournaments.DeactivateTournament;
using TGC.StarRealming.Application.Tournaments.GetMyTournaments;
using TGC.StarRealming.Application.Tournaments.GetTournament;
using TGC.WebApi.Communication;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Api.Controllers;

/// <summary>
/// Manages tournament resources.
/// </summary>
[ApiController]
[Route("tournaments")]
public class TournamentsController : ControllerBase
{
	private readonly IMediator _mediator;

	/// <summary>
	/// Initializes a new instance of <see cref="TournamentsController"/>.
	/// </summary>
	public TournamentsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	/// <summary>
	/// Gets a specific tournament by ID.
	/// </summary>
	[HttpGet("{tournamentId:guid}")]
	public async Task<IActionResult> GetTournament([FromRoute] Guid tournamentId)
	{
		var response = await _mediator.HandleQueryAsync<GetTournamentQuery, GetTournamentQueryResponse>(
			new GetTournamentQuery { TournamentId = tournamentId });

		return ApiResult<object?>.AsOk(response.Tournament).ToActionResult();
	}

	/// <summary>
	/// Gets all tournaments associated with a given player.
	/// </summary>
	[HttpGet("my/{playerId:guid}")]
	public async Task<IActionResult> GetMyTournaments([FromRoute] Guid playerId)
	{
		var response = await _mediator.HandleQueryAsync<GetMyTournamentsQuery, GetMyTournamentsQueryResponse>(
			new GetMyTournamentsQuery { PlayerId = playerId });

		return ApiResult<object?>.AsOk(response.Tournaments).ToActionResult();
	}

	/// <summary>
	/// Deactivates a tournament.
	/// </summary>
	[HttpDelete("{tournamentId:guid}")]
	public async Task<IActionResult> DeactivateTournament([FromRoute] Guid tournamentId)
	{
		await _mediator.HandleCommandAsync<DeactivateTournamentCommand, DeactivateTournamentCommandResponse>(
			new DeactivateTournamentCommand { TournamentId = tournamentId });

		return ApiResult<object?>.AsOk(null).ToActionResult();
	}
}
