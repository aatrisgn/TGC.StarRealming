using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonGame;

internal class GetLeagueSeasonGameQueryHandler : BaseQueryHandler<GetLeagueSeasonGameQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve game by typedQuery.GameId within typedQuery.LeagueId / typedQuery.SeasonId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeagueSeasonGameQueryResponse>.Success(new GetLeagueSeasonGameQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
