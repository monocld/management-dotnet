namespace MonoCloud.Management.Models;

/// <summary>
/// SPIFFE Trust Store Response: Represents a federated SPIFFE trust domain used to validate workload identities.
/// </summary>
public class SpiffeTrustStore
{
  /// <summary>
  /// The unique identifier of the trust store.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Human-readable name for the trust store.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Indicates whether the trust store is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Indicates whether this trust store is configured as the default store for the mTLS endpoint.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// Specifies whether this trust store’s mTLS endpoint aliases are published under &#x60;mtls_additional_endpoint_aliases&#x60; in the OpenID Connect discovery document.
  /// </summary>
  public bool ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// Trust store validation settings (certificate type, revocation, caching, and related policies).
  /// </summary>
  public SpiffeTrustStoreOptions Options { get; set; }

  /// <summary>
  /// Specifies the creation time of the trust store (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the trust store (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The SPIFFE bundle endpoint URL used to retrieve trust domain signing keys.
  /// </summary>
  public string SpiffeBundleEndpoint { get; set; }
}


