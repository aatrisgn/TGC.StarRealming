using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.GetProfile;

internal class GetProfileQueryHandler : BaseQueryHandler<GetProfileQuery>, IQueryHandler
{
	public async Task<IResult<IQueryResponse>> Handle<TQuery>(TQuery query) where TQuery : IQuery
	{
		var typedQuery = GetTypedQuery(query);

		// TODO: retrieve profile from repository using typedQuery.ProfileId
		await Task.CompletedTask.ConfigureAwait(false);

		return Result<GetProfileQueryResponse>.Success(new GetProfileQueryResponse
		{
			StatusCode = HttpStatusCode.OK
		});
	}
}
