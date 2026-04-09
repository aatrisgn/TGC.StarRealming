using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagueSeasons;

internal class GetLeagueSeasonsQueryHandler : BaseQueryHandler<GetLeagueSeasonsQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve seasons for typedQuery.LeagueId from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeagueSeasonsQueryResponse>.Success(new GetLeagueSeasonsQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
