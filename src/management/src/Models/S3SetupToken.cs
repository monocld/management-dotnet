namespace MonoCloud.Management.Models;

/// <summary>
/// S3 Setup Token: Values the customer needs to configure an IAM role in their AWS account before creating an S3-backed trust store. The returned &#x60;external_id&#x60; must be supplied verbatim to &#x60;POST /truststores&#x60; in the &#x60;s3_source&#x60; payload.
/// </summary>
public class S3SetupToken
{
  /// <summary>
  /// The external id MonoCloud will present when assuming the customer role. Customers must set this as the &#x60;sts:ExternalId&#x60; condition on their IAM role&#39;s trust policy.
  /// </summary>
  public string ExternalId { get; set; }

  /// <summary>
  /// MonoCloud workload IAM principal that the customer&#39;s role must trust.
  /// </summary>
  public string PrincipalArn { get; set; }

  /// <summary>
  /// A ready-to-paste IAM trust policy JSON document. Customers attach this to the role they want MonoCloud to assume.
  /// </summary>
  public string TrustPolicyTemplate { get; set; }
}


