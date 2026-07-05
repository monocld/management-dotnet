namespace MonoCloud.Management.Models;

/// <summary>
/// Create SPIFFE Trust Store Options Request: Defines validation and caching behavior applied when authenticating SVIDs.
/// </summary>
public class CreateSpiffeTrustStoreOptionsRequest
{
  /// <summary>
  /// Indicates whether the client certificate is validated for client authentication, including Client Authentication EKU checks across the certificate chain.
  /// </summary>
  public bool? ValidateCertificateUse { get; set; }

  /// <summary>
  /// Indicates whether the certificate validity period (&#x60;NotBefore&#x60; / &#x60;NotAfter&#x60;) is enforced.
  /// </summary>
  public bool? ValidateValidityPeriod { get; set; }

  /// <summary>
  /// Specifies how long certificate authentication results are cached (in seconds).
  /// </summary>
  public int? CertificateAuthCacheDuration { get; set; }

  /// <summary>
  /// Specifies the timeout for downloading the SPIFFE bundle from the bundle endpoint (in seconds).
  /// </summary>
  public int? BundleFetchTimeout { get; set; }
}


