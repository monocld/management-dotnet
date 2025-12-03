namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Ban Certificate Request.
/// </summary>
public class BanTrustStoreCertificateRequest
{
  /// <summary>
  /// Unique thumbprint of the certificate.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// Specifies the reason for banning the certificate.
  /// </summary>
  public string? Reason { get; set; }

  /// <summary>
  /// Specifies the type of the banned certificate.
  /// </summary>
  public BannedCertificateType? Type { get; set; }
}


