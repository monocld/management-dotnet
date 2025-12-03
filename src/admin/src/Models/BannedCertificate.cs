namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Banned Certificate Response
/// </summary>
public class BannedCertificate
{
  /// <summary>
  /// The Id of the banned certificate.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Specifies the type of the banned certificate.
  /// </summary>
  public BannedCertificateType Type { get; set; }

  /// <summary>
  /// Unique thumbprint of the certificate.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// Specifies the reason for banning the certificate.
  /// </summary>
  public string? Reason { get; set; }

  /// <summary>
  /// Specifies the creation time (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }
}


