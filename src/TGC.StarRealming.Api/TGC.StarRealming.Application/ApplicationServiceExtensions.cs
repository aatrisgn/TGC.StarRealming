using Microsoft.Extensions.DependencyInjection;
using TGC.StarRealming.Application.Games.CreateGame;
using TGC.StarRealming.Application.Games.DeactivateGame;
using TGC.StarRealming.Application.Games.GetGame;
using TGC.StarRealming.Application.Games.GetMyGames;
using TGC.StarRealming.Application.Games.SearchGames;
using TGC.StarRealming.Application.Games.UpdateGame;
using TGC.StarRealming.Application.Leagues.DeactivateLeague;
using TGC.StarRealming.Application.Leagues.DeactivateLeagueSeason;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonGame;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonGames;
using TGC.StarRealming.Application.Leagues.GetLeagues;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasons;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournament;
using TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournaments;
using TGC.StarRealming.Application.Leagues.GetMyLeagues;
using TGC.StarRealming.Application.Players.CreatePlayer;
using TGC.StarRealming.Application.Players.GetPlayer;
using TGC.StarRealming.Application.Players.GetPlayerGames;
using TGC.StarRealming.Application.Players.UpdatePlayer;
using TGC.StarRealming.Application.Profiles.CreateProfile;
using TGC.StarRealming.Application.Profiles.GetProfile;
using TGC.StarRealming.Application.Profiles.UpdateProfile;
using TGC.StarRealming.Application.Tournaments.DeactivateTournament;
using TGC.StarRealming.Application.Tournaments.GetMyTournaments;
using TGC.StarRealming.Application.Tournaments.GetTournament;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application;

/// <summary>
/// Extension methods for registering application services with the DI container.
/// </summary>
public static class ApplicationServiceExtensions
{
	/// <summary>
	/// Registers all application query handlers, command handlers, and the mediator.
	/// </summary>
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddScoped<IQueryHandler, GetPlayerQueryHandler>();
		services.AddScoped<IQueryHandler, GetPlayerGamesQueryHandler>();
		services.AddScoped<IQueryHandler, GetProfileQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeaguesQueryHandler>();
		services.AddScoped<IQueryHandler, GetMyLeaguesQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeagueSeasonsQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeagueSeasonTournamentsQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeagueSeasonTournamentQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeagueSeasonGamesQueryHandler>();
		services.AddScoped<IQueryHandler, GetLeagueSeasonGameQueryHandler>();
		services.AddScoped<IQueryHandler, GetTournamentQueryHandler>();
		services.AddScoped<IQueryHandler, GetMyTournamentsQueryHandler>();
		services.AddScoped<IQueryHandler, GetGameQueryHandler>();
		services.AddScoped<IQueryHandler, SearchGamesQueryHandler>();
		services.AddScoped<IQueryHandler, GetMyGamesQueryHandler>();

		services.AddScoped<ICommandHandler, CreatePlayerCommandHandler>();
		services.AddScoped<ICommandHandler, UpdatePlayerCommandHandler>();
		services.AddScoped<ICommandHandler, CreateProfileCommandHandler>();
		services.AddScoped<ICommandHandler, UpdateProfileCommandHandler>();
		services.AddScoped<ICommandHandler, DeactivateLeagueCommandHandler>();
		services.AddScoped<ICommandHandler, DeactivateLeagueSeasonCommandHandler>();
		services.AddScoped<ICommandHandler, DeactivateTournamentCommandHandler>();
		services.AddScoped<ICommandHandler, CreateGameCommandHandler>();
		services.AddScoped<ICommandHandler, UpdateGameCommandHandler>();
		services.AddScoped<ICommandHandler, DeactivateGameCommandHandler>();

		services.AddScoped<IMediator, Mediator>();

		return services;
	}
}
