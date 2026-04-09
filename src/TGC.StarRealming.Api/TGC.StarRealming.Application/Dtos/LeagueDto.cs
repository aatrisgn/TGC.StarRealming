namespace TGC.StarRealming.Application.Dtos;

/// <summary>
/// Data transfer object representing a league.
/// </summary>
public class LeagueDto
{
	/// <summary>Gets or sets the league identifier.</summary>
	public Guid Id { get; set; }

	/// <summary>Gets or sets the league name.</summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>Gets or sets the league catch phrase.</summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>Gets or sets the URL to the league logo.</summary>
	public Uri? LogoUrl { get; set; }
}
