namespace TGC.StarRealming.Domain.Entities;

/// <summary>
/// Base class for all domain entities providing common audit and lifecycle properties.
/// </summary>
public abstract class BaseEntity
{
	/// <summary>
	/// Gets or sets the unique identifier for the entity.
	/// </summary>
	public Guid Id { get; set; }

	/// <summary>
	/// Gets or sets the UTC date and time when the entity was created.
	/// </summary>
	public DateTime Created { get; set; }

	/// <summary>
	/// Gets or sets the identifier of the user who created the entity.
	/// </summary>
	public string CreatedBy { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the UTC date and time when the entity was last updated.
	/// </summary>
	public DateTime LastUpdated { get; set; }

	/// <summary>
	/// Gets or sets the identifier of the user who last updated the entity.
	/// </summary>
	public string LastUpdatedBy { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets a value indicating whether this entity is active.
	/// </summary>
	public bool Active { get; set; }
}
