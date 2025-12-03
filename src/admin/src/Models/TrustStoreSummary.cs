namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Trust Store Summary Response
/// </summary>
public class TrustStoreSummary
{
  /// <summary>
  /// Id of the trust store
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Name of the trust store
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies if the trust store is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies if the trust store is the store used at the default MTLS endpoint.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// Specifies the number of certificates in the store.
  /// </summary>
  public int CertificateCount { get; set; }

  /// <summary>
  /// Specifies the number of banned certificates in the store.
  /// </summary>
  public int BannedCertificatesCount { get; set; }

  /// <summary>
  /// Specifies the creation time of the trust store (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the trust store (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


