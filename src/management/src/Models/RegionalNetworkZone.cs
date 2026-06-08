namespace MonoCloud.Management.Models;

/// <summary>
/// Regional Network Zone Response: Represents a Regional Network Zone.
/// </summary>
public class RegionalNetworkZone : INetworkZone
{
  /// <summary>
  /// The unique identifier of the network zone.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Indicates whether the zone is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the zone.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Description that explains the zone.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The category the zone belongs to.
  /// </summary>
  public NetworkZoneCategory Category { get; set; }

  /// <summary>
  /// Specifies the creation time of the zone (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the zone (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The evaluation operator for the network zone.
  /// </summary>
  public NetworkZoneOperator Operator { get; set; }

  public string Type { get; set; }

  /// <summary>
  /// List of 3166-1 alpha-2 country codes.
  /// </summary>
  public List<string> Countries { get; set; }
}


