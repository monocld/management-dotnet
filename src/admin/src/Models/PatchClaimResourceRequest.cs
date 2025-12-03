namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Claim Resource class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClaimResourceRequest>))]
public class PatchClaimResourceRequest
{
  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Specifies whether this resource is shown in the discovery document.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The unique name of the claim.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Specifies the source of the claim.
  /// </summary>
  public Optional<string> Source { get; set; }
}


