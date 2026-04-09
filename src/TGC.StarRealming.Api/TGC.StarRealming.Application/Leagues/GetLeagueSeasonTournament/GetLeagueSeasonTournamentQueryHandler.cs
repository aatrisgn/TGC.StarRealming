using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournament;

internal class GetLeagueSeasonTournamentQueryHandler : BaseQueryHandler<GetLeagueSeasonTournamentQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve tournament by typedQuery.TournamentId within typedQuery.LeagueId / typedQuery.SeasonId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeagueSeasonTournamentQueryResponse>.Success(new GetLeagueSeasonTournamentQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
