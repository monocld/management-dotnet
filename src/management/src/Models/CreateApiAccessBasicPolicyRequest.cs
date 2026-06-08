namespace MonoCloud.Management.Models;

/// <summary>
/// Create Basic API Access Policy Request: Creates a basic API access policy using structured conditions.
/// </summary>
public class CreateApiAccessBasicPolicyRequest
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
  /// Action settings applied when the policy matches.
  /// </summary>
  public CreateApiAccessPolicyActionsRequest Actions { get; set; }

  /// <summary>
  /// The unique identifier of the client this policy applies to.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// The API scopes that may be requested by the client. If empty, all scopes may be requested.
  /// </summary>
  public List<string> Scopes { get; set; }
}


