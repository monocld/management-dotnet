namespace MonoCloud.Management.Models;

/// <summary>
/// Patch SPIFFE Trust Store Request: Used to update one or more properties of an existing SPIFFE trust store.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSpiffeTrustStoreRequest>))]
public class PatchSpiffeTrustStoreRequest
{
  /// <summary>
  /// Indicates whether the trust store is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies whether this trust store’s mTLS endpoint aliases are published under &#x60;mtls_additional_endpoint_aliases&#x60; in the OpenID Connect discovery document.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The SPIFFE bundle endpoint URL used to retrieve trust domain signing keys.
  /// </summary>
  public Optional<string> SpiffeBundleEndpoint { get; set; }

  /// <summary>
  /// Trust store validation settings (certificate type, caching, and related policies).
  /// </summary>
  public Optional<PatchSpiffeTrustStoreOptionsRequest> Options { get; set; }
}


