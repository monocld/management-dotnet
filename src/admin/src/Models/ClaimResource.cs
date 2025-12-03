namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Claim Resource response class
/// </summary>
public class ClaimResource
{
  /// <summary>
  /// Unique ID of the Resource
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies whether this resource is shown in the discovery document.
  /// </summary>
  public bool ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The unique name of the claim.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies the source of the claim.
  /// </summary>
  public string Source { get; set; }

  /// <summary>
  /// Specifies whether it&#39;s a built-in claim resource.
  /// </summary>
  public bool IsDefault { get; set; }
}


