namespace MonoCloud.Management.Models;

/// <summary>
/// Base Certificate Revocation Response: Represents a base certificate revocation list (CRL) configured for offline revocation checking within a trust store.
/// </summary>
public class BaseCertificateRevocation : ICertificateRevocation
{
  /// <summary>
  /// The unique identifier of the revocation entry.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// The certificate revocation list (CRL) in PEM format.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The thumbprint of the CA certificate that issued this CRL.
  /// </summary>
  public string IssuerThumbprint { get; set; }

  /// <summary>
  /// Specifies the time at which the CRL was issued (in Epoch).
  /// </summary>
  public DateTime IssuedAt { get; set; }

  /// <summary>
  /// Specifies the time at which the next CRL update is expected (in Epoch).
  /// </summary>
  public DateTime? NextUpdate { get; set; }

  /// <summary>
  /// Specifies the time at which this revocation entry was created (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// The CRL number, as defined in the X.509 CRL extensions, used to identify the version or sequence of the certificate revocation list.
  /// </summary>
  public int? CrlNumber { get; set; }

  public string Type { get; set; }
}


