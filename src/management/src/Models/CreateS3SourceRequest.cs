namespace MonoCloud.Management.Models;

/// <summary>
/// Create S3 Source Request: Bucket, key and IAM role MonoCloud should use to fetch the certificate chain.
/// </summary>
public class CreateS3SourceRequest
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
}


