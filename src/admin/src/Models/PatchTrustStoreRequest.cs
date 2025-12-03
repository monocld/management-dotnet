namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch trust store request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchTrustStoreRequest>))]
public class PatchTrustStoreRequest
{
  /// <summary>
  /// Name of the trust store
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Specifies if the trust store is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies if the specific trust store metadata should be shown in the discovery endpoint.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The entire certificate chain
  /// </summary>
  public Optional<string> CertChain { get; set; }

  /// <summary>
  /// The Trust store options
  /// </summary>
  public Optional<PatchTrustStoreOptionsRequest> Options { get; set; }
}


