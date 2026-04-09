namespace TGC.StarRealming.Domain.Enums;

/// <summary>
/// Represents the format type of a tournament.
/// </summary>
public enum TournamentType
{
	/// <summary>
	/// Every player plays against every other player. Requires 3 or more players.
	/// </summary>
	RoundRobin,

	/// <summary>
	/// Players are eliminated after a loss. Requires 4 or more players.
	/// </summary>
	KnockOut,

	/// <summary>
	/// Players are divided into groups, followed by a knock-out stage. Requires at least 5 players, preferably divisible by 4.
	/// </summary>
	GroupKnockOut,
}
