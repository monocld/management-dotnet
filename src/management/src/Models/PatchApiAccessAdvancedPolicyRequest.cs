namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Advanced API Access Policy Request: Used to partially update an advanced API access policy.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiAccessAdvancedPolicyRequest>))]
public class PatchApiAccessAdvancedPolicyRequest
{
  /// <summary>
  /// Indicates whether the policy is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the policy.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Description that explains the purpose of the policy.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Action settings applied when the policy fires.
  /// </summary>
  public Optional<PatchApiAccessPolicyActionsRequest> Actions { get; set; }

  /// <summary>
  /// The Cedar policy source used during evaluation for advanced policies.
  /// </summary>
  public Optional<string> Cedar { get; set; }

  /// <summary>
  /// Optional denial message returned to the client when this policy rejects a token request. If unset, a generic denial message is returned.
  /// </summary>
  public Optional<string?> Error { get; set; }
}


