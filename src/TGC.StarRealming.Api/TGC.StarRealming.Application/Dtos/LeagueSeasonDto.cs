using TGC.StarRealming.Domain.Enums;

namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a league season.
/// </summary>
public class LeagueSeasonDto
{
	/// <summary>Gets or sets the season identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the identifier of the parent league.</summary>
	public Guid LeagueId { get; set; }

	/// <summary>Gets or sets the season description.</summary>
	public string Description { get; set; } = string.Empty;

	/// <summary>Gets or sets the season start date.</summary>
	public DateTime StartDate { get; set; }

	/// <summary>Gets or sets the season end date.</summary>
	public DateTime EndDate { get; set; }

	/// <summary>Gets or sets the current status of the season.</summary>
	public LeagueSeasonStatus Status { get; set; }

	/// <summary>Gets or sets the identifier of the season winner, if completed.</summary>
	public Guid? WinnerId { get; set; }
}
