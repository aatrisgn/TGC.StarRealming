using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.SearchGames;

internal class SearchGamesQueryHandler : BaseQueryHandler<SearchGamesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: search games in repository using typedQuery filter properties, paginate with page size 100
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<SearchGamesQueryResponse>.Success(new SearchGamesQueryResponse
		{
			StatusCode = HttpStatusCode.OK,
			Page = typedQuery.Page,
			TotalPages = 0
		});
	}
}
