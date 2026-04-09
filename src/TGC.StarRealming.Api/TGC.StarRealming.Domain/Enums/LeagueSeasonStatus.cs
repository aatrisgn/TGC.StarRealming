namespace TGC.StarRealming.Domain.Enums;

/// <summary>
/// Represents the lifecycle status of a league season.
/// </summary>
public enum LeagueSeasonStatus
{
	/// <summary>The season has not yet started.</summary>
	Inactive,

	/// <summary>The season is currently running.</summary>
	Active,

	/// <summary>The season has been completed and a winner has been determined.</summary>
	Completed,
}
