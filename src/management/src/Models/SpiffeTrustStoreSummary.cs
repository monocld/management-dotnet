namespace MonoCloud.Management.Models;

/// <summary>
/// SPIFFE Trust Store Summary Response: A lightweight representation of a federated SPIFFE trust domain, returned in list operations.
/// </summary>
public class SpiffeTrustStoreSummary
{
  /// <summary>
  /// The unique identifier of the trust store.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// The SPIFFE trust domain discovered from the bundle endpoint.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Indicates whether the trust store is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Indicates whether this trust store is configured as the default store for the mTLS endpoint.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// The total number of SVIDs explicitly marked as banned in the trust store.
  /// </summary>
  public int BannedSvidsCount { get; set; }

  /// <summary>
  /// Specifies the creation time of the trust store (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the trust store (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


