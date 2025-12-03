namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Trust Store Response
/// </summary>
public class TrustStore
{
  /// <summary>
  /// Id of the trust store
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Name of the trust store
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies if the trust store is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies if the trust store is the store used at the default MTLS endpoint.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// Specifies if the specific trust store metadata should be shown in the discovery endpoint.
  /// </summary>
  public bool ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The entire certificate chain
  /// </summary>
  public string CertChain { get; set; }

  /// <summary>
  /// The Trust store options
  /// </summary>
  public TrustStoreOptions Options { get; set; }

  /// <summary>
  /// Specifies the creation time of the trust store (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the trust store (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


