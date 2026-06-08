namespace MonoCloud.Management.Models;

/// <summary>
/// The source from which a trust store&#39;s certificate chain is loaded.
/// </summary>
public enum TrustStoreSource
{
  /// <summary>
  /// Certificate chain is uploaded directly through the API and stored alongside the trust store.
  /// </summary>
  Database,

  /// <summary>
  /// Certificate chain is fetched from a customer-owned S3 object using a cross-account IAM role.
  /// </summary>
  S3
}


