namespace TGC.StarRealming.Domain.Enums;

/// <summary>
/// Represents the acceptance status of a game result by a player.
/// </summary>
public enum GameAcceptanceStatus
{
	/// <summary>
	/// The player has not yet responded to the game result.
	/// </summary>
	Pending,

	/// <summary>
	/// The player has accepted the game result.
	/// </summary>
	Accepted,

	/// <summary>
	/// The player has denied the game result.
	/// </summary>
	Denied,
}
