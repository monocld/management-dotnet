namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Delta Revocation response
/// </summary>
public class DeltaRevocation
{
  /// <summary>
  /// Revocation Id.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Crl Pem Value.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// Thumbprint of the CA certificate the crl belongs to.
  /// </summary>
  public string IssuerThumbprint { get; set; }

  /// <summary>
  /// Specifies the issued time of the revocation (in Epoch).
  /// </summary>
  public DateTime IssuedAt { get; set; }

  /// <summary>
  /// Specifies the next update of the revocation (in Epoch).
  /// </summary>
  public DateTime? NextUpdate { get; set; }

  /// <summary>
  /// Specifies the creation time of the revocation (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// The crl number.
  /// </summary>
  public int CrlNumber { get; set; }

  /// <summary>
  /// The Delta crl number.
  /// </summary>
  public int DeltaCrlNumber { get; set; }

  /// <summary>
  /// Base Revocation Id.
  /// </summary>
  public string BaseRevocationId { get; set; }
}


