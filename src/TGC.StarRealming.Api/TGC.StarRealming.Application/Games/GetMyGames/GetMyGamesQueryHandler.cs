using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetMyGames;

internal class GetMyGamesQueryHandler : BaseQueryHandler<GetMyGamesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve paginated games for typedQuery.PlayerId from repository, page size 100
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetMyGamesQueryResponse>.Success(new GetMyGamesQueryResponse
		{
			StatusCode = HttpStatusCode.OK,
			Page = typedQuery.Page,
			TotalPages = 0
		});
	}
}
