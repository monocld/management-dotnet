namespace MonoCloud.Management.Models;

/// <summary>
/// Create IP Network Zone Request: Used to create an IP network zone.
/// </summary>
public class CreateIpNetworkZoneRequest
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
  /// List of IPv4/IPv6 addresses or CIDR ranges.
  /// </summary>
  public List<string> IpRanges { get; set; }
}


