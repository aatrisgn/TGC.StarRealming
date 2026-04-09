using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.GetGame;

internal class GetGameQueryHandler : BaseQueryHandler<GetGameQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve game from repository using typedQuery.GameId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetGameQueryResponse>.Success(new GetGameQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
