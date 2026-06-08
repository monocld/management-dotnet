namespace MonoCloud.Management.Models;

/// <summary>
/// Patch IP Network Zone Request: Used to partially update an IP network zone.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIpNetworkZoneRequest>))]
public class PatchIpNetworkZoneRequest
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
  /// List of IPv4/IPv6 addresses or CIDR ranges.
  /// </summary>
  public Optional<List<string>> IpRanges { get; set; }
}


