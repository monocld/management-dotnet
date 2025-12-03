namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Create Trust Store Options Request.
/// </summary>
public class CreateTrustStoreOptionsRequest
{
  /// <summary>
  /// If set to true, will validate whether the certificate is intended for authentication
  /// </summary>
  public bool? ValidateCertificateUse { get; set; }

  /// <summary>
  /// If set to true, will verify the certificate&#39;s validity period
  /// </summary>
  public bool? ValidateValidityPeriod { get; set; }

  /// <summary>
  /// Specifies the type of revocation check.
  /// </summary>
  public X509RevocationMode? RevocationMode { get; set; }

  /// <summary>
  /// Specifies which X509 certificate in the chain should be checked for revocation.
  /// </summary>
  public RevocationCheckDepth? RevocationCheckDepth { get; set; }

  /// <summary>
  /// Specifies the skew in seconds for the CRL issued date and OCSP validation.
  /// </summary>
  public int? RevocationCheckClockSkew { get; set; }

  /// <summary>
  /// Specifies the timeout in seconds for the OCSP responder to respond to the request.
  /// </summary>
  public int? OcspCheckTimeout { get; set; }

  /// <summary>
  /// Specifies the timeout in seconds for the Certificate Distribution Point to respond to the request.
  /// </summary>
  public int? OnlineCrlCheckTimeout { get; set; }

  /// <summary>
  /// Specifies the cache duration in seconds for the Certificate Authentication.
  /// </summary>
  public int? CertificateAuthCacheDuration { get; set; }

  /// <summary>
  /// Specifies the cache duration in seconds for the downloaded CRL.
  /// </summary>
  public int? OnlineCrlCacheDuration { get; set; }

  /// <summary>
  /// Specifies the cache duration in seconds for the OCSP response.
  /// </summary>
  public int? OcspCacheDuration { get; set; }
}


