using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasonTournaments;

internal class GetLeagueSeasonTournamentsQueryHandler : BaseQueryHandler<GetLeagueSeasonTournamentsQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve tournaments for typedQuery.LeagueId / typedQuery.SeasonId from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeagueSeasonTournamentsQueryResponse>.Success(new GetLeagueSeasonTournamentsQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
