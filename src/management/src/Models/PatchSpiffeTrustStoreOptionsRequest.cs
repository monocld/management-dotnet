namespace MonoCloud.Management.Models;

/// <summary>
/// Patch SPIFFE Trust Store Options Request: Used to update one or more configuration properties of an existing SPIFFE trust store.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSpiffeTrustStoreOptionsRequest>))]
public class PatchSpiffeTrustStoreOptionsRequest
{
  /// <summary>
  /// Indicates whether the client certificate is validated for client authentication, including Client Authentication EKU checks across the certificate chain.
  /// </summary>
  public Optional<bool> ValidateCertificateUse { get; set; }

  /// <summary>
  /// Indicates whether the certificate validity period (&#x60;NotBefore&#x60; / &#x60;NotAfter&#x60;) is enforced.
  /// </summary>
  public Optional<bool> ValidateValidityPeriod { get; set; }

  /// <summary>
  /// Specifies how long certificate authentication results are cached (in seconds).
  /// </summary>
  public Optional<int> CertificateAuthCacheDuration { get; set; }

  /// <summary>
  /// Specifies the timeout for downloading the SPIFFE bundle from the bundle endpoint (in seconds).
  /// </summary>
  public Optional<int> BundleFetchTimeout { get; set; }
}


