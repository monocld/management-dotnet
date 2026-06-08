namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Regional Network Zone Request: Used to partially update a regional network zone.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRegionalNetworkZoneRequest>))]
public class PatchRegionalNetworkZoneRequest
{
  /// <summary>
  /// Indicates whether the zone is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the zone.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Description that explains the zone.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// The category the zone belongs to.
  /// </summary>
  public Optional<NetworkZoneCategory> Category { get; set; }

  /// <summary>
  /// The evaluation operator for the network zone.
  /// </summary>
  public Optional<NetworkZoneOperator> Operator { get; set; }

  /// <summary>
  /// List of 3166-1 alpha-2 country codes.
  /// </summary>
  public Optional<List<string>> Countries { get; set; }
}


