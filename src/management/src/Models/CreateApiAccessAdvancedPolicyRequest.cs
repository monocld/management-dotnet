namespace MonoCloud.Management.Models;

/// <summary>
/// Create Advanced API Access Policy Request: Creates an advanced API access policy from raw Cedar policy source.
/// </summary>
public class CreateApiAccessAdvancedPolicyRequest
{
  /// <summary>
  /// Indicates whether the policy is enabled.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the policy.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Description that explains the purpose of the policy.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The Cedar policy source used during evaluation for advanced policies.
  /// </summary>
  public string Cedar { get; set; }

  /// <summary>
  /// Action settings applied when the policy matches.
  /// </summary>
  public CreateApiAccessPolicyActionsRequest Actions { get; set; }

  /// <summary>
  /// Optional denial message returned to the client when this policy rejects a token request. If unset, a generic denial message is returned.
  /// </summary>
  public string? Error { get; set; }
}


