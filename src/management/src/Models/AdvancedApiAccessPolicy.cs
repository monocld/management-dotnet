namespace MonoCloud.Management.Models;

/// <summary>
/// Advanced API Access Policy Response: Represents a stored advanced API access policy authored using Cedar.
/// </summary>
public class AdvancedApiAccessPolicy
{
  /// <summary>
  /// The unique identifier of the policy.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Indicates whether the policy is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the policy.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Description that explains the purpose of the policy.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The policy authoring mode. Basic policies are authored using structured conditions; advanced policies are authored using Cedar policy source.
  /// </summary>
  public PolicyTypes Type { get; set; }

  /// <summary>
  /// Indicates whether the policy grants access when matched.
  /// </summary>
  public bool IsPermitted { get; set; }

  /// <summary>
  /// The Cedar policy source used during evaluation for advanced policies.
  /// </summary>
  public string Cedar { get; set; }

  /// <summary>
  /// Action settings applied when the policy matches.
  /// </summary>
  public ApiAccessPolicyActions Actions { get; set; }

  /// <summary>
  /// Specifies the creation time of the policy (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the policy (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Specifies the current version of the policy. Incremented on every update.
  /// </summary>
  public int Revision { get; set; }

  /// <summary>
  /// Optional denial message returned to the client when this policy rejects a token request. If unset, a generic denial message is returned.
  /// </summary>
  public string? Error { get; set; }
}


