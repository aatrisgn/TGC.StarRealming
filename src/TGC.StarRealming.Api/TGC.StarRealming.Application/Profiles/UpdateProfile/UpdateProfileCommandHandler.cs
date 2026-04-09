using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.UpdateProfile;

internal class UpdateProfileCommandHandler : BaseCommandHandler<UpdateProfileCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: update profile in repository using typedCommand properties
		await Task.CompletedTask.ConfigureAwait(false);

		return new UpdateProfileCommandResponse
		{
			StatusCode = HttpStatusCode.OK
		};
	}
}
