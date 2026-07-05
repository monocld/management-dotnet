namespace MonoCloud.Management.Models;

/// <summary>
/// Create SPIFFE Trust Store Request: Creates a trust store for a federated SPIFFE trust domain and its workload identities.
/// </summary>
public class CreateSpiffeTrustStoreRequest
{
  /// <summary>
  /// Specifies whether this trust store’s mTLS endpoint aliases are published under &#x60;mtls_additional_endpoint_aliases&#x60; in the OpenID Connect discovery document.
  /// </summary>
  public bool? ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// Trust store validation settings (certificate type, revocation, caching, and related policies).
  /// </summary>
  public CreateSpiffeTrustStoreOptionsRequest Options { get; set; }

  /// <summary>
  /// The SPIFFE bundle endpoint URL used to retrieve trust domain signing keys.
  /// </summary>
  public string SpiffeBundleEndpoint { get; set; }
}


