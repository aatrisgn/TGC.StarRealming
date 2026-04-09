using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Leagues.GetLeagues;

internal class GetLeaguesQueryHandler : BaseQueryHandler<GetLeaguesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve all leagues from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetLeaguesQueryResponse>.Success(new GetLeaguesQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
