namespace MonoCloud.Management.Models;

/// <summary>
/// Create Regional Network Zone Request: Used to create a regional network zone.
/// </summary>
public class CreateRegionalNetworkZoneRequest
{
  /// <summary>
  /// Indicates whether the zone is enabled.
  /// </summary>
  public bool? Enabled { get; set; }

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
  public NetworkZoneCategory? Category { get; set; }

  /// <summary>
  /// The evaluation operator for the network zone.
  /// </summary>
  public NetworkZoneOperator? Operator { get; set; }

  /// <summary>
  /// List of 3166-1 alpha-2 country codes.
  /// </summary>
  public List<string> Countries { get; set; }
}


