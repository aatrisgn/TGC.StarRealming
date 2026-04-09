using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a tournament.
/// </summary>
public class TournamentDto
{
	/// <summary>Gets or sets the tournament identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the tournament name.</summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>Gets or sets the tournament type.</summary>
	public TournamentType Type { get; set; }

	/// <summary>Gets or sets the identifier of the parent league season.</summary>
	public Guid LeagueSeasonId { get; set; }
}
