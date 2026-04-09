using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetMyTournaments;

internal class GetMyTournamentsQueryHandler : BaseQueryHandler<GetMyTournamentsQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve tournaments for typedQuery.PlayerId from repository
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetMyTournamentsQueryResponse>.Success(new GetMyTournamentsQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
