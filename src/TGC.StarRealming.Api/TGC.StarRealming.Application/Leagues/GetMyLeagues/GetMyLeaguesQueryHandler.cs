using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetMyLeagues;

internal class GetMyLeaguesQueryHandler : BaseQueryHandler<GetMyLeaguesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve leagues for typedQuery.PlayerId from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetMyLeaguesQueryResponse>.Success(new GetMyLeaguesQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
