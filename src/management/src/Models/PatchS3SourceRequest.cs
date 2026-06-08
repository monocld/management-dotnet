namespace MonoCloud.Management.Models;

/// <summary>
/// Patch S3 Source Request: Update one or more S3 fetch fields on an existing S3 trust store.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchS3SourceRequest>))]
public class PatchS3SourceRequest
{
  /// <summary>
  /// The AWS region of the bucket(s).
  /// </summary>
  public Optional<string> Region { get; set; }

  /// <summary>
  /// The ARN of the IAM role MonoCloud should assume to read the objects.
  /// </summary>
  public Optional<string> RoleArn { get; set; }

  /// <summary>
  /// S3 URI of the PEM-encoded certificate chain.
  /// </summary>
  public Optional<string> ChainObjectUri { get; set; }

  /// <summary>
  /// Replaces the full list of CRL S3 URIs.
  /// </summary>
  public Optional<List<string>> CrlObjectUris { get; set; }
}


