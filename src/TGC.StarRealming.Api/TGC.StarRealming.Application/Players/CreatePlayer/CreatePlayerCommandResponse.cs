using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Players.CreatePlayer;

/// <summary>
/// Response for the create player command.
/// </summary>
public class CreatePlayerCommandResponse : BaseResponse
{
	/// <summary>Gets or sets the identifier of the newly created player.</summary>
	public Guid PlayerId { get; set; }
}
