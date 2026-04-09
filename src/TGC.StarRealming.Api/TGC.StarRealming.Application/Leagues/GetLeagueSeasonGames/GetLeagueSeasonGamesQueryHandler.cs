using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonGames;

internal class GetLeagueSeasonGamesQueryHandler : BaseQueryHandler<GetLeagueSeasonGamesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve games for typedQuery.LeagueId / typedQuery.SeasonId from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeagueSeasonGamesQueryResponse>.Success(new GetLeagueSeasonGamesQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
