namespace MonoCloud.Management.Models;

/// <summary>
/// Basic API Access Policy Response: Represents a basic API access policy defined using structured conditions.
/// </summary>
public class BasicApiAccessPolicy
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
  /// The unique identifier of the client this policy applies to.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// The API scopes that may be requested by the client. If empty, all scopes may be requested.
  /// </summary>
  public List<string> Scopes { get; set; }
}


