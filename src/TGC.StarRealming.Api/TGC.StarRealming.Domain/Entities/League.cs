namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Represents a league, which is a long-running collection of league seasons. Players win seasons, not leagues.
/// </summary>
public class League : BaseEntity
{
	/// <summary>
	/// Gets or sets the name of the league.
	/// </summary>
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the catch phrase for the league.
	/// </summary>
	public string CatchPhrase { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the URL to the league's logo.
	/// </summary>
	public Uri? LogoUrl { get; set; }

	/// <summary>
	/// Gets the seasons that have taken place within this league.
	/// </summary>
	public ICollection<LeagueSeason> Seasons { get; } = [];

	/// <summary>
	/// Gets the admins of this league.
	/// </summary>
	public ICollection<LeagueAdmin> Admins { get; } = [];
}
