using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.GetPlayer;

public class GetPlayerQueryHandler : BaseQueryHandler<GetPlayerQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve player from repository using typedQuery.PlayerId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetPlayerQueryResponse>.Success(new GetPlayerQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
