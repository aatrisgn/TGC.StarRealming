using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayerGames;

internal class GetPlayerGamesQueryHandler : BaseQueryHandler<GetPlayerGamesQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve games from repository using typedQuery.PlayerId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetPlayerGamesQueryResponse>.Success(new GetPlayerGamesQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
