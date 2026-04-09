using System.Net;
using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Profiles.CreateProfile;

internal class CreateProfileCommandHandler : BaseCommandHandler<CreateProfileCommand>, ICommandHandler
{
	public async Task<ICommandResponse> Handle<TCommand>(TCommand command) where TCommand : ICommand
	{
		var typedCommand = GetTypedCommand(command);

		// TODO: create profile in repository using typedCommand properties
		await Task.CompletedTask.ConfigureAwait(false);

		return new CreateProfileCommandResponse
		{
			StatusCode = HttpStatusCode.OK,
			ProfileId = Guid.NewGuid()
		};
	}
}
