namespace MonoCloud.Management.Models;

/// <summary>
/// S3 Source Response: Configuration and fetch metadata for an S3-backed trust store.
/// </summary>
public class S3Source
{
  /// <summary>
  /// The AWS region of the bucket(s) that contain the certificate chain and any CRLs.
  /// </summary>
  public string Region { get; set; }

  /// <summary>
  /// The ARN of the IAM role MonoCloud should assume to read the objects. The role must trust MonoCloud&#39;s workload role and require the &#x60;ExternalId&#x60; from &#x60;/truststores/s3/setup-token&#x60;.
  /// </summary>
  public string RoleArn { get; set; }

  /// <summary>
  /// S3 URI of the PEM-encoded certificate chain.
  /// </summary>
  public string ChainObjectUri { get; set; }

  /// <summary>
  /// The time MonoCloud last attempted to fetch from S3 (in Epoch). Updated by create, patch, and purge-cache.
  /// </summary>
  public DateTime? LastFetchedAt { get; set; }

  /// <summary>
  /// The error returned by the most recent fetch attempt, if it failed. Cleared on success.
  /// </summary>
  public string? LastFetchError { get; set; }
}


