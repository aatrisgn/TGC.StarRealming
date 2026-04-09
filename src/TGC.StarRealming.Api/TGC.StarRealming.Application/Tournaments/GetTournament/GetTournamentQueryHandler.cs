using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Tournaments.GetTournament;

internal class GetTournamentQueryHandler : BaseQueryHandler<GetTournamentQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve tournament from repository using typedQuery.TournamentId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetTournamentQueryResponse>.Success(new GetTournamentQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
