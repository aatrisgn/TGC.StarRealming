using TGC.WebApi.Communication.Mediator;

namespace TGC.StarRealming.Application.Games.CreateGame;

/// <summary>
/// Response for the create game command.
/// </summary>
public class CreateGameCommandResponse : BaseResponse
{
	/// <summary>Gets or sets the identifier of the newly created game.</summary>
	public Guid GameId { get; set; }
}
